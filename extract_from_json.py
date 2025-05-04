import json
import sys
import os
import re
from collections import defaultdict
from typing import Dict, Set, List, Optional
from dataclasses import dataclass

@dataclass
class FieldInfo:
    """تمثيل معلومات الحقل"""
    name: str
    field_type: str
    is_nullable: bool = True
    description: str = ""

def extract_table_names_from_mapping(mapping_file: str) -> List[str]:
    """استخراج أسماء الجداول من ملف التخطيط"""
    table_names = []
    try:
        with open(mapping_file, 'r', encoding='utf-8') as f:
            for line in f:
                if line.strip().startswith('#') or not line.strip():
                    continue
                match = re.search(r'^\d+\.\s+(\w+)\s+=>', line)
                if match:
                    table_names.append(match.group(1))
        return table_names
    except FileNotFoundError:
        print(f"خطأ: ملف التخطيط '{mapping_file}' غير موجود")
        sys.exit(1)
    except Exception as e:
        print(f"خطأ في قراءة ملف التخطيط: {e}")
        sys.exit(1)

def create_new_file(base_name: str, file_number: int) -> str:
    """إنشاء ملف جديد مع الرقم المناسب"""
    return f"{base_name}_part{file_number}.txt"

def extract_fields_from_json(json_file_path: str, mapping_file: str) -> Optional[Dict[str, List[FieldInfo]]]:
    """استخراج أسماء الحقول وتفاصيلها من ملف JSON"""
    try:
        allowed_tables = set(extract_table_names_from_mapping(mapping_file))
        print(f"تم استخراج {len(allowed_tables)} جدول من ملف التخطيط")
        
        with open(json_file_path, 'r', encoding='utf-8') as f:
            data = json.load(f)
        
        # قاموس لتخزين الحقول مع معلوماتها لكل جدول
        table_fields: Dict[str, List[FieldInfo]] = defaultdict(list)
        
        for table_name, table_info in data.items():
            if table_name not in allowed_tables:
                continue
                
            if 'columns' not in table_info:
                continue
                
            for column in table_info['columns']:
                if 'name' in column:
                    field_info = FieldInfo(
                        name=column['name'],
                        field_type=column.get('type', 'unknown'),
                        is_nullable=column.get('nullable', True),
                        description=column.get('description', '')
                    )
                    table_fields[table_name].append(field_info)
        
        # ترتيب الحقول لكل جدول
        for table_name in table_fields:
            table_fields[table_name].sort(key=lambda x: x.name)
        
        # تقسيم وكتابة الملفات
        fields_per_file = 500
        current_file_number = 1
        created_files = []
        
        all_fields: List[FieldInfo] = []
        for fields in table_fields.values():
            all_fields.extend(fields)
        
        # إزالة التكرار مع الحفاظ على المعلومات
        unique_fields = {f.name: f for f in all_fields}.values()
        sorted_fields = sorted(unique_fields, key=lambda x: x.name)
        
        for i in range(0, len(sorted_fields), fields_per_file):
            filename = create_new_file('fields', current_file_number)
            created_files.append(filename)
            
            with open(filename, 'w', encoding='utf-8') as f:
                chunk = sorted_fields[i:i + fields_per_file]
                for field in chunk:
                    # كتابة اسم الحقل فقط في كل سطر
                    f.write(f"{field.name}\n")
            
            current_file_number += 1
        
        print(f"\nتم استخراج {len(sorted_fields)} حقل فريد")
        print(f"تم تقسيمهم على {len(created_files)} ملف")
        print("\nالملفات التي تم إنشاؤها:")
        for filename in created_files:
            print(f"- {filename}")
        
        return table_fields
        
    except json.JSONDecodeError as e:
        print(f"خطأ في تنسيق ملف JSON: {e}")
        return None
    except Exception as e:
        print(f"حدث خطأ: {e}")
        return None

def main():
    if len(sys.argv) != 3:
        print("الاستخدام: python extract_from_json.py <ملف_json> <ملف_التخطيط>")
        sys.exit(1)
    
    json_file = sys.argv[1]
    mapping_file = sys.argv[2]
    extract_fields_from_json(json_file, mapping_file)

if __name__ == "__main__":
    main() 