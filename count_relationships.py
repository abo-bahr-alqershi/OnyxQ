import json
import os
import glob
import re

# المسارات
OUTPUT_JSON_PATH = "Scheme/output.json"
MODULES_DIR = "Modules"
TABLE_MAPPING_PATH = "Scheme/table_models_mapping.txt"

def load_table_model_mapping():
    """تحميل تخطيط الجداول إلى الموديلات"""
    old_to_new = {}
    new_to_old = {}
    
    with open(TABLE_MAPPING_PATH, 'r', encoding='utf-8') as f:
        for line in f:
            line = line.strip()
            if line and '=>' in line and not line.startswith('#'):
                match = re.search(r'\d+\.\s+(\S+)\s+=>\s+(\S+)', line)
                if match:
                    old_table = match.group(1)
                    new_model = match.group(2)
                    old_to_new[old_table] = new_model
                    new_to_old[new_model] = old_table
    
    return old_to_new, new_to_old

def count_schema_relationships():
    """حساب العلاقات في ملف المخطط"""
    with open(OUTPUT_JSON_PATH, 'r', encoding='utf-8') as f:
        schema_data = json.load(f)
    
    total_fk_relationships = 0
    tables_with_relationships = 0
    relationship_details = {}
    
    old_to_new, _ = load_table_model_mapping()
    
    for table_name, table_info in schema_data.items():
        if "foreign_keys" in table_info and table_info["foreign_keys"]:
            fk_count = len(table_info["foreign_keys"])
            tables_with_relationships += 1
            total_fk_relationships += fk_count
            
            # تخزين تفاصيل العلاقات
            model_name = old_to_new.get(table_name, table_name)
            relationship_details[table_name] = {
                "model_name": model_name,
                "fk_count": fk_count,
                "references": [fk["references_table"] for fk in table_info["foreign_keys"]]
            }
    
    print(f"=== العلاقات في ملف المخطط output.json ===")
    print(f"عدد الجداول: {len(schema_data)}")
    print(f"عدد الجداول التي تحتوي على علاقات خارجية: {tables_with_relationships}")
    print(f"العدد الإجمالي للعلاقات الخارجية (foreign keys): {total_fk_relationships}")
    
    return total_fk_relationships, relationship_details

def count_model_relationships():
    """حساب العلاقات في ملفات الموديلات"""
    all_cs_files = []
    
    for root, dirs, files in os.walk(MODULES_DIR):
        if 'Entities' in root:
            cs_files = glob.glob(os.path.join(root, "*.cs"))
            all_cs_files.extend(cs_files)
    
    navigation_properties = 0
    collection_relationships = 0
    reference_relationships = 0
    model_details = {}
    
    _, new_to_old = load_table_model_mapping()
    
    for cs_file in all_cs_files:
        model_name = os.path.basename(cs_file).replace(".cs", "")
        with open(cs_file, 'r', encoding='utf-8') as f:
            content = f.read()
            
            # Count navigation properties
            nav_props = re.findall(r'public \w+\s+\w+\s+{\s*get;\s*private\s*set;\s*}', content)
            navigation_properties += len(nav_props)
            
            # Count collection relationships
            collection_props = re.findall(r'public ICollection<(\w+)>', content)
            file_collection_count = len(collection_props)
            collection_relationships += file_collection_count
            
            # Count reference relationships
            reference_props = re.findall(r'/// Reference relationship: (\w+)', content)
            file_reference_count = len(reference_props)
            reference_relationships += file_reference_count
            
            # Store model details
            old_table_name = new_to_old.get(model_name, model_name)
            model_details[model_name] = {
                "table_name": old_table_name,
                "collection_count": file_collection_count,
                "reference_count": file_reference_count,
                "total_count": file_collection_count + file_reference_count,
                "collections": collection_props,
                "references": [re.sub(r'.*public (\w+) (\w+) \{.*', r'\2', prop) for prop in nav_props]
            }
    
    total_relationships = collection_relationships + reference_relationships
    
    print(f"\n=== العلاقات في الموديلات ===")
    print(f"عدد ملفات الكيانات (.cs): {len(all_cs_files)}")
    print(f"عدد العلاقات من نوع Collection: {collection_relationships}")
    print(f"عدد العلاقات من نوع Reference: {reference_relationships}")
    print(f"العدد الإجمالي للعلاقات في الموديلات: {total_relationships}")
    
    return total_relationships, model_details

def find_missing_relationships(schema_details, model_details):
    """البحث عن العلاقات المفقودة"""
    old_to_new, new_to_old = load_table_model_mapping()
    
    # تحويل معلومات المخطط إلى تنسيق أسماء الموديلات
    schema_by_model = {}
    for table_name, details in schema_details.items():
        model_name = old_to_new.get(table_name)
        if model_name:
            schema_by_model[model_name] = details
    
    missing_relationships = []
    
    # مقارنة المخطط مع الموديلات
    for table_name, details in schema_details.items():
        model_name = details["model_name"]
        
        # التحقق مما إذا كان الموديل موجود
        if model_name not in model_details:
            missing_relationships.append({
                "table_name": table_name,
                "model_name": model_name,
                "reason": "موديل غير موجود"
            })
            continue
        
        # التحقق من اختلاف عدد العلاقات
        schema_fk_count = details["fk_count"]
        model_rel_count = model_details[model_name]["total_count"]
        
        if schema_fk_count != model_rel_count:
            missing_relationships.append({
                "table_name": table_name,
                "model_name": model_name,
                "schema_relationships": schema_fk_count,
                "model_relationships": model_rel_count,
                "difference": schema_fk_count - model_rel_count,
                "references": details["references"]
            })
    
    return missing_relationships

def main():
    schema_relationships, schema_details = count_schema_relationships()
    model_relationships, model_details = count_model_relationships()
    
    print("\n=== المقارنة ===")
    if schema_relationships == model_relationships:
        print("✅ العلاقات متطابقة بين المخطط والموديلات")
    else:
        print(f"❌ هناك اختلاف في عدد العلاقات: {schema_relationships} في المخطط و {model_relationships} في الموديلات")
        if schema_relationships > model_relationships:
            print(f"   يوجد {schema_relationships - model_relationships} علاقة مفقودة في الموديلات")
            
            # البحث عن العلاقات المفقودة
            missing = find_missing_relationships(schema_details, model_details)
            
            print("\n=== تفاصيل العلاقات المفقودة ===")
            print(f"عدد الموديلات التي تفتقد إلى علاقات: {len(missing)}")
            
            # عرض أول 10 موديلات تفتقد إلى علاقات
            print("\nأمثلة على الموديلات التي تفتقد إلى علاقات:")
            for i, item in enumerate(missing[:10]):
                if "difference" in item:
                    print(f"{i+1}. {item['model_name']} (الجدول: {item['table_name']}): "
                          f"المخطط: {item['schema_relationships']}, "
                          f"الموديل: {item['model_relationships']}, "
                          f"الفرق: {item['difference']}")
                    print(f"   المراجع في المخطط: {item['references']}")
                else:
                    print(f"{i+1}. {item['model_name']} (الجدول: {item['table_name']}): {item['reason']}")
        else:
            print(f"   يوجد {model_relationships - schema_relationships} علاقة إضافية في الموديلات")

if __name__ == "__main__":
    main() 