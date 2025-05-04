import json

# المسارات
OUTPUT_JSON_PATH = "Scheme/output.json"

def main():
    # تحميل مخطط قاعدة البيانات
    with open(OUTPUT_JSON_PATH, 'r', encoding='utf-8') as f:
        schema_data = json.load(f)
    
    # البحث عن جدول S_BRN
    if "S_BRN" in schema_data:
        brn_data = schema_data["S_BRN"]
        print("وجدنا جدول S_BRN في المخطط")
        
        # طباعة المفاتيح الأساسية
        if "primary_keys" in brn_data:
            print(f"المفاتيح الأساسية: {brn_data['primary_keys']}")
        else:
            print("لا توجد مفاتيح أساسية محددة")
        
        # طباعة العلاقات الخارجية
        if "foreign_keys" in brn_data:
            print(f"عدد العلاقات الخارجية: {len(brn_data['foreign_keys'])}")
            for i, fk in enumerate(brn_data["foreign_keys"]):
                print(f"علاقة {i+1}:")
                print(f"  الأعمدة: {fk['columns']}")
                print(f"  يشير إلى: {fk['references_table']}")
        else:
            print("لا توجد علاقات خارجية محددة")
            
        # طباعة الأعمدة
        if "columns" in brn_data:
            print(f"عدد الأعمدة: {len(brn_data['columns'])}")
            print("أول 5 أعمدة:")
            for col in brn_data["columns"][:5]:
                print(f"  {col['name']}: {col['type']}")
    else:
        print("لم نعثر على جدول S_BRN في المخطط")
    
    # التحقق من العلاقات إلى S_BRN
    references_to_s_brn = []
    for table_name, table_data in schema_data.items():
        if "foreign_keys" in table_data:
            for fk in table_data["foreign_keys"]:
                if fk["references_table"] == "S_BRN":
                    references_to_s_brn.append({
                        "table": table_name,
                        "columns": fk["columns"]
                    })
    
    print(f"\nعدد الجداول التي تشير إلى S_BRN: {len(references_to_s_brn)}")
    if references_to_s_brn:
        print("أمثلة:")
        for ref in references_to_s_brn[:5]:
            print(f"  {ref['table']}: {ref['columns']}")
            
    
if __name__ == "__main__":
    main() 