#!/usr/bin/env python3
import json
import re

# قراءة ملف output.json (ملف بنية الجداول)
with open('output.json', 'r', encoding='utf-8') as file:
    structure_data = json.load(file)

# قراءة ملف table_models_mapping.txt (ملف التخطيط)
with open('table_models_mapping.txt', 'r', encoding='utf-8') as file:
    mapping_content = file.readlines()

# استخراج أسماء الجداول من ملف التخطيط
mapping_tables = []
pattern = re.compile(r'^\d+\.\s+([A-Za-z0-9_]+)\s+=>')
for line in mapping_content:
    match = pattern.match(line)
    if match:
        table_name = match.group(1)
        mapping_tables.append(table_name)

# إيجاد الجداول الموجودة في ملف البنية ولكن غير موجودة في ملف التخطيط
structure_tables = set(structure_data.keys())
mapping_tables_set = set(mapping_tables)

# الجداول الموجودة في البنية وليست في التخطيط
missing_in_mapping = structure_tables - mapping_tables_set
# الجداول الموجودة في التخطيط وليست في البنية
missing_in_structure = mapping_tables_set - structure_tables

# عرض النتائج
print(f"إجمالي عدد الجداول في ملف البنية: {len(structure_tables)}")
print(f"إجمالي عدد الجداول في ملف التخطيط: {len(mapping_tables_set)}")

print(f"\nعدد الجداول الموجودة في البنية ولكن غير موجودة في التخطيط: {len(missing_in_mapping)}")
if missing_in_mapping:
    print("وهي:")
    for table in sorted(missing_in_mapping):
        print(f"- {table}")

print(f"\nعدد الجداول الموجودة في التخطيط ولكن غير موجودة في البنية: {len(missing_in_structure)}")
if missing_in_structure:
    print("وهي:")
    for table in sorted(missing_in_structure):
        print(f"- {table}")

if not missing_in_mapping and not missing_in_structure:
    print("\nجميع الجداول متطابقة بين الملفين!") 