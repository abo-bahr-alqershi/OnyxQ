#!/usr/bin/env python3
import json

# قراءة ملف output.json
with open('output.json', 'r', encoding='utf-8') as file:
    data = json.load(file)

# حساب عدد الجداول
num_tables = len(data)

# عرض النتيجة
print(f"عدد الجداول في الملف: {num_tables}")

# طباعة قائمة بأسماء الجداول
print("\nقائمة بأسماء الجداول:")
for i, table_name in enumerate(data.keys(), 1):
    print(f"{i}. {table_name}") 