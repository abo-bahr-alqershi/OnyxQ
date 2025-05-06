# ERP_Pro.Shared - مخطط الطبقة المشتركة

## الوصف العام
الطبقة المشتركة تحتوي على العناصر المشتركة التي يمكن استخدامها عبر جميع طبقات النظام، مثل DTOs والتعدادات والمساعدين والثوابت. تُستخدم هذه الطبقة لتجنب التكرار وتعزيز إعادة الاستخدام.

## هيكل المجلدات

### DTOs - كائنات نقل البيانات
- **Common/** - كائنات نقل البيانات المشتركة
  - `BaseDto.cs` - كائن نقل البيانات الأساسي
  - `PaginationQuery.cs` - استعلام التقسيم إلى صفحات
  - `SelectListItemDto.cs` - عنصر قائمة اختيار
- **Auth/** - المصادقة
  - `LoginRequest.cs` - طلب تسجيل الدخول
  - `RegisterRequest.cs` - طلب التسجيل
  - `TokenResponse.cs` - استجابة الرمز
- **Email/** - البريد الإلكتروني
  - `EmailMessage.cs` - رسالة بريد إلكتروني
  - `EmailAttachment.cs` - مرفق بريد إلكتروني

### Enums - التعدادات
- `FileType.cs` - نوع الملف
- `Status.cs` - الحالة
- `Priority.cs` - الأولوية
- `RecordState.cs` - حالة السجل
- التعدادات المشتركة الأخرى

### Constants - الثوابت
- `ApplicationConstants.cs` - ثوابت التطبيق
- `RegexConstants.cs` - ثوابت التعبيرات النمطية
- `DateTimeFormats.cs` - تنسيقات التاريخ والوقت
- `MessageTemplate.cs` - قوالب الرسائل

### Exceptions - الاستثناءات
- `AppException.cs` - استثناء التطبيق
- `NotFoundException.cs` - استثناء العنصر غير موجود
- `UnauthorizedException.cs` - استثناء غير مصرح به
- `BadRequestException.cs` - استثناء طلب خاطئ

### Events - الأحداث
- `ApplicationEvent.cs` - حدث التطبيق
- أحداث النظام المشتركة

### Settings - الإعدادات
- `AppSettings.cs` - إعدادات التطبيق
- `JwtSettings.cs` - إعدادات JWT
- `SmtpSettings.cs` - إعدادات SMTP
- `CacheSettings.cs` - إعدادات التخزين المؤقت

### Utilities - الأدوات المساعدة
- `StringUtilities.cs` - أدوات السلاسل النصية
- `DateTimeUtilities.cs` - أدوات التاريخ والوقت
- `SecurityUtilities.cs` - أدوات الأمان
- `ValidationUtilities.cs` - أدوات التحقق من الصحة

### Validation - التحقق من الصحة
- **Attributes/** - السمات
  - `RequiredIfAttribute.cs` - سمة مطلوب إذا
  - `MaxFileSizeAttribute.cs` - سمة الحد الأقصى لحجم الملف
- **Rules/** - القواعد
  - قواعد التحقق من الصحة المشتركة

### ValueObjects - كائنات القيمة
- `DateRange.cs` - نطاق التاريخ
- `Address.cs` - العنوان
- `Money.cs` - المال
- `PhoneNumber.cs` - رقم الهاتف
- كائنات القيمة المشتركة الأخرى

### Helpers - المساعدات
- `EnumHelper.cs` - مساعد التعدادات
- `FileHelper.cs` - مساعد الملفات
- `HashHelper.cs` - مساعد التجزئة
- `JsonHelper.cs` - مساعد JSON
- مساعدات أخرى

### Interfaces - الواجهات
- **Services/** - واجهات الخدمات
  - `IDateTimeService.cs` - واجهة خدمة التاريخ والوقت
  - `IFileService.cs` - واجهة خدمة الملفات
- **Common/** - واجهات مشتركة
  - واجهات مشتركة أخرى

### Localization - التعريب
- **Resources/** - الموارد
  - ملفات موارد التعريب
- واجهات وخدمات التعريب

### Extensions - الامتدادات
- `StringExtensions.cs` - امتدادات السلاسل النصية
- `DateTimeExtensions.cs` - امتدادات التاريخ والوقت
- `EnumerableExtensions.cs` - امتدادات المجموعات
- `ExpressionExtensions.cs` - امتدادات التعبيرات

### Resources - الموارد
- `ErrorMessages.cs` - رسائل الخطأ
- `SuccessMessages.cs` - رسائل النجاح
- موارد أخرى

## الاستخدامات الرئيسية

1. **كائنات نقل البيانات (DTOs)**:
   - نقل البيانات بين الطبقات
   - تبسيط نماذج النطاق للعرض
   - تحويل البيانات لتتناسب مع احتياجات واجهة المستخدم

2. **التعدادات والثوابت**:
   - تعريف القيم الثابتة المستخدمة في النظام
   - ضمان الاتساق في جميع أنحاء التطبيق

3. **الأدوات المساعدة**:
   - توفير وظائف مساعدة مشتركة
   - تبسيط المهام المتكررة

4. **التحقق من الصحة**:
   - تعريف قواعد التحقق من الصحة المشتركة
   - إعادة استخدام منطق التحقق من الصحة
