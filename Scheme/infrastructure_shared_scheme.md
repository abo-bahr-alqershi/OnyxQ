# ERP_Pro.Infrastructure.Shared - مخطط طبقة البنية التحتية المشتركة

## الوصف العام
طبقة البنية التحتية المشتركة توفر مكونات البنية التحتية المشتركة التي يمكن استخدامها في أجزاء مختلفة من النظام، مثل الخدمات المساعدة، وتكاملات الطرف الثالث، والأدوات المشتركة.

## هيكل المجلدات

### Services - الخدمات
- **Logging/** - التسجيل
  - `LoggingService.cs` - خدمة التسجيل
  - `AuditService.cs` - خدمة التدقيق
- **Notification/** - الإشعارات
  - `NotificationService.cs` - خدمة الإشعارات
  - `PushNotificationService.cs` - خدمة إشعارات الدفع
- **BackgroundJobs/** - المهام الخلفية
  - `BackgroundJobService.cs` - خدمة المهام الخلفية
  - `JobScheduler.cs` - مجدول المهام

### DTOs - كائنات نقل البيانات
- **Common/** - كائنات نقل البيانات المشتركة
  - `PaginatedResult.cs` - نتيجة مقسمة إلى صفحات
  - `ApiResponse.cs` - استجابة API
- **Requests/** - طلبات
  - طلبات مشتركة مستخدمة في النظام
- **Responses/** - استجابات
  - استجابات مشتركة مستخدمة في النظام

### Validation - التحقق من الصحة
- **Rules/** - قواعد التحقق
  - قواعد التحقق من الصحة المشتركة
- **Helpers/** - مساعدات التحقق
  - مساعدات للتحقق من الصحة

### Integration - التكامل
- **Api/** - واجهات API
  - تكاملات مع خدمات API الخارجية
- **ThirdParty/** - الطرف الثالث
  - تكاملات مع خدمات الطرف الثالث

### Middlewares - الوسائط
- `ExceptionMiddleware.cs` - وسيط الاستثناءات
- `RequestResponseLoggingMiddleware.cs` - وسيط تسجيل الطلب والاستجابة
- `PerformanceMiddleware.cs` - وسيط الأداء

### Utilities - الأدوات المساعدة
- `StringUtils.cs` - أدوات السلاسل النصية
- `DateTimeUtils.cs` - أدوات التاريخ والوقت
- `SecurityUtils.cs` - أدوات الأمان
- `FormatUtils.cs` - أدوات التنسيق

### ValueObjects - كائنات القيمة
- كائنات القيمة المشتركة المستخدمة في البنية التحتية

### Settings - الإعدادات
- `AppSettings.cs` - إعدادات التطبيق
- `EmailSettings.cs` - إعدادات البريد الإلكتروني
- `JwtSettings.cs` - إعدادات JWT
- `StorageSettings.cs` - إعدادات التخزين

### Constants - الثوابت
- `ApiConstants.cs` - ثوابت API
- `SecurityConstants.cs` - ثوابت الأمان
- `SystemConstants.cs` - ثوابت النظام

### Extensions - الامتدادات
- `StringExtensions.cs` - امتدادات السلاسل النصية
- `DateTimeExtensions.cs` - امتدادات التاريخ والوقت
- `EnumExtensions.cs` - امتدادات التعدادات

### Helpers - المساعدات
- `EncryptionHelper.cs` - مساعد التشفير
- `PdfHelper.cs` - مساعد PDF
- `ExcelHelper.cs` - مساعد Excel
- `JsonHelper.cs` - مساعد JSON

### Localization - التعريب
- `LocalizationService.cs` - خدمة التعريب
- `LanguageManager.cs` - مدير اللغة
- إعدادات ومصادر التعريب

### Models - النماذج
- **Caching/** - نماذج التخزين المؤقت
- **FileStorage/** - نماذج تخزين الملفات
- **Results/** - نماذج النتائج
- نماذج البنية التحتية المشتركة الأخرى

### DependencyInjection - حقن التبعيات
- `SharedInfrastructureServiceRegistration.cs` - تسجيل خدمات البنية التحتية المشتركة

## الخدمات المشتركة الرئيسية

1. **خدمات التسجيل**:
   - تسجيل أنشطة النظام
   - تسجيل الأخطاء والاستثناءات
   - تسجيل أداء النظام

2. **خدمات الإشعارات**:
   - إرسال إشعارات متعددة القنوات
   - إدارة تفضيلات الإشعارات
   - جدولة الإشعارات

3. **المهام الخلفية**:
   - جدولة وتنفيذ المهام الخلفية
   - إدارة المهام المتكررة
   - معالجة العمليات طويلة المدى
