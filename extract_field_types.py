import json
import sys
import re
from collections import defaultdict
from typing import Dict, Set, Tuple

def parse_field_type(type_str: str) -> Tuple[str, str]:
    """تحليل نوع الحقل واستخراج الحجم"""
    # تحليل النوع مثل VARCHAR2(30) أو NUMBER(5, 0)
    match = re.match(r'(\w+)\((.*?)\)', type_str)
    if match:
        base_type = match.group(1)
        size = match.group(2)
        return base_type, size
    return type_str, ""

def extract_field_types(json_file_path: str) -> Dict[str, Set[Tuple[str, str]]]:
    """استخراج أنواع الحقول من ملف JSON"""
    try:
        with open(json_file_path, 'r', encoding='utf-8') as f:
            data = json.load(f)
        
        # قاموس لتخزين أنواع الحقول
        field_types: Dict[str, Set[Tuple[str, str]]] = defaultdict(set)
        
        # معالجة كل جدول
        for table_name, table_info in data.items():
            if 'columns' not in table_info:
                continue
            
            # معالجة كل عمود
            for column in table_info['columns']:
                if 'type' in column:
                    base_type, size = parse_field_type(column['type'])
                    # إضافة معلومات النوع والحجم
                    field_types[base_type].add((size, column.get('nullable', True)))
        
        return field_types

def write_field_types(field_types: Dict[str, Set[Tuple[str, str]]], output_file: str):
    """كتابة أنواع الحقول إلى ملف"""
    with open(output_file, 'w', encoding='utf-8') as f:
        for base_type, sizes in sorted(field_types.items()):
            for size, nullable in sorted(sizes):
                # كتابة نوع الحقل وحجمه وإلزاميته
                if size:
                    f.write(f"{base_type}({size}),{1 if nullable else 0}\n")
                else:
                    f.write(f"{base_type},{1 if nullable else 0}\n")

def main():
    if len(sys.argv) != 2:
        print("الاستخدام: python extract_field_types.py <ملف_json>")
        sys.exit(1)
    
    json_file = sys.argv[1]
    output_file = "field_types.txt"
    
    try:
        field_types = extract_field_types(json_file)
        write_field_types(field_types, output_file)
        print(f"تم استخراج أنواع الحقول وكتابتها في الملف: {output_file}")
    except Exception as e:
        print(f"حدث خطأ: {e}")
        sys.exit(1)

if __name__ == "__main__":
    main() 