#!/usr/bin/env python3
import json

# قراءة ملف output.json
with open('output.json', 'r', encoding='utf-8') as file:
    data = json.load(file)

# حساب إجمالي عدد الجداول
total_tables = len(data)
print(f"إجمالي عدد الجداول: {total_tables}")

# حساب متوسط عدد الأعمدة في الجداول
total_columns = 0
tables_with_columns = 0
tables_without_columns = []
max_columns = 0
min_columns = float('inf')
max_columns_table = ""
min_columns_table = ""

for table_name, table_data in data.items():
    if 'columns' in table_data:
        num_columns = len(table_data['columns'])
        total_columns += num_columns
        tables_with_columns += 1
        
        # تحديث أكبر عدد أعمدة
        if num_columns > max_columns:
            max_columns = num_columns
            max_columns_table = table_name
            
        # تحديث أقل عدد أعمدة
        if num_columns < min_columns:
            min_columns = num_columns
            min_columns_table = table_name
    else:
        tables_without_columns.append(table_name)

avg_columns = total_columns / tables_with_columns if tables_with_columns > 0 else 0
print(f"متوسط عدد الأعمدة في الجداول: {avg_columns:.2f}")
print(f"أكبر عدد أعمدة: {max_columns} في جدول {max_columns_table}")
print(f"أقل عدد أعمدة: {min_columns} في جدول {min_columns_table}")

# حساب عدد الجداول التي تحتوي على مفاتيح أجنبية
tables_with_foreign_keys = 0
total_foreign_keys = 0
max_foreign_keys = 0
max_foreign_keys_table = ""

for table_name, table_data in data.items():
    if 'foreign_keys' in table_data and table_data['foreign_keys']:
        tables_with_foreign_keys += 1
        num_foreign_keys = len(table_data['foreign_keys'])
        total_foreign_keys += num_foreign_keys
        
        # تحديث أكبر عدد مفاتيح أجنبية
        if num_foreign_keys > max_foreign_keys:
            max_foreign_keys = num_foreign_keys
            max_foreign_keys_table = table_name

print(f"\nعدد الجداول التي تحتوي على مفاتيح أجنبية: {tables_with_foreign_keys}")
print(f"إجمالي عدد المفاتيح الأجنبية: {total_foreign_keys}")
print(f"متوسط عدد المفاتيح الأجنبية للجدول: {total_foreign_keys / tables_with_foreign_keys:.2f}")
print(f"أكبر عدد مفاتيح أجنبية: {max_foreign_keys} في جدول {max_foreign_keys_table}")

# حساب الجداول الأكثر ارتباطًا بها (أكثر المراجع)
references_count = {}
for table_name, table_data in data.items():
    if 'foreign_keys' in table_data:
        for fk in table_data['foreign_keys']:
            if 'references_table' in fk:
                ref_table = fk['references_table']
                references_count[ref_table] = references_count.get(ref_table, 0) + 1

# الجداول الأكثر ارتباطًا بها
most_referenced_tables = sorted(references_count.items(), key=lambda x: x[1], reverse=True)[:10]
print("\nالجداول الأكثر ارتباطًا بها (أعلى 10):")
for table, count in most_referenced_tables:
    print(f"{table}: {count} مرة")

# توزيع أنواع البيانات
data_types = {}
for table_name, table_data in data.items():
    if 'columns' in table_data:
        for column in table_data['columns']:
            if 'type' in column:
                column_type = column['type'].split('(')[0]  # استخراج النوع الأساسي
                data_types[column_type] = data_types.get(column_type, 0) + 1

print("\nتوزيع أنواع البيانات:")
for data_type, count in sorted(data_types.items(), key=lambda x: x[1], reverse=True):
    print(f"{data_type}: {count}") 