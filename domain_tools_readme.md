# أدوات تحسين نماذج النطاق (Domain Models)

هذه الأدوات تساعد في تحسين نماذج النطاق من خلال تحديد Value Objects وأحداث النطاق (Domain Events) وإنشاء الشيفرة المقابلة لها.

## المكونات الرئيسية

1. **value_object_identifier.py**: أداة لتحديد Value Objects في النماذج
2. **domain_events_generator.py**: أداة لتحديد أحداث النطاق للنماذج
3. **domain_model_enhancer.py**: أداة متكاملة تجمع بين الوظائف السابقة وتولد الشيفرة المقابلة

## الملفات الإرشادية

عند تشغيل الأدوات، يتم إنشاء ملفات إرشادية توضح قواعد تحديد Value Objects وأحداث النطاق:

- **value_objects_guidelines.md**: إرشادات تحديد Value Objects
- **domain_events_guidelines.md**: إرشادات أحداث النطاق

## طرق الاستخدام

### 1. تحليل Value Objects وإنشاء إرشادات عامة

```bash
python3 value_object_identifier.py
```

ينتج هذا الأمر:
- ملف `value_objects_analysis.json`: تحليل مفصل للقيم المحددة
- ملف `value_objects_guidelines.md`: إرشادات تحديد Value Objects

### 2. تحليل أحداث النطاق وإنشاء إرشادات عامة

```bash
python3 domain_events_generator.py
```

ينتج هذا الأمر:
- ملف `domain_events_analysis.json`: تحليل مفصل لأحداث النطاق
- ملف `domain_events_guidelines.md`: إرشادات تحديد أحداث النطاق

### 3. تحليل وإنشاء شيفرة لنموذج محدد

```bash
python3 domain_model_enhancer.py [اسم_النموذج]
```

مثال:
```bash
python3 domain_model_enhancer.py Customer
```

ينتج هذا الأمر في مجلد `output/`:

- ملف تقرير: `Customer_report.json`
- ملفات Value Objects: `Customer_[نوع_الكائن].cs`
- ملفات أحداث النطاق: `Customer[اسم_الحدث]Event.cs`
- ملف النموذج الكامل: `Customer.cs`

يمكنك تحديد مجلد الإخراج باستخدام خيار `--output-dir`:

```bash
python3 domain_model_enhancer.py Customer --output-dir CustomerCode
```

## التخصيص

يمكن تخصيص سلوك هذه الأدوات من خلال تعديل المتغيرات التالية:

### في `value_object_identifier.py`

تعديل `value_object_patterns` لتغيير أنماط تحديد Value Objects:

```python
value_object_patterns = {
    "ContactInfo": {
        "keywords": ["PHONE", "MOBILE", "EMAIL", "E_MAIL", "FAX", ...],
        "min_matches": 2,
    },
    ...
}
```

### في `domain_events_generator.py`

تعديل:
- `event_categories`: لتغيير فئات الأحداث
- `module_event_categories`: لتغيير الأحداث حسب الوحدات
- `entity_name_patterns`: لتغيير أنماط تطابق أسماء الكيانات

## ملاحظات التطوير

1. **إضافة أنماط جديدة**: يمكن إضافة أنماط جديدة لـ Value Objects أو أحداث النطاق حسب متطلبات المشروع.
2. **تحسين الاكتشاف التلقائي**: يمكن تحسين خوارزميات اكتشاف الحقول المرتبطة بكل نموذج.
3. **إضافة قوالب جديدة**: يمكن إضافة قوالب شيفرة جديدة لأنواع أخرى من الكيانات.

## الأهداف المستقبلية

1. تحسين اكتشاف العلاقات بين النماذج وإضافتها للشيفرة المولدة.
2. إضافة دعم لإنشاء الاختبارات الوحدة التلقائية.
3. إضافة دعم لتوليد مكونات طبقة التطبيق (الأوامر والاستعلامات) بناءً على نمط CQRS.
4. إنشاء واجهة مستخدم رسومية لتسهيل عملية التحليل والتوليد.

## المتطلبات

- Python 3.6+
- نظام ملفات يحتوي على:
  - مجلد `Scheme/Feilds` لملفات ترجمة أسماء الحقول
  - ملف `Scheme/table_models_mapping.txt` لمطابقة الجداول والنماذج 