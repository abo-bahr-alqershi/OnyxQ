#!/usr/bin/env python3
'''
استخراج جداول قاعدة البيانات من ملف SQL باستخدام التعابير النمطية
'''

import re
import sys
import argparse
import json
from pathlib import Path

def extract_tables_from_sql(sql_content):
    """
    استخراج جداول قاعدة البيانات من محتوى SQL
    
    Args:
        sql_content (str): محتوى ملف SQL
        
    Returns:
        dict: قاموس يحتوي على معلومات الجداول والأعمدة
    """
    # إزالة التعليقات للحصول على نص SQL نظيف
    sql_content = re.sub(r'--.*?$', '', sql_content, flags=re.MULTILINE)  # تعليقات السطر الواحد
    sql_content = re.sub(r'/\*[\s\S]*?\*/', '', sql_content)  # تعليقات متعددة الأسطر
    
    # العثور على كل تعريفات CREATE TABLE
    create_table_pattern = r'CREATE\s+TABLE\s+(?:IF\s+NOT\s+EXISTS\s+)?[`"\[]?(\w+)[`"\]]?(?:\s*\.\s*[`"\[]?(\w+)[`"\]]?)?\s*\(([\s\S]*?)(?:\)\s*(?:PCTFREE|TABLESPACE|INITRANS|MAXTRANS|STORAGE|LOGGING|NOCOMPRESS|\;))'
    
    tables = {}
    
    for match in re.finditer(create_table_pattern, sql_content, re.IGNORECASE):
        schema_name = match.group(1)
        table_name = match.group(2) if match.group(2) else schema_name
        
        if match.group(2):  # إذا تم تحديد schema
            full_table_name = f"{schema_name}.{table_name}"
        else:
            full_table_name = table_name
            
        column_section = match.group(3)
        
        # استخراج الأعمدة - تحسين النمط ليناسب SQL اوراكل
        # استخراج أسماء الأعمدة وأنواعها بشكل صحيح، مع معالجة الأقواس والفواصل في الأنواع
        column_pattern = r'[\s,]*[`"\[]?(\w+)[`"\]]?\s+((?:VARCHAR2?|NUMBER|DATE|TIMESTAMP|CHAR|CLOB|BLOB|FLOAT|DOUBLE|INTEGER|DECIMAL|BOOLEAN)(?:\s*\(\s*[\d,\s]+\s*\))?(?:\s+[A-Z]+)*)'
        columns = []
        
        for col_match in re.finditer(column_pattern, column_section):
            column_name = col_match.group(1)
            column_type = col_match.group(2).strip()
            
            # تنظيف نوع العمود من أي إضافات غير ضرورية
            base_type = re.match(r'^((?:VARCHAR2?|NUMBER|DATE|TIMESTAMP|CHAR|CLOB|BLOB|FLOAT|DOUBLE|INTEGER|DECIMAL|BOOLEAN)(?:\s*\(\s*[\d,\s]+\s*\))?)', column_type)
            if base_type:
                column_type = base_type.group(1).strip()
                
            columns.append({
                "name": column_name,
                "type": column_type
            })
        
        # البحث عن المفاتيح الأساسية من جملات ALTER TABLE ADD CONSTRAINT
        primary_key_pattern = r'ALTER\s+TABLE\s+[`"\[]?' + re.escape(full_table_name) + r'[`"\]]?\s+ADD\s+CONSTRAINT\s+[`"\[]?\w+[`"\]]?\s+PRIMARY\s+KEY\s*\(\s*([^)]+)\s*\)'
        pk_matches = re.finditer(primary_key_pattern, sql_content, re.IGNORECASE)
        primary_keys = []
        
        for pk_match in pk_matches:
            pk_columns_text = pk_match.group(1)
            pk_columns = re.findall(r'[`"\[]?(\w+)[`"\]]?', pk_columns_text)
            primary_keys.extend([col for col in pk_columns if col.lower() not in ('primary', 'key')])
        
        # إذا لم نجد مفاتيح أساسية في جملات ALTER، نبحث في تعريف الجدول
        if not primary_keys:
            primary_key_inline_pattern = r'PRIMARY\s+KEY\s*\(\s*([^)]+)\s*\)'
            pk_inline_match = re.search(primary_key_inline_pattern, column_section, re.IGNORECASE)
            if pk_inline_match:
                pk_columns_text = pk_inline_match.group(1)
                pk_columns = re.findall(r'[`"\[]?(\w+)[`"\]]?', pk_columns_text)
                primary_keys.extend([col for col in pk_columns if col.lower() not in ('primary', 'key')])
        
        # البحث عن المفاتيح الأجنبية من جملات ALTER TABLE ADD CONSTRAINT
        foreign_key_pattern = r'ALTER\s+TABLE\s+[`"\[]?' + re.escape(full_table_name) + r'[`"\[]?\s+ADD\s+CONSTRAINT\s+[`"\[]?\w+[`"\[]?\s+FOREIGN\s+KEY\s*\(\s*([^)]+)\s*\)\s*REFERENCES\s+[`"\[]?(\w+)(?:\.[`"\[]?(\w+))?[`"\[]?(?:\s*\(\s*([^)]+)\s*\))?'
        fk_matches = re.finditer(foreign_key_pattern, sql_content, re.IGNORECASE)
        foreign_keys = []
        
        for fk_match in fk_matches:
            fk_columns_text = fk_match.group(1)
            fk_columns = re.findall(r'[`"\[]?(\w+)[`"\[]?', fk_columns_text)
            fk_columns = [col for col in fk_columns if col.lower() not in ('foreign', 'key')]
            
            ref_schema = fk_match.group(2)
            ref_table = fk_match.group(3) if fk_match.group(3) else ref_schema
            
            if fk_match.group(3):  # إذا تم تحديد schema
                ref_table_name = f"{ref_schema}.{ref_table}"
            else:
                ref_table_name = ref_table
                
            foreign_keys.append({
                "columns": fk_columns,
                "references_table": ref_table_name
            })
        
        # إذا لم نجد مفاتيح أجنبية في جملات ALTER، نبحث في تعريف الجدول
        if not foreign_keys:
            foreign_key_inline_pattern = r'FOREIGN\s+KEY\s*\(\s*([^)]+)\s*\)\s*REFERENCES\s+[`"\[]?(\w+)(?:\.[`"\[]?(\w+))?[`"\[]?(?:\s*\(\s*([^)]+)\s*\))?'
            fk_inline_matches = re.finditer(foreign_key_inline_pattern, column_section, re.IGNORECASE)
            
            for fk_inline_match in fk_inline_matches:
                fk_columns_text = fk_inline_match.group(1)
                fk_columns = re.findall(r'[`"\[]?(\w+)[`"\[]?', fk_columns_text)
                fk_columns = [col for col in fk_columns if col.lower() not in ('foreign', 'key')]
                
                ref_schema = fk_inline_match.group(2)
                ref_table = fk_inline_match.group(3) if fk_inline_match.group(3) else ref_schema
                
                if fk_inline_match.group(3):  # إذا تم تحديد schema
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
    parser = argparse.ArgumentParser(description='استخراج جداول قاعدة البيانات من ملف SQL')
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
    
    # تحديد مسار ملف الإخراج
    if args.output:
        output_path = Path(args.output)
    else:
        # إنشاء اسم ملف افتراضي بناءً على اسم ملف SQL
        output_path = sql_path.with_suffix('.json')
        print(f"لم يتم تحديد ملف الإخراج. سيتم الحفظ في: {output_path}")
    
    # إنشاء المجلد الأب إذا لم يكن موجوداً
    output_path.parent.mkdir(parents=True, exist_ok=True)
    
    # حفظ النتائج في الملف
    indent = 4 if args.pretty else None
    try:
        with open(output_path, 'w', encoding='utf-8') as f:
            json.dump(tables, f, indent=indent, ensure_ascii=False)
        print(f"تم حفظ النتائج بنجاح في {output_path}")
    except Exception as e:
        print(f"خطأ في حفظ النتائج: {str(e)}", file=sys.stderr)
        # طباعة النتائج على الشاشة في حالة فشل الحفظ
        print("محتوى النتائج:")
        print(json.dumps(tables, indent=indent, ensure_ascii=False))

if __name__ == "__main__":
    main() 