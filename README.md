<<<<<<< HEAD
 
=======
# أدوات استخراج هيكل قاعدة البيانات من ملفات SQL

هذه المجموعة من السكربتات تسمح لك باستخراج هيكل قاعدة البيانات (الجداول، الأعمدة، المفاتيح الأساسية والأجنبية) من ملف SQL وتصديرها إلى تنسيق JSON للتحليل أو المعالجة اللاحقة.

## المتطلبات

تعتمد هذه الأدوات على المكتبات التالية:

لجميع السكربتات:
```
pip install argparse
```

للسكربت الثاني:
```
pip install sqlparse
```

للسكربت الثالث:
```
pip install sqlglot
```

## السكربتات المتاحة

### 1. استخراج باستخدام التعابير النمطية (extract_tables_regex.py)

يستخدم هذا السكربت التعابير النمطية (regular expressions) لتحليل ملفات SQL. مناسب للملفات البسيطة نسبياً.

**ميزات:**
- لا يتطلب أي مكتبات إضافية خاصة بـ SQL
- يعمل مع معظم أنواع تعريفات SQL الشائعة
- يدعم استخراج المفاتيح الأجنبية والأساسية

**استخدام:**
```bash
python extract_tables_regex.py schema.sql -o schema.json -p
```

### 2. استخراج باستخدام sqlparse (extract_tables_sqlparse.py)

يستخدم هذا السكربت مكتبة sqlparse لتحليل ملفات SQL بشكل أكثر دقة.

**ميزات:**
- تحليل أكثر موثوقية من التعابير النمطية
- يتعامل بشكل أفضل مع بنى SQL المعقدة
- مناسب لمعظم ملفات SQL

**استخدام:**
```bash
python extract_tables_sqlparse.py schema.sql -o schema.json -p
```

### 3. استخراج باستخدام sqlglot (extract_tables_sqlglot.py)

يستخدم هذا السكربت مكتبة sqlglot لتحليل ملفات SQL، وهي مكتبة متقدمة لتحليل SQL وتحويله.

**ميزات:**
- الأكثر قوة ودقة في التحليل
- يدعم لهجات SQL مختلفة (MySQL, PostgreSQL, SQLite, etc.)
- تحليل معمق لبنية SQL

**استخدام:**
```bash
python extract_tables_sqlglot.py schema.sql -o schema.json -p
```

## خيارات الاستخدام

جميع السكربتات تقبل نفس الخيارات:

- الوسيطة الأولى: مسار ملف SQL المراد تحليله
- `-o, --output`: (اختياري) مسار ملف JSON للإخراج. إذا لم يتم تحديده، سيتم طباعة النتائج على سطر الأوامر.
- `-p, --pretty`: (اختياري) تنسيق ملف JSON الناتج بطريقة مقروءة وسهلة.

## مثال لمخرجات JSON

```json
{
    "users": {
        "columns": [
            {
                "name": "id",
                "type": "INT"
            },
            {
                "name": "username",
                "type": "VARCHAR(50)"
            },
            {
                "name": "email",
                "type": "VARCHAR(100)"
            }
        ],
        "primary_keys": [
            "id"
        ],
        "foreign_keys": []
    },
    "orders": {
        "columns": [
            {
                "name": "id",
                "type": "INT"
            },
            {
                "name": "user_id",
                "type": "INT"
            },
            {
                "name": "order_date",
                "type": "DATETIME"
            }
        ],
        "primary_keys": [
            "id"
        ],
        "foreign_keys": [
            {
                "columns": [
                    "user_id"
                ],
                "references_table": "users"
            }
        ]
    }
}
```

## مقارنة بين السكربتات

| السكربت | الدقة | السرعة | التوافق | المتطلبات الإضافية |
|---------|-------|--------|---------|-------------------|
| extract_tables_regex.py | متوسطة | سريع | معظم ملفات SQL البسيطة | لا يوجد |
| extract_tables_sqlparse.py | جيدة | متوسطة | معظم ملفات SQL | sqlparse |
| extract_tables_sqlglot.py | ممتازة | أبطأ نسبياً | أنواع متعددة من SQL | sqlglot |

## مثال عملي

افترض أن لديك ملف SQL يحتوي على تعريفات لجداول قاعدة بيانات:

```sql
CREATE TABLE users (
    id INT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) UNIQUE
);

CREATE TABLE orders (
    id INT PRIMARY KEY,
    user_id INT NOT NULL,
    order_date DATETIME,
    FOREIGN KEY (user_id) REFERENCES users(id)
);
```

يمكنك استخراج هذه التعريفات باستخدام:

```bash
python extract_tables_regex.py example.sql -o database_structure.json -p
```

وستحصل على ملف JSON يحتوي على هيكل قاعدة البيانات. 
>>>>>>> 0a80883 (u5)
