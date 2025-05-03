#!/usr/bin/env python3
import re
import difflib
import os

def normalize_name(name):
    """
    تطبيع اسم الجدول أو الموديل لتسهيل المقارنة
    - إزالة البادئات المعروفة (IAS_, S_, GLS_, GNR_, HRS_, STN_)
    - تحويل CamelCase إلى lowercase
    - إزالة الأحرف الخاصة
    """
    # إزالة السوابق الشائعة
    name = re.sub(r'^(Ias|S|Gls|Gnr|Hrs|Stn)(?=[A-Z])', '', name)
    
    # إزالة السوابق في أسماء الجداول
    name = re.sub(r'^(IAS_|S_|GLS_|GNR_|HRS_|STN_)', '', name)
    
    # تحويل CamelCase إلى snake_case
    name = re.sub(r'([a-z0-9])([A-Z])', r'\1_\2', name)
    
    # إزالة _DTL و _MST و _BR في نهاية الاسم
    name = re.sub(r'_(DTL|MST|BR)$', '', name)
    
    # تحويل إلى حروف صغيرة وإزالة الأحرف غير الأبجدية الرقمية
    name = re.sub(r'[^a-zA-Z0-9]', '', name.lower())
    
    return name

def get_similarity_score(model_name, table_name):
    """
    حساب درجة التشابه بين اسم الموديل واسم الجدول مع مراعاة أنماط التسمية
    """
    # تطبيع الأسماء
    norm_model = normalize_name(model_name)
    norm_table = normalize_name(table_name)
    
    # مكافأة إضافية إذا كان هناك تطابق بعد التطبيع الكامل
    base_score = difflib.SequenceMatcher(None, norm_model, norm_table).ratio()
    
    # زيادة الدرجة إذا كان هناك تطابق محدد في النمط
    bonus = 0.0
    
    # إذا كان اسم الموديل يشير إلى Detail والجدول يحتوي على DTL
    if ("Detail" in model_name or "detail" in model_name) and "DTL" in table_name:
        bonus += 0.1
    
    # إذا كان اسم الموديل يشير إلى Master والجدول يحتوي على MST
    if ("Master" in model_name or "master" in model_name) and "MST" in table_name:
        bonus += 0.1
    
    # إذا كان اسم الموديل يشير إلى Branch والجدول يحتوي على BR
    if ("Branch" in model_name or "branch" in model_name) and "BR" in table_name:
        bonus += 0.1
    
    # مكافأة إضافية إذا كان الحرف الأول يتطابق
    if model_name[0].lower() == table_name[0].lower():
        bonus += 0.05
    
    return min(base_score + bonus, 1.0)  # لا تتجاوز 1.0

def find_best_matches(model_name, tables):
    """
    البحث عن أفضل تطابقات من الجداول لاسم الموديل
    """
    matches = []
    
    for table in tables:
        score = get_similarity_score(model_name, table)
        matches.append((table, score))
    
    # ترتيب النتائج حسب درجة التطابق، تنازليًا
    matches.sort(key=lambda x: x[1], reverse=True)
    
    # إرجاع أفضل 3 تطابقات
    return matches[:3]

def read_file_lines(filename):
    """
    قراءة ملف وإرجاع محتواه كقائمة من الأسطر بعد إزالة الأسطر الفارغة
    """
    with open(filename, 'r', encoding='utf-8') as f:
        lines = [line.strip() for line in f.readlines() if line.strip()]
    return lines

def write_mapping_to_file(mapping, output_file):
    """
    كتابة نتيجة المقابلة إلى ملف
    """
    with open(output_file, 'w', encoding='utf-8') as f:
        f.write("# تحليل مقابلة الموديلات مع جداول قاعدة البيانات\n")
        f.write("# الصيغة: اسم_الموديل | اسم_الجدول | درجة_التطابق\n\n")
        
        for model, matches in sorted(mapping.items()):
            f.write(f"{model}:\n")
            for idx, (table, score) in enumerate(matches):
                if score >= 0.6:  # عرض التطابقات ذات الدرجة العالية فقط
                    indicator = "✓" if idx == 0 else " "  # علامة للتطابق الأعلى
                    f.write(f"  {indicator} {table} | {score:.2f}\n")
            f.write("\n")

def main():
    # قراءة أسماء الجداول والموديلات
    tables_file = 'tables.txt'
    models_file = 'sorted_filenames.txt'
    output_file = 'model_table_mapping.txt'
    
    # التأكد من وجود الملفات
    for file in [tables_file, models_file]:
        if not os.path.exists(file):
            print(f"خطأ: الملف {file} غير موجود")
            return
    
    tables = read_file_lines(tables_file)
    models = read_file_lines(models_file)
    
    print(f"تم قراءة {len(tables)} جدول و {len(models)} موديل")
    
    # إنشاء قاموس للمقابلة
    mapping = {}
    
    # البحث عن أفضل تطابقات لكل موديل
    for model in models:
        best_matches = find_best_matches(model, tables)
        mapping[model] = best_matches
    
    # كتابة النتيجة إلى ملف
    write_mapping_to_file(mapping, output_file)
    
    print(f"تم إنشاء ملف المقابلة بنجاح: {output_file}")

if __name__ == "__main__":
    main() 