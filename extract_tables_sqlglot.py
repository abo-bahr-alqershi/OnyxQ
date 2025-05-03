#!/usr/bin/env python3
'''
استخراج جداول قاعدة البيانات من ملف SQL باستخدام مكتبة sqlglot
'''

import sys
import argparse
import json
from pathlib import Path
from sqlglot import parse_one, exp

def extract_tables_from_sql(sql_content):
    """
    استخراج جداول قاعدة البيانات من محتوى SQL
    
    Args:
        sql_content (str): محتوى ملف SQL
        
    Returns:
        dict: قاموس يحتوي على معلومات الجداول والأعمدة
    """
    tables = {}
    
    # تقسيم النص إلى عبارات SQL منفصلة
    sql_statements = [stmt.strip() for stmt in sql_content.split(';') if stmt.strip()]
    
    for statement in sql_statements:
        # محاولة تحليل كل عبارة بشكل منفصل
        try:
            ast = parse_one(statement)
            
            # بحث عن تعريفات إنشاء الجداول
            if isinstance(ast, exp.Create) and ast.kind == 'TABLE':
                table_name = ast.this.name
                schema_name = ast.this.db if hasattr(ast.this, 'db') and ast.this.db else None
                
                if schema_name:
                    full_table_name = f"{schema_name}.{table_name}"
                else:
                    full_table_name = table_name
                
                columns = []
                primary_keys = []
                foreign_keys = []
                
                # استخراج معلومات الأعمدة
                if hasattr(ast, 'expressions'):
                    for expr in ast.expressions:
                        if isinstance(expr, exp.ColumnDef):
                            column_name = expr.this.name
                            column_type = expr.kind.name if expr.kind else "UNKNOWN"
                            
                            columns.append({
                                "name": column_name,
                                "type": column_type
                            })
                            
                            # البحث عن المفاتيح الأساسية المحددة على مستوى العمود
                            for constraint in expr.constraints:
                                if isinstance(constraint, exp.PrimaryKey):
                                    primary_keys.append(column_name)
                            
                        # البحث عن المفاتيح الأساسية المحددة على مستوى الجدول
                        elif isinstance(expr, exp.PrimaryKey):
                            for column in expr.expressions:
                                primary_keys.append(column.this.name)
                        
                        # البحث عن المفاتيح الأجنبية
                        elif isinstance(expr, exp.ForeignKey):
                            fk_columns = []
                            for column in expr.columns:
                                fk_columns.append(column.name)
                            
                            ref_table = expr.reference.name
                            ref_schema = expr.reference.db if hasattr(expr.reference, 'db') and expr.reference.db else None
                            
                            if ref_schema:
                                ref_table_name = f"{ref_schema}.{ref_table}"
                            else:
                                ref_table_name = ref_table
                                
                            foreign_keys.append({
                                "columns": fk_columns,
                                "references_table": ref_table_name
                            })
                
                tables[full_table_name] = {
                    "columns": columns,
                    "primary_keys": primary_keys,
                    "foreign_keys": foreign_keys
                }
        except Exception as e:
            # تخطي العبارات غير المدعومة أو ذات الصيغة الخاطئة
            print(f"تعذر تحليل العبارة: {str(e)}", file=sys.stderr)
            continue
    
    return tables

def read_file_with_encoding(file_path):
    """
    قراءة ملف مع محاولة ترميزات مختلفة
    
    Args:
        file_path (str): مسار الملف
        
    Returns:
        str: محتوى الملف كنص
    """
    # قائمة الترميزات المحتملة للمحاولة
    encodings = [
        'utf-8', 'latin1', 'iso-8859-1', 'iso-8859-15', 
        'cp1256', 'windows-1256', 'utf-16', 'utf-16-le', 'utf-16-be'
    ]
    
    errors = []
    
    # محاولة قراءة الملف باستخدام ترميزات مختلفة
    for encoding in encodings:
        try:
            with open(file_path, 'r', encoding=encoding) as f:
                content = f.read()
                print(f"تم قراءة الملف بنجاح باستخدام ترميز {encoding}")
                return content
        except UnicodeDecodeError as e:
            errors.append(f"{encoding}: {str(e)}")
            continue
    
    # إذا فشلت جميع الترميزات، جرب قراءة الملف كملف ثنائي ثم تحويله
    try:
        with open(file_path, 'rb') as f:
            binary_content = f.read()
            
        # محاولة تخمين الترميز باستخدام مكتبة chardet إذا كانت متوفرة
        try:
            import chardet
            detected = chardet.detect(binary_content)
            detected_encoding = detected['encoding']
            
            if detected_encoding:
                try:
                    content = binary_content.decode(detected_encoding)
                    print(f"تم الكشف عن الترميز {detected_encoding} واستخدامه")
                    return content
                except UnicodeDecodeError:
                    # إذا فشل الترميز المكتشف، استخدم بديل مع تجاهل الأخطاء
                    pass
        except ImportError:
            print("مكتبة chardet غير متوفرة للكشف التلقائي عن الترميز. جاري استخدام طريقة بديلة.")
        
        # محاولة أخيرة باستخدام latin1 مع تجاهل الأخطاء
        content = binary_content.decode('latin1', errors='replace')
        print("تم قراءة الملف باستخدام ترميز latin1 مع استبدال الأحرف غير المعروفة")
        return content
        
    except Exception as e:
        print(f"فشلت جميع محاولات قراءة الملف: {str(e)}")
        print("الأخطاء التي حدثت:")
        for error in errors:
            print(f"  - {error}")
        sys.exit(1)

def main():
    parser = argparse.ArgumentParser(description='استخراج جداول قاعدة البيانات من ملف SQL باستخدام sqlglot')
    parser.add_argument('sql_file', help='مسار ملف SQL')
    parser.add_argument('-o', '--output', help='ملف الإخراج (JSON)')
    parser.add_argument('-p', '--pretty', action='store_true', help='تنسيق ملف JSON بطريقة مقروءة')
    parser.add_argument('-e', '--encoding', help='ترميز ملف SQL (مثل utf-8, latin1)')
    
    args = parser.parse_args()
    
    # التحقق من وجود الملف
    sql_path = Path(args.sql_file)
    if not sql_path.exists():
        print(f"خطأ: الملف {args.sql_file} غير موجود", file=sys.stderr)
        sys.exit(1)
    
    # قراءة محتوى ملف SQL
    try:
        if args.encoding:
            # استخدام الترميز المحدد من قبل المستخدم
            with open(sql_path, 'r', encoding=args.encoding) as f:
                sql_content = f.read()
        else:
            # محاولة اكتشاف الترميز تلقائيًا
            sql_content = read_file_with_encoding(sql_path)
    except Exception as e:
        print(f"خطأ في قراءة الملف: {str(e)}", file=sys.stderr)
        print("يرجى تحديد الترميز الصحيح باستخدام الخيار -e/--encoding", file=sys.stderr)
        sys.exit(1)
    
    # استخراج الجداول
    tables = extract_tables_from_sql(sql_content)
    
    # إخراج النتائج
    if args.output:
        indent = 4 if args.pretty else None
        with open(args.output, 'w', encoding='utf-8') as f:
            json.dump(tables, f, indent=indent, ensure_ascii=False)
        print(f"تم حفظ النتائج في {args.output}")
    else:
        indent = 4 if args.pretty else None
        print(json.dumps(tables, indent=indent, ensure_ascii=False))

if __name__ == "__main__":
    main() 