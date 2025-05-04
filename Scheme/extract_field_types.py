import json
import sys
import re
from collections import defaultdict
from typing import Dict, Set, Tuple

def get_dotnet_type(oracle_type: str, is_nullable: bool) -> str:
    """تحويل نوع Oracle إلى نوع C#"""
    base_type = oracle_type.split('(')[0]
    
    type_mapping = {
        'VARCHAR2': 'string',
        'CHAR': 'string',
        'CLOB': 'string',
        'BLOB': 'byte[]',
        'DATE': 'DateTime'
    }
    
    if base_type == 'NUMBER':
        # استخراج الدقة والنطاق للأرقام
        match = re.match(r'NUMBER\((\d+)(?:,\s*(\d+))?\)', oracle_type)
        if match:
            precision = int(match.group(1))
            scale = int(match.group(2)) if match.group(2) else 0
            
            if scale == 0:  # أرقام صحيحة
                if precision == 1:
                    dotnet_type = 'bool'
                elif precision <= 4:
                    dotnet_type = 'short'
                elif precision <= 9:
                    dotnet_type = 'int'
                elif precision <= 18:
                    dotnet_type = 'long'
                else:
                    dotnet_type = 'decimal'
            else:  # أرقام عشرية
                dotnet_type = 'decimal'
        else:
            dotnet_type = 'decimal'
    else:
        dotnet_type = type_mapping.get(base_type, 'object')
    
    # إضافة ? للأنواع القابلة للإسناد إلى null
    if is_nullable and dotnet_type not in ['string', 'byte[]', 'object']:
        dotnet_type += '?'
    
    return dotnet_type

def parse_field_type(type_str: str) -> Tuple[str, str]:
    """تحليل نوع الحقل واستخراج الحجم"""
    match = re.match(r'(\w+)\((.*?)\)', type_str)
    if match:
        base_type = match.group(1)
        size = match.group(2)
        return base_type, size
    return type_str, ""

def extract_field_types(json_file_path: str) -> Dict[str, Set[Tuple[str, bool]]]:
    """استخراج أنواع الحقول من ملف JSON"""
    field_types = defaultdict(set)
    
    try:
        with open(json_file_path, 'r', encoding='utf-8') as f:
            data = json.load(f)
            
        for table_name, table_info in data.items():
            if 'columns' not in table_info:
                continue
            
            for column in table_info['columns']:
                if 'type' in column:
                    base_type, size = parse_field_type(column['type'])
                    is_nullable = column.get('nullable', True)
                    full_type = f"{base_type}({size})" if size else base_type
                    field_types[base_type].add((full_type, is_nullable))
                    
    except FileNotFoundError:
        print(f"خطأ: الملف '{json_file_path}' غير موجود")
        sys.exit(1)
    except json.JSONDecodeError:
        print(f"خطأ: الملف '{json_file_path}' ليس بتنسيق JSON صحيح")
        sys.exit(1)
    except Exception as e:
        print(f"حدث خطأ: {e}")
        sys.exit(1)
        
    return field_types

def write_field_types(field_types: Dict[str, Set[Tuple[str, bool]]], output_file: str):
    """كتابة أنواع الحقول إلى ملف"""
    try:
        with open(output_file, 'w', encoding='utf-8') as f:
            all_types = []
            for type_info in field_types.values():
                all_types.extend(type_info)
            
            for oracle_type, nullable in sorted(all_types):
                dotnet_type = get_dotnet_type(oracle_type, nullable)
                f.write(f"{oracle_type},{1 if nullable else 0} => {dotnet_type}\n")
                
    except Exception as e:
        print(f"خطأ في كتابة الملف: {e}")
        sys.exit(1)

def main():
    if len(sys.argv) != 2:
        print("الاستخدام: python extract_field_types.py <ملف_json>")
        sys.exit(1)
    
    json_file = sys.argv[1]
    output_file = "field_types.txt"
    
    field_types = extract_field_types(json_file)
    write_field_types(field_types, output_file)
    print(f"تم استخراج أنواع الحقول وكتابتها في الملف: {output_file}")

if __name__ == "__main__":
    main() 
