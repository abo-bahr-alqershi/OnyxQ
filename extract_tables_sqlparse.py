#!/usr/bin/env python3
'''
استخراج جداول قاعدة البيانات من ملف SQL باستخدام مكتبة sqlparse
'''

import sys
import argparse
import json
import sqlparse
from pathlib import Path

def extract_columns_from_statement(statement):
    """
    استخراج الأعمدة من بيان CREATE TABLE
    
    Args:
        statement (sqlparse.sql.Statement): بيان SQL
        
    Returns:
        list: قائمة بمعلومات الأعمدة
    """
    columns = []
    primary_keys = []
    foreign_keys = []
    
    # البحث عن قوسي تعريف الجدول ( )
    parenthesis = None
    for token in statement.tokens:
        if isinstance(token, sqlparse.sql.Parenthesis):
            parenthesis = token
            break
    
    if not parenthesis:
        return columns, primary_keys, foreign_keys
    
    # استخراج التعريفات داخل الأقواس
    try:
        definitions = sqlparse.sql.IdentifierList(parenthesis.tokens).get_identifiers()
    except (AttributeError, TypeError):
        # إذا فشل استخدام IdentifierList، نستخدم طريقة بديلة للاستخراج
        definitions = []
        for token in parenthesis.tokens:
            if not token.is_whitespace and token.ttype != sqlparse.tokens.Punctuation:
                definitions.append(token)
    
    for definition in definitions:
        try:
            # محاولة استخراج tokens إذا كان الكائن يدعم ذلك
            if hasattr(definition, 'tokens'):
                tokens = [t for t in definition.tokens if not (hasattr(t, 'is_whitespace') and t.is_whitespace)]
            else:
                # بالنسبة للكائنات البسيطة، نستخدم الكائن نفسه كـ token وحيد
                tokens = [definition]
            
            # تخطي القيود (مثل PRIMARY KEY, FOREIGN KEY, etc.)
            if tokens and hasattr(tokens[0], 'value') and tokens[0].value.upper() in ('PRIMARY', 'UNIQUE', 'INDEX', 'CONSTRAINT', 'FOREIGN', 'CHECK'):
                
                # استخراج المفاتيح الأساسية
                if tokens[0].value.upper() == 'PRIMARY' and len(tokens) > 3:
                    # البحث عن الأعمدة المحددة في الأقواس
                    for t in tokens:
                        if isinstance(t, sqlparse.sql.Parenthesis):
                            # استخراج أسماء الأعمدة
                            try:
                                column_tokens = sqlparse.sql.IdentifierList(t.tokens).get_identifiers()
                            except (AttributeError, TypeError):
                                # طريقة بديلة للاستخراج
                                column_tokens = []
                                for tk in t.tokens:
                                    if not (hasattr(tk, 'is_whitespace') and tk.is_whitespace) and tk.ttype != sqlparse.tokens.Punctuation:
                                        column_tokens.append(tk)
                            
                            primary_keys = [str(c).strip('`"[]') for c in column_tokens]
                            break
                
                # استخراج المفاتيح الأجنبية
                if tokens[0].value.upper() == 'FOREIGN' and len(tokens) > 5:
                    fk_columns = []
                    ref_table = None
                    
                    # البحث عن الأعمدة المحددة في المفتاح الأجنبي
                    for i, t in enumerate(tokens):
                        if isinstance(t, sqlparse.sql.Parenthesis) and i < len(tokens) - 1:
                            try:
                                column_tokens = sqlparse.sql.IdentifierList(t.tokens).get_identifiers()
                            except (AttributeError, TypeError):
                                # طريقة بديلة للاستخراج
                                column_tokens = []
                                for tk in t.tokens:
                                    if not (hasattr(tk, 'is_whitespace') and tk.is_whitespace) and tk.ttype != sqlparse.tokens.Punctuation:
                                        column_tokens.append(tk)
                            
                            fk_columns = [str(c).strip('`"[]') for c in column_tokens]
                        
                        # البحث عن الجدول المشار إليه
                        if hasattr(t, 'value') and t.value.upper() == 'REFERENCES' and i < len(tokens) - 1:
                            ref_table = str(tokens[i+1]).strip('`"[]')
                            break
                    
                    if fk_columns and ref_table:
                        foreign_keys.append({
                            'columns': fk_columns,
                            'references_table': ref_table
                        })
                
                continue
                
            # استخراج معلومات العمود (إذا كان تعريف عمود)
            if len(tokens) >= 2:
                # محاولة استخراج اسم ونوع العمود
                try:
                    column_name = str(tokens[0]).strip('`"[]')
                    column_type = str(tokens[1])
                    
                    columns.append({
                        'name': column_name,
                        'type': column_type
                    })
                except (IndexError, AttributeError):
                    # تخطي العناصر غير المتوقعة
                    pass
        except Exception as e:
            print(f"تخطي تعريف غير صالح: {str(definition)} - {str(e)}", file=sys.stderr)
            continue
    
    return columns, primary_keys, foreign_keys

def extract_tables_from_sql(sql_content):
    """
    استخراج جداول قاعدة البيانات من محتوى SQL
    
    Args:
        sql_content (str): محتوى ملف SQL
        
    Returns:
        dict: قاموس يحتوي على معلومات الجداول والأعمدة
    """
    # تحليل محتوى SQL
    try:
        statements = sqlparse.parse(sql_content)
    except Exception as e:
        print(f"خطأ في تحليل محتوى SQL: {str(e)}", file=sys.stderr)
        return {}
    
    tables = {}
    
    for statement in statements:
        try:
            # البحث عن بيانات CREATE TABLE
            if statement.get_type() != 'CREATE':
                continue
                
            # التحقق من أن البيان يتضمن إنشاء جدول
            create_table = False
            table_name = None
            
            for token in statement.tokens:
                if hasattr(token, 'value') and token.value.upper() == 'TABLE':
                    create_table = True
                
                # العثور على اسم الجدول (يأتي عادة بعد كلمة TABLE)
                if create_table and isinstance(token, sqlparse.sql.Identifier):
                    table_name = token.value.strip('`"[]')
                    break
                
                # التعامل مع "IF NOT EXISTS"
                if create_table and isinstance(token, sqlparse.sql.Function):
                    # يتم توقع أن اسم الجدول هو آخر identifier في الـ function
                    for func_token in token.tokens:
                        if isinstance(func_token, sqlparse.sql.Identifier):
                            table_name = func_token.value.strip('`"[]')
            
            if create_table and table_name:
                columns, primary_keys, foreign_keys = extract_columns_from_statement(statement)
                
                tables[table_name] = {
                    'columns': columns,
                    'primary_keys': primary_keys,
                    'foreign_keys': foreign_keys
                }
        except Exception as e:
            print(f"تخطي بيان غير صالح: {str(e)}", file=sys.stderr)
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
    parser = argparse.ArgumentParser(description='استخراج جداول قاعدة البيانات من ملف SQL باستخدام sqlparse')
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