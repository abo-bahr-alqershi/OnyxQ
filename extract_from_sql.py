import re
import sys
import os
import glob

def extract_table_names_from_mapping(mapping_file):
    """استخراج أسماء الجداول من ملف التخطيط."""
    table_names = []
    with open(mapping_file, 'r', encoding='utf-8') as f:
        for line in f:
            # تخطي التعليقات والأسطر الفارغة
            if line.strip().startswith('#') or not line.strip():
                continue
            # استخراج اسم الجدول القديم (التنسيق: رقم. اسم_الجدول_القديم => ModelName)
            match = re.search(r'^\d+\.\s+(\w+)\s+=>', line)
            if match:
                table_names.append(match.group(1))
    return table_names

def extract_field_names(sql_content, target_tables=None):
    """
    استخراج أسماء الحقول من محتوى SQL، مع تصفية الجداول حسب الاسم اختياريًا.
    إذا تم تقديم target_tables، فسيتم استخراج الحقول من تلك الجداول فقط.
    """
    # تعبير نمطي محسّن للعثور على عبارات CREATE TABLE ومحتوياتها
    # يدعم التنسيقات المختلفة لـ CREATE TABLE بما في ذلك Oracle وMySQL وSQL Server
    create_table_pattern = r'CREATE\s+TABLE\s+(?:IF\s+NOT\s+EXISTS\s+)?[`"\[\]]?(\w+)[`"\[\]]?\s*\((.*?)\)(?:\s*(?:TABLESPACE|ENGINE)\s*=.*?)?(?:;|$)'
    
    # تعبير نمطي محسّن لاستخراج أسماء الحقول من محتويات CREATE TABLE
    # يتعامل مع أنماط متنوعة من تعريفات الحقول
    field_pattern = r'[`"\[\]]?(\w+)[`"\[\]]?\s+(?:\w+(?:\(\s*\d+(?:\s*,\s*\d+)?\s*\))?)'
    
    # البحث عن جميع عبارات CREATE TABLE
    tables = re.findall(create_table_pattern, sql_content, re.IGNORECASE | re.DOTALL)
    
    # مجموعة لتخزين أسماء الحقول الفريدة
    unique_fields = set()
    
    # معالجة كل جدول
    for table_name, table_content in tables:
        # إذا تم تقديم target_tables، فمعالجة الجداول في القائمة فقط
        if target_tables and table_name not in target_tables:
            continue
            
        # استخراج تعريفات الحقول (باستثناء PRIMARY KEY و FOREIGN KEY وما إلى ذلك)
        lines = table_content.split(',')
        for line in lines:
            line = line.strip()
            # تخطي تعريفات القيود
            if re.match(r"(?:PRIMARY|FOREIGN|UNIQUE)\s+KEY", line, re.IGNORECASE) or \
               re.match(r"CONSTRAINT", line, re.IGNORECASE) or \
               re.match(r"KEY", line, re.IGNORECASE) or \
               re.match(r"INDEX", line, re.IGNORECASE):
                continue
            
            # محاولة استخراج اسم الحقل
            field_match = re.match(field_pattern, line, re.IGNORECASE)
            if field_match:
                field_name = field_match.group(1)
                unique_fields.add(field_name)
            else:
                # طريقة بديلة لاستخراج اسم الحقل إذا فشل النمط الأول
                alt_match = re.match(r'[`"\[\]]?(\w+)[`"\[\]]?', line, re.IGNORECASE)
                if alt_match:
                    field_name = alt_match.group(1)
                    unique_fields.add(field_name)
    
    return sorted(list(unique_fields))

def extract_fields_from_raw_sql(sql_content):
    """
    طريقة بديلة لاستخراج أسماء الحقول من SQL باستخدام تعبير نمطي أبسط.
    مفيدة للملفات SQL التي لا تتبع النموذج القياسي لـ CREATE TABLE.
    """
    # استخراج أسماء الحقول من أي تعريف حقل محتمل
    field_defs = re.finditer(r'[`"\[\]]?(\w+)[`"\[\]]?\s+(?:VARCHAR2?|NUMBER|INT|BIGINT|DATE|DATETIME|TIMESTAMP|BOOLEAN|TEXT|CLOB|BLOB|FLOAT|DOUBLE)(?:\(\s*\d+(?:\s*,\s*\d+)?\s*\))?', sql_content, re.IGNORECASE)
    
    # مجموعة لتخزين أسماء الحقول الفريدة
    unique_fields = set()
    
    for match in field_defs:
        field_name = match.group(1)
        if field_name.upper() not in ['CREATE', 'TABLE', 'IF', 'NOT', 'EXISTS', 'PRIMARY', 'FOREIGN', 'KEY', 'CONSTRAINT', 'INDEX', 'UNIQUE']:
            unique_fields.add(field_name)
    
    return sorted(list(unique_fields))

def try_different_encodings(file_path, encodings=None):
    """محاولة قراءة الملف باستخدام ترميزات مختلفة."""
    if encodings is None:
        # قائمة الترميزات المحتملة للملف
        encodings = ['utf-8', 'cp1256', 'iso-8859-6', 'windows-1256', 'latin1', 'cp1252']
    
    for encoding in encodings:
        try:
            with open(file_path, 'r', encoding=encoding) as f:
                return f.read(), encoding
        except UnicodeDecodeError:
            continue
    
    # إذا لم تنجح أي من الترميزات، حاول استخدام وضع القراءة الثنائي
    try:
        with open(file_path, 'rb') as f:
            binary_content = f.read()
            # محاولة إزالة أو استبدال الأحرف غير المتوافقة
            sql_content = binary_content.decode('utf-8', errors='replace')
            return sql_content, 'utf-8 (with replacements)'
    except Exception as e:
        raise Exception(f"فشلت جميع محاولات قراءة الملف: {e}")

def process_sql_files(sql_files_or_dir, target_tables=None):
    """معالجة ملفات SQL واستخراج أسماء الحقول."""
    unique_fields = set()
    
    # تحديد ما إذا كان المدخل هو ملف أو دليل
    if os.path.isdir(sql_files_or_dir):
        # إذا كان دليلًا، فابحث عن جميع ملفات SQL
        sql_files = glob.glob(os.path.join(sql_files_or_dir, "**/*.sql"), recursive=True)
    elif os.path.isfile(sql_files_or_dir):
        # إذا كان ملفًا، فاستخدمه مباشرة
        sql_files = [sql_files_or_dir]
    else:
        # إذا كان قائمة ملفات SQL مفصولة بفواصل
        sql_files = [file.strip() for file in sql_files_or_dir.split(",")]
    
    print(f"معالجة {len(sql_files)} ملف SQL...")
    
    for file_path in sql_files:
        if not os.path.exists(file_path):
            print(f"تحذير: الملف '{file_path}' غير موجود. تخطيه.")
            continue
            
        try:
            # محاولة قراءة الملف باستخدام ترميزات مختلفة
            sql_content, used_encoding = try_different_encodings(file_path)
            print(f"قراءة الملف '{file_path}' باستخدام الترميز: {used_encoding}")
            
            # استخراج الحقول من هذا الملف باستخدام الطريقة الأساسية
            fields1 = extract_field_names(sql_content, target_tables)
            
            # استخراج الحقول باستخدام الطريقة البديلة
            fields2 = extract_fields_from_raw_sql(sql_content)
            
            # دمج النتائج من كلتا الطريقتين
            combined_fields = set(fields1 + fields2)
            
            print(f"  تم العثور على {len(combined_fields)} حقل فريد في هذا الملف")
            unique_fields.update(combined_fields)
            
        except Exception as e:
            print(f"خطأ في معالجة {file_path}: {e}")
    
    return sorted(list(unique_fields))

def main():
    if len(sys.argv) < 2:
        print("الاستخدام: python extract_from_sql.py <ملف_sql_أو_دليل> [ملف_التخطيط]")
        sys.exit(1)
    
    sql_path = sys.argv[1]
    mapping_file = sys.argv[2] if len(sys.argv) > 2 else None
    
    target_tables = None
    if mapping_file:
        try:
            target_tables = extract_table_names_from_mapping(mapping_file)
            print(f"تم استخراج {len(target_tables)} اسم جدول من ملف التخطيط")
        except Exception as e:
            print(f"خطأ في معالجة ملف التخطيط: {e}")
            sys.exit(1)
    
    try:
        # معالجة ملفات SQL
        field_names = process_sql_files(sql_path, target_tables)
        
        print("\nأسماء الحقول الفريدة المستخرجة من سكريبت SQL:")
        for field in field_names:
            print(field)
        
        print(f"\nإجمالي الحقول الفريدة: {len(field_names)}")
        
        # حفظ النتائج في ملف
        output_file = 'extracted_sql_fields.txt'
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write("# أسماء الحقول الفريدة المستخرجة من سكريبت SQL\n\n")
            for field in field_names:
                f.write(f"{field}\n")
            f.write(f"\n# إجمالي الحقول الفريدة: {len(field_names)}")
        
        print(f"\nتم حفظ النتائج في ملف '{output_file}'")
        
    except Exception as e:
        print(f"خطأ: {e}")
        sys.exit(1)

if __name__ == "__main__":
    main() 