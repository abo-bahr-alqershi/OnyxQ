# هيكل المشروع (Project Structure)

## مقدمة

يتبع هذا المشروع هيكلية العمارة النظيفة (Clean Architecture) والتصميم الموجه بالنطاق (Domain-Driven Design). الهدف هو إنشاء نظام مرن وقابل للصيانة والتوسع، مع فصل واضح للمسؤوليات بين الطبقات المختلفة.

## الهيكل العام

### 1. مشروع النطاق (Domain Project)

**المسار:** `ERP_Pro.Domain`

**الوصف:** يمثل قلب النظام ويحتوي على:
- كيانات الأعمال (Business Entities)
- كائنات القيمة (Value Objects)
- الأحداث (Domain Events)
- مواصفات الكيانات (Specifications)
- الاستثناءات (Exceptions)
- الواجهات الأساسية (Core Interfaces)

**البنية الداخلية:**
```
ERP_Pro.Domain/
│
├── Common/                 # الكيانات والواجهات المشتركة
│   ├── Base/               # الفئات الأساسية
│   ├── Entities/           # الكيانات الأساسية المشتركة
│   ├── Exceptions/         # استثناءات النطاق
│   ├── Interfaces/         # الواجهات المشتركة
│   └── ValueObjects/       # كائنات القيمة المشتركة
│
├── SettingsParameters/     # نطاق إعدادات ومعلمات النظام
│   ├── Entities/           # كيانات النطاق
│   ├── Events/             # أحداث النطاق
│   ├── Exceptions/         # استثناءات النطاق
│   ├── Services/           # خدمات النطاق
│   └── ValueObjects/       # كائنات القيمة للنطاق
│
├── InventoryWarehousing/   # نطاق المخزون والمستودعات
│   ├── Entities/           # كيانات النطاق
│   ├── Events/             # أحداث النطاق
│   ├── Exceptions/         # استثناءات النطاق
│   ├── Services/           # خدمات النطاق
│   └── ValueObjects/       # كائنات القيمة للنطاق
│
└── [مجالات أخرى]/         # نطاقات أخرى في النظام
```

### 2. مشروع التطبيق (Application Project)

**المسار:** `ERP_Pro.Application`

**الوصف:** يحتوي على منطق التطبيق ويعمل كوسيط بين طبقة النطاق وطبقة البنية التحتية:
- الأوامر (Commands)
- الاستعلامات (Queries)
- المعالجات (Handlers)
- نماذج نقل البيانات (DTOs)
- التحققات (Validators)
- ملفات التعيين (Mapping Profiles)
- خدمات التطبيق (Application Services)

**البنية الداخلية:**
```
ERP_Pro.Application/
│
├── Common/                  # المكونات المشتركة
│   ├── Behaviors/           # سلوكيات الوسيط
│   ├── Exceptions/          # استثناءات التطبيق
│   ├── Interfaces/          # واجهات التطبيق
│   ├── Mappings/            # ملفات التعيين العامة
│   └── Models/              # نماذج مشتركة
│
├── DependencyInjection.cs   # تسجيل خدمات التطبيق
│
├── Features/                # ميزات النظام
│   │
│   ├── SettingsParameters/  # ميزات الإعدادات والمعلمات
│   │   │
│   │   ├── Sequences/       # ميزة التسلسلات الرقمية
│   │   │   ├── Commands/    # أوامر
│   │   │   │   ├── CreateSequence/
│   │   │   │   ├── UpdateSequence/
│   │   │   │   ├── DeleteSequence/
│   │   │   │   └── ...
│   │   │   │
│   │   │   ├── Queries/     # استعلامات
│   │   │   │   ├── ListSequences/
│   │   │   │   ├── GetSequenceById/
│   │   │   │   └── ...
│   │   │   │
│   │   │   └── Models/      # نماذج 
│   │   │
│   │   └── [ميزات أخرى]/
│   │
│   └── [مجالات أخرى]/
│
└── Abstractions/            # تجريدات أساسية
```

### 3. مشروع البنية التحتية (Infrastructure Project)

**المسار:** `ERP_Pro.Infrastructure`

**الوصف:** يحتوي على تنفيذات البنية التحتية والتفاصيل التقنية:
- الوصول إلى قاعدة البيانات (Database Access)
- تنفيذات الخدمات (Service Implementations)
- إدارة الملفات والتخزين (File/Storage Handling)
- معالجة البريد الإلكتروني (Email Processing)
- المصادقة والتفويض (Authentication & Authorization)
- تكامل النظام الخارجي (External System Integration)

**البنية الداخلية:**
```
ERP_Pro.Infrastructure/
│
├── Persistence/                # الوصول إلى البيانات
│   ├── ApplicationDbContext.cs # سياق قاعدة البيانات
│   ├── Configurations/         # تكوينات الكيانات
│   ├── Migrations/             # ترحيلات قاعدة البيانات
│   └── Repositories/           # تنفيذات المستودعات
│
├── Services/                   # تنفيذات الخدمات
│   ├── BranchService.cs        # خدمة الفروع
│   ├── DateTimeService.cs      # خدمة التاريخ والوقت
│   ├── FileService.cs          # خدمة الملفات
│   ├── EmailService.cs         # خدمة البريد الإلكتروني
│   └── ...
│
├── Identity/                   # المصادقة والتفويض
│   ├── IdentityService.cs      # خدمة الهوية
│   ├── JwtService.cs           # خدمة JWT
│   └── ...
│
├── Integration/                # تكامل النظم الخارجية
│   ├── Payment/                # خدمات الدفع
│   ├── Notification/           # خدمات الإشعارات
│   └── ...
│
└── DependencyInjection.cs      # تسجيل خدمات البنية التحتية
```

### 4. مشروع واجهة برمجة التطبيقات (API Project)

**المسار:** `ERP_Pro.Api`

**الوصف:** يحتوي على وحدات التحكم وتكوين واجهة برمجة التطبيقات:
- وحدات التحكم (Controllers)
- مرشحات (Filters)
- وسطاء (Middleware)
- تكوين المشروع (Configuration)
- تكامل Swagger/OpenAPI

**البنية الداخلية:**
```
ERP_Pro.Api/
│
├── Controllers/               # وحدات التحكم مقسمة حسب المجالات
│   ├── V1/                    # الإصدار الأول
│   │   ├── SettingsController.cs
│   │   ├── SequencesController.cs
│   │   └── ...
│   │
│   └── V2/                    # الإصدار الثاني (إن وجد)
│
├── Filters/                   # مرشحات API
│   ├── ApiExceptionFilter.cs  # معالجة الاستثناءات
│   └── ...
│
├── Middleware/                # وسطاء خاصة
│
├── Models/                    # نماذج API الخاصة
│   └── Responses/             # هياكل الاستجابة
│
├── Program.cs                 # نقطة الدخول للتطبيق
├── Startup.cs                 # تكوين التطبيق
└── appsettings.json           # إعدادات التطبيق
```

### 5. مشروع المشترك (Shared Project)

**المسار:** `ERP_Pro.Shared`

**الوصف:** يحتوي على المكونات المشتركة بين جميع المشاريع:
- التعدادات (Enums)
- الثوابت (Constants)
- المساعدات (Helpers)
- الامتدادات (Extensions)

**البنية الداخلية:**
```
ERP_Pro.Shared/
│
├── Constants/               # ثوابت النظام
│
├── Enums/                   # تعدادات النظام
│   ├── Domain/              # تعدادات النطاق
│   └── Application/         # تعدادات التطبيق
│
├── Extensions/              # طرق الامتداد
│
└── Helpers/                 # أدوات مساعدة
```

### 6. مشاريع الاختبار (Test Projects)

**المسار:** 
- `ERP_Pro.Domain.Tests`
- `ERP_Pro.Application.Tests`
- `ERP_Pro.Infrastructure.Tests`
- `ERP_Pro.Api.Tests`

**الوصف:** مشاريع لاختبار المكونات المختلفة من النظام:
- اختبارات الوحدة (Unit Tests)
- اختبارات التكامل (Integration Tests)
- اختبارات النظام (System Tests)

## مخططات النظام

**المسار:** `مخططات النظام/`

**الوصف:** مجلد يحتوي على توثيق المشروع ومخططاته:
- مخططات النطاق (Domain Diagrams)
- مخططات التطبيق (Application Diagrams)
- مخططات البنية التحتية (Infrastructure Diagrams)
- قواعد المشروع (Project Rules)
- هيكل المشروع (Project Structure)

## تدفق البيانات العام في النظام

1. يقوم العميل بإرسال طلب HTTP إلى API
2. API يحول الطلب إلى أمر أو استعلام
3. يتم إرسال الأمر/الاستعلام إلى المعالج المناسب في طبقة التطبيق
4. يقوم المعالج بالتحقق من صحة المدخلات
5. يقوم المعالج بمعالجة الطلب باستخدام كيانات النطاق والخدمات
6. يتم تخزين أو استرجاع البيانات من خلال طبقة البنية التحتية
7. يتم إعادة النتيجة إلى العميل

## قواعد التنفيذ

1. الاعتماد دائمًا على الواجهات وليس التنفيذات (Depend on abstractions, not concretions)
2. طبقة النطاق لا تعتمد على أي طبقة أخرى
3. طبقة التطبيق تعتمد فقط على طبقة النطاق
4. طبقة البنية التحتية تعتمد على طبقة النطاق وطبقة التطبيق
5. طبقة API تعتمد على جميع الطبقات

هذا الهيكل يساعد في تحقيق:
- فصل واضح للمسؤوليات (Separation of Concerns)
- سهولة الاختبار (Testability)
- قابلية الصيانة (Maintainability)
- قابلية التوسع (Scalability)
- مرونة في استبدال المكونات (Flexibility) 