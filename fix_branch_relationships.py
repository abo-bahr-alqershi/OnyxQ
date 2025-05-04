import json
import os
import re

# المسارات
OUTPUT_JSON_PATH = "Scheme/output.json"
TABLE_MAPPING_PATH = "Scheme/table_models_mapping.txt"
BRANCH_MODEL_PATH = "Modules/CoreSystem/Entities/Branch.cs"

def load_schema():
    """تحميل مخطط قاعدة البيانات"""
    with open(OUTPUT_JSON_PATH, 'r', encoding='utf-8') as f:
        schema_data = json.load(f)
    return schema_data

def get_branch_foreign_keys(schema):
    """الحصول على العلاقات الخارجية لكيان Branch"""
    branch_table = "S_BRN"
    if branch_table in schema:
        table_info = schema[branch_table]
        if "foreign_keys" in table_info:
            return table_info["foreign_keys"]
    return []

def find_table_model_mapping():
    """البحث عن تخطيط الجداول إلى الموديلات"""
    old_to_new = {}
    with open(TABLE_MAPPING_PATH, 'r', encoding='utf-8') as f:
        for line in f:
            line = line.strip()
            if line and '=>' in line and not line.startswith('#'):
                match = re.search(r'\d+\.\s+(\S+)\s+=>\s+(\S+)', line)
                if match:
                    old_table = match.group(1)
                    new_model = match.group(2)
                    old_to_new[old_table] = new_model
    return old_to_new

def check_branch_model():
    """فحص ملف موديل Branch الحالي"""
    if os.path.exists(BRANCH_MODEL_PATH):
        with open(BRANCH_MODEL_PATH, 'r', encoding='utf-8') as f:
            content = f.read()
        
        # تحقق من وجود قسم Navigation Properties
        has_nav_section = "#region Navigation Properties" in content
        
        # عد العلاقات الموجودة
        reference_props = re.findall(r'/// Reference relationship: \w+', content)
        collection_props = re.findall(r'public ICollection<\w+>', content)
        
        return {
            "has_nav_section": has_nav_section,
            "reference_count": len(reference_props),
            "collection_count": len(collection_props)
        }
    return None

def main():
    # تحميل المخطط
    schema = load_schema()
    
    # الحصول على العلاقات الخارجية لكيان Branch
    branch_fks = get_branch_foreign_keys(schema)
    
    # البحث عن تخطيط الجداول إلى الموديلات
    table_mapping = find_table_model_mapping()
    
    # فحص ملف موديل Branch الحالي
    branch_model_info = check_branch_model()
    
    print("=== تحليل العلاقات المفقودة في كيان Branch ===")
    
    print("\n1. العلاقات الخارجية في المخطط:")
    for i, fk in enumerate(branch_fks):
        ref_table = fk["references_table"]
        ref_model = table_mapping.get(ref_table, ref_table)
        print(f"   {i+1}. جدول: {ref_table}, موديل: {ref_model}, الأعمدة: {fk['columns']}")
    
    print("\n2. معلومات موديل Branch الحالي:")
    if branch_model_info:
        print(f"   - يحتوي على قسم العلاقات: {'نعم' if branch_model_info['has_nav_section'] else 'لا'}")
        print(f"   - عدد علاقات المراجع: {branch_model_info['reference_count']}")
        print(f"   - عدد علاقات المجموعات: {branch_model_info['collection_count']}")
    else:
        print("   ملف الموديل غير موجود")
    
    # التأكد من وجود جميع الجداول في ملف التخطيط
    missing_mappings = []
    for fk in branch_fks:
        ref_table = fk["references_table"]
        if ref_table not in table_mapping:
            missing_mappings.append(ref_table)
    
    if missing_mappings:
        print("\n3. الجداول المشار إليها غير موجودة في ملف تخطيط الجداول إلى الموديلات:")
        for table in missing_mappings:
            print(f"   - {table}")
    else:
        print("\n3. جميع الجداول المشار إليها موجودة في ملف تخطيط الجداول إلى الموديلات")

if __name__ == "__main__":
    main() 