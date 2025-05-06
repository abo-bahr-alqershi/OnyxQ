# ERP_Pro.Application - مخطط طبقة التطبيق

## الوصف العام
طبقة التطبيق تحتوي على منطق التطبيق والمعالجات، وهي المسؤولة عن تنسيق الأنشطة بين طبقات النظام المختلفة وتنفيذ حالات الاستخدام.

## هيكل المجلدات

### Common - المكونات المشتركة
- **Behaviors/** - السلوكيات
  - `ValidationBehaviour.cs` - سلوك التحقق من الصحة
  - `LoggingBehaviour.cs` - سلوك التسجيل
  - `TransactionBehaviour.cs` - سلوك المعاملات
- **Configurations/** - الإعدادات
  - `MappingProfile.cs` - ملف التعيين لـ AutoMapper
  - `ValidationConfig.cs` - إعدادات التحقق من الصحة
- **Exceptions/** - الاستثناءات
  - `NotFoundException.cs` - استثناء العنصر غير موجود
  - `ValidationException.cs` - استثناء التحقق من الصحة
  - `BadRequestException.cs` - استثناء طلب خاطئ
- **Abstractions/** - التجريدات
  - واجهات التجريد للخدمات المختلفة
- **DependencyInjection/** - حقن التبعيات
  - `ApplicationServicesRegistration.cs` - تسجيل خدمات طبقة التطبيق
- **Helper/** - المساعدات
  - أدوات مساعدة متنوعة
- **Enums/** - التعدادات
  - تعدادات مستخدمة في طبقة التطبيق
- **ContextValidators/** - مدققي السياق
  - مدققي السياق لمختلف الكيانات

### Features - الميزات
كل مجلد يمثل ميزة أو وحدة وظيفية في النظام ويتضمن:

#### FinanceAccounting - المالية والمحاسبة
- **Currencies/** - العملات
  - **Commands/** - الأوامر
    - `CreateCurrency/` - إنشاء عملة جديدة
    - `UpdateCurrency/` - تحديث بيانات عملة
    - `DeleteCurrency/` - حذف عملة
    - `SetBaseCurrency/` - تعيين العملة الأساسية
    - `ChangeCurrencyStatus/` - تغيير حالة العملة (تفعيل أو تعطيل)
    - `UpdateCurrencyRounding/` - تحديث قواعد تقريب العملة
    - `CreateExchangeRate/` - إضافة سعر صرف جديد
    - `UpdateExchangeRate/` - تحديث سعر صرف
    - `ImportExchangeRates/` - استيراد أسعار صرف
    - `CreateCurrencyAccount/` - إنشاء حساب مرتبط بالعملة
    - `UpdateCurrencyAccount/` - تحديث حساب مرتبط بالعملة
    - `CreateCurrencyRiskLimit/` - إنشاء حد مخاطر للعملة
    - `UpdateCurrencyRiskLimit/` - تحديث حد مخاطر للعملة
  - **Queries/** - الاستعلامات
    - `GetCurrencyById/` - جلب عملة بالمعرف
    - `GetCurrencyByCode/` - جلب عملة بالرمز
    - `ListCurrencies/` - قائمة العملات المعرفة في النظام
    - `GetBaseCurrency/` - جلب العملة الأساسية
    - `GetCurrentExchangeRate/` - جلب سعر الصرف الحالي
    - `GetExchangeRateHistory/` - جلب تاريخ أسعار الصرف
    - `ConvertAmount/` - تحويل مبلغ من عملة إلى أخرى
    - `GetCurrencyAccounts/` - جلب الحسابات المرتبطة بعملة
    - `GetCurrencyRoundingRules/` - جلب قواعد تقريب العملة
    - `GetCurrencyRiskLimits/` - جلب حدود مخاطر العملة
  - **ViewModels/** - نماذج العرض
    - `CurrencyDto.cs` - نموذج بيانات العملة
    - `CurrencyListItemDto.cs` - نموذج عنصر قائمة العملات
    - `CurrencyDetailsDto.cs` - نموذج تفاصيل العملة
    - `ExchangeRateDto.cs` - نموذج سعر الصرف
    - `ExchangeRateHistoryDto.cs` - نموذج تاريخ سعر الصرف
    - `CurrencyAccountDto.cs` - نموذج حساب العملة
    - `CurrencyRoundingRuleDto.cs` - نموذج قاعدة تقريب العملة
    - `CurrencyRiskLimitDto.cs` - نموذج حد مخاطر العملة
    - `CurrencyConversionDto.cs` - نموذج تحويل العملات
  - **Validators/** - مدققات
    - `CreateCurrencyValidator.cs` - مدقق إنشاء عملة
    - `UpdateCurrencyValidator.cs` - مدقق تحديث عملة
    - `SetBaseCurrencyValidator.cs` - مدقق تعيين العملة الأساسية
    - `CreateExchangeRateValidator.cs` - مدقق إنشاء سعر صرف
    - `UpdateExchangeRateValidator.cs` - مدقق تحديث سعر صرف
    - `CreateCurrencyRiskLimitValidator.cs` - مدقق إنشاء حد مخاطر
  - **EventHandlers/** - معالجات الأحداث
    - `CurrencyCreatedEventHandler.cs` - معالج حدث إنشاء عملة
    - `CurrencyUpdatedEventHandler.cs` - معالج حدث تحديث عملة
    - `CurrencyStatusChangedEventHandler.cs` - معالج حدث تغيير حالة عملة
    - `CurrencySetAsBaseEventHandler.cs` - معالج حدث تعيين العملة كعملة أساسية
    - `ExchangeRateAddedEventHandler.cs` - معالج حدث إضافة سعر صرف
    - `CurrencyRiskLimitExceededEventHandler.cs` - معالج حدث تجاوز حد مخاطر
- **Accounts/** - الحسابات
  - **Commands/** - الأوامر
    - `CreateAccount/` - إنشاء حساب
    - `UpdateAccount/` - تحديث حساب
    - `DeleteAccount/` - حذف حساب
  - **Queries/** - الاستعلامات
    - `GetAccounts/` - جلب الحسابات
    - `GetAccount/` - جلب حساب محدد
  - **ViewModels/** - نماذج العرض
    - `AccountDto.cs` - نموذج بيانات الحساب
  - **Validators/** - مدققات
    - `CreateAccountValidator.cs` - مدقق إنشاء حساب

#### SettingsParameters - الإعدادات والمعاملات
- **CompanyInfo/** - معلومات الشركة
  - **Commands/** - الأوامر
    - `CreateCompanyInfo/` - إنشاء معلومات الشركة
    - `UpdateCompanyInfo/` - تحديث معلومات الشركة
  - **Queries/** - الاستعلامات
    - `GetCompanyInfo/` - جلب معلومات الشركة
  - **ViewModels/** - نماذج العرض
    - `CompanyInfoDto.cs` - نموذج بيانات الشركة
  - **Validators/** - مدققات
    - `CreateCompanyInfoValidator.cs` - مدقق إنشاء معلومات الشركة
- **Branches/** - الفروع
  - **Commands/** - الأوامر
    - `CreateBranch/` - إنشاء فرع جديد
    - `UpdateBranch/` - تحديث بيانات فرع
    - `DeleteBranch/` - حذف فرع
    - `ChangeBranchStatus/` - تغيير حالة فرع
    - `LinkWarehouseToBranch/` - ربط مستودع بفرع
    - `LinkUserToBranch/` - ربط مستخدم بفرع
    - `UpdateBranchSequence/` - تحديث التسلسل الرقمي للفرع
    - `MergeBranches/` - دمج الفروع
  - **Queries/** - الاستعلامات
    - `GetBranchById/` - جلب فرع بالمعرف
    - `GetBranchByCode/` - جلب فرع بالرمز
    - `ListBranches/` - قائمة الفروع
    - `GetBranchHierarchy/` - الهيكل الهرمي للفروع
    - `GetBranchWarehouses/` - مستودعات الفرع
    - `GetBranchUsers/` - مستخدمي الفرع
    - `GetBranchDocuments/` - مستندات الفرع
  - **ViewModels/** - نماذج العرض
    - `BranchDto.cs` - نموذج بيانات الفرع
    - `BranchListItemDto.cs` - نموذج عنصر قائمة الفروع
    - `BranchDetailsDto.cs` - نموذج تفاصيل الفرع
    - `BranchWarehouseDto.cs` - نموذج مستودع الفرع
    - `BranchUserDto.cs` - نموذج مستخدم الفرع
    - `BranchDocumentDto.cs` - نموذج مستند الفرع
    - `BranchHierarchyItemDto.cs` - نموذج عنصر الهيكل الهرمي للفروع
  - **Validators/** - مدققات
    - `CreateBranchValidator.cs` - مدقق إنشاء فرع
    - `UpdateBranchValidator.cs` - مدقق تحديث فرع
    - `ChangeBranchStatusValidator.cs` - مدقق تغيير حالة فرع
- **FiscalYears/** - السنوات المالية
  - **Commands/** - الأوامر
    - `CreateFiscalYear/` - إنشاء سنة مالية جديدة
    - `UpdateFiscalYear/` - تحديث بيانات سنة مالية
    - `DeleteFiscalYear/` - حذف سنة مالية
    - `ChangeFiscalYearStatus/` - تغيير حالة سنة مالية
    - `SetDefaultFiscalYear/` - تعيين السنة المالية الافتراضية
    - `CopyFiscalYear/` - نسخ إعدادات سنة مالية
    - `CloseFiscalYear/` - إقفال سنة مالية
    - `ReopenFiscalYear/` - إعادة فتح سنة مالية
    - `CarryOverBalances/` - ترحيل أرصدة السنة المالية
  - **Queries/** - الاستعلامات
    - `GetFiscalYearById/` - جلب سنة مالية بالمعرف
    - `GetFiscalYearByCode/` - جلب سنة مالية بالرمز
    - `ListFiscalYears/` - قائمة السنوات المالية
    - `GetDefaultFiscalYear/` - جلب السنة المالية الافتراضية
    - `GetFiscalYearStatistics/` - إحصائيات السنة المالية
    - `GetFiscalYearSettings/` - إعدادات السنة المالية
  - **ViewModels/** - نماذج العرض
    - `FiscalYearDto.cs` - نموذج بيانات السنة المالية
    - `FiscalYearListItemDto.cs` - نموذج عنصر قائمة السنوات المالية
    - `FiscalYearDetailsDto.cs` - نموذج تفاصيل السنة المالية
    - `FiscalYearSettingDto.cs` - نموذج إعدادات السنة المالية
    - `FiscalYearStatisticsDto.cs` - نموذج إحصائيات السنة المالية
    - `CarryOverSettingsDto.cs` - نموذج إعدادات ترحيل الأرصدة
  - **Validators/** - مدققات
    - `CreateFiscalYearValidator.cs` - مدقق إنشاء سنة مالية
    - `UpdateFiscalYearValidator.cs` - مدقق تحديث سنة مالية
    - `ChangeFiscalYearStatusValidator.cs` - مدقق تغيير حالة سنة مالية
    - `DeleteFiscalYearValidator.cs` - مدقق حذف سنة مالية
    - `CloseFiscalYearValidator.cs` - مدقق إقفال سنة مالية
    - `CarryOverBalancesValidator.cs` - مدقق ترحيل أرصدة
  - **EventHandlers/** - معالجات الأحداث
    - `FiscalYearCreatedEventHandler.cs` - معالج حدث إنشاء سنة مالية
    - `FiscalYearUpdatedEventHandler.cs` - معالج حدث تحديث سنة مالية
    - `FiscalYearStatusChangedEventHandler.cs` - معالج حدث تغيير حالة سنة مالية
    - `FiscalYearClosedEventHandler.cs` - معالج حدث إقفال سنة مالية
- **FiscalPeriods/** - الفترات المحاسبية
  - **Commands/** - الأوامر
    - `CreatePeriodsAutomatically/` - إنشاء فترات محاسبية تلقائياً (للإنشاء التلقائي بناءً على نوع الفترة: شهرية، ربع سنوية، نصف سنوية)
    - `CreatePeriodManually/` - إنشاء فترة محاسبية يدوياً
    - `UpdatePeriod/` - تحديث بيانات فترة محاسبية
    - `DeletePeriod/` - حذف فترة محاسبية
    - `ChangePeriodStatus/` - تغيير حالة فترة محاسبية
    - `LockPeriod/` - تأمين فترة محاسبية (يمكن تحديد نوع التأمين: عادي، مؤقت، جزئي، كامل، إقفال نهائي)
    - `UnlockPeriod/` - إلغاء تأمين فترة محاسبية
    - `CreatePeriodAdjustment/` - إنشاء تسوية للفترة المحاسبية
  - **Queries/** - الاستعلامات
    - `GetFiscalPeriodById/` - جلب فترة محاسبية بالمعرف (مع تفاصيل التأمينات والتسويات)
    - `ListFiscalPeriods/` - قائمة الفترات المحاسبية (مع دعم الفلترة والترتيب والتصفح)
    - `GetCurrentFiscalPeriod/` - جلب الفترة المحاسبية الحالية (الفترة التي تضم التاريخ الحالي)
    - `GetPeriodByDate/` - جلب فترة محاسبية بالتاريخ
    - `CheckPeriodStatusForDate/` - التحقق من حالة الفترة لتاريخ محدد (يتحقق من وجود الفترة وحالتها وإذا كانت مؤمنة)
    - `GetFiscalPeriodAdjustments/` - جلب تسويات فترة محاسبية
  - **ViewModels/** - نماذج العرض
    - `FiscalPeriodDto.cs` - نموذج بيانات الفترة المحاسبية (للعرض والتعديل)
    - `FiscalPeriodListItemDto.cs` - نموذج عنصر قائمة الفترات المحاسبية (نموذج مبسط لعرض القوائم)
    - `FiscalPeriodDetailsDto.cs` - نموذج تفاصيل الفترة المحاسبية (مع قوائم التأمينات والتسويات المرتبطة)
    - `FiscalPeriodLockDto.cs` - نموذج تأمين الفترة المحاسبية (مضمن في نموذج التفاصيل)
    - `FiscalPeriodAdjustmentDto.cs` - نموذج تسوية الفترة المحاسبية (مضمن في نموذج التفاصيل)
    - `PeriodStatusDto.cs` - نموذج حالة الفترة المحاسبية (لعرض حالة الفترة لتاريخ محدد)
  - **Validators/** - مدققات
    - `CreatePeriodManuallyValidator.cs` - مدقق إنشاء فترة محاسبية يدوياً
    - `UpdatePeriodValidator.cs` - مدقق تحديث فترة محاسبية
    - `ChangePeriodStatusValidator.cs` - مدقق تغيير حالة فترة محاسبية
    - `DeletePeriodValidator.cs` - مدقق حذف فترة محاسبية
    - `CreatePeriodsAutomaticallyValidator.cs` - مدقق إنشاء فترات تلقائياً
  - **EventHandlers/** - معالجات الأحداث
    - `FiscalPeriodCreatedEventHandler.cs` - معالج حدث إنشاء فترة محاسبية
    - `FiscalPeriodUpdatedEventHandler.cs` - معالج حدث تحديث فترة محاسبية
    - `FiscalPeriodStatusChangedEventHandler.cs` - معالج حدث تغيير حالة فترة محاسبية

#### GeneralLedger - دفتر الأستاذ العام
- **JournalEntries/** - القيود اليومية
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات

#### HumanResources - الموارد البشرية
- **Employees/** - الموظفين
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات

#### InventoryWarehousing - المخزون والمستودعات
- **Items/** - الأصناف
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات
- **Warehouses/** - المستودعات
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات

#### SalesCustomers - المبيعات والعملاء
- **Customers/** - العملاء
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات
- **SalesInvoices/** - فواتير المبيعات
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات

#### PurchasingVendors - المشتريات والموردين
- **Vendors/** - الموردين
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات
- **PurchaseInvoices/** - فواتير المشتريات
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات

#### UsersPermissions - المستخدمين والصلاحيات
- **Users/** - المستخدمين
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات
- **Roles/** - الأدوار
  - **Commands/** - الأوامر
  - **Queries/** - الاستعلامات
  - **ViewModels/** - نماذج العرض
  - **Validators/** - مدققات

## تدفق العمليات الرئيسية

1. **معالجة الطلبات**:
   - استقبال طلب من طبقة العرض
   - تنفيذ التحقق من الصحة من خلال `ValidationBehaviour`
   - معالجة الطلب باستخدام منطق التطبيق المناسب
   - مراسلة طبقة النطاق للحصول على البيانات أو تنفيذ العمليات
   - إعادة النتيجة إلى طبقة العرض

2. **استخدام CQRS**:
   - فصل عمليات القراءة (الاستعلامات) عن عمليات الكتابة (الأوامر)
   - استخدام MediatR لتوجيه الطلبات إلى المعالجات المناسبة
   - تنفيذ الأوامر التي تغير الحالة
   - تنفيذ الاستعلامات التي تقرأ الحالة دون تغييرها

## إعدادات النظام (SettingsParameters)

### الاستعلامات (Queries)

#### ListSequencesQuery
استعلام لعرض قائمة التسلسلات الرقمية:
- فلتر المجموعة (GroupFilter)
- فلتر الحالة (StatusFilter)
- فلتر البحث (SearchTerm)
- رقم الصفحة (PageNumber)
- حجم الصفحة (PageSize)
- ترتيب البيانات (OrderBy)

**منفذ الاستعلام ListSequencesQueryHandler**

**الاستجابة PaginatedList<SequenceListItemDto>**

#### GetSequenceByIdQuery
استعلام للحصول على تفاصيل تسلسل بواسطة المعرف:
- المعرف (Id)

**منفذ الاستعلام GetSequenceByIdQueryHandler**

**الاستجابة SequenceDetailsDto**

#### GetSequenceByCodeQuery
استعلام للحصول على تفاصيل تسلسل بواسطة الرمز:
- الرمز (Code)

**منفذ الاستعلام GetSequenceByCodeQueryHandler**

**الاستجابة SequenceDetailsDto**

#### GetNextNumberQuery
استعلام للحصول على الرقم التالي في التسلسل:
- رمز التسلسل (SequenceCode) أو معرف التسلسل (SequenceId)
- رمز الفرع (BranchCode) - اختياري
- رمز الإدارة (DepartmentCode) - اختياري
- رمز القسم (SectionCode) - اختياري
- رمز المستخدم (UserCode) - اختياري
- رمز السنة المالية (FiscalYearCode) - اختياري

**منفذ الاستعلام GetNextNumberQueryHandler**

**الاستجابة NextNumberDto**

#### ValidateNumberQuery
استعلام للتحقق من صحة رقم تسلسلي:
- رمز التسلسل (SequenceCode) أو معرف التسلسل (SequenceId)
- الرقم المنسق (FormattedNumber)

**منفذ الاستعلام ValidateNumberQueryHandler**

**الاستجابة NumberValidationResultDto**

#### GetSequenceNumbersHistoryQuery
استعلام للحصول على سجل الأرقام المستخدمة للتسلسل:
- معرف التسلسل (SequenceId)
- نوع السجل (RecordType) - مستخدم أو ملغى
- تاريخ البدء (FromDate) - اختياري
- تاريخ الانتهاء (ToDate) - اختياري
- معرف المستخدم (UserId) - اختياري
- معرف الفرع (BranchId) - اختياري
- رقم الصفحة (PageNumber)
- حجم الصفحة (PageSize)

**منفذ الاستعلام GetSequenceNumbersHistoryQueryHandler**

**الاستجابة PaginatedList<SequenceNumberHistoryDto>**

#### GetSequenceAuditLogQuery
استعلام للحصول على سجل تدقيق التسلسل:
- معرف التسلسل (SequenceId)
- نوع الحدث (AuditType) - اختياري
- تاريخ البدء (FromDate) - اختياري
- تاريخ الانتهاء (ToDate) - اختياري
- معرف المستخدم (UserId) - اختياري
- رقم الصفحة (PageNumber)
- حجم الصفحة (PageSize)

**منفذ الاستعلام GetSequenceAuditLogQueryHandler**

**الاستجابة PaginatedList<SequenceAuditLogDto>**

#### GetNumberGapsQuery
استعلام للحصول على فجوات الأرقام في التسلسل:
- معرف التسلسل (SequenceId)
- حالة المعالجة (ResolutionStatus) - اختياري
- تاريخ البدء (FromDate) - اختياري
- تاريخ الانتهاء (ToDate) - اختياري
- رقم الصفحة (PageNumber)
- حجم الصفحة (PageSize)

**منفذ الاستعلام GetNumberGapsQueryHandler**

**الاستجابة PaginatedList<NumberGapDto>**

### الأوامر (Commands)

#### CreateSequenceCommand
أمر لإنشاء تسلسل جديد:
- الرمز (Code)
- الاسم بالعربية (NameAr)
- الاسم بالإنجليزية (NameEn)
- نوع المستند (DocumentType)
- المجموعة (Group)
- الوصف (Description) - اختياري
- الشاشات المستخدمة (UsedInScreens) - اختياري
- البادئة (Prefix) - اختياري
- اللاحقة (Suffix) - اختياري
- تكوين رقم التسلسل (NumberConfiguration)
- إعدادات نطاق الترقيم (RangeSettings)
- إعدادات الصلاحيات (PermissionSettings) - اختياري
- ملاحظات (Notes) - اختياري

**منفذ الأمر CreateSequenceCommandHandler**

**الاستجابة Guid (معرف التسلسل الجديد)**

#### UpdateSequenceCommand
أمر لتحديث تسلسل موجود:
- المعرف (Id)
- الاسم بالعربية (NameAr)
- الاسم بالإنجليزية (NameEn)
- نوع المستند (DocumentType)
- المجموعة (Group)
- الوصف (Description) - اختياري
- الشاشات المستخدمة (UsedInScreens) - اختياري
- البادئة (Prefix) - اختياري
- اللاحقة (Suffix) - اختياري
- تكوين رقم التسلسل (NumberConfiguration)
- إعدادات نطاق الترقيم (RangeSettings)
- إعدادات الصلاحيات (PermissionSettings) - اختياري
- ملاحظات (Notes) - اختياري

**منفذ الأمر UpdateSequenceCommandHandler**

**الاستجابة bool (نجاح أو فشل العملية)**

#### DeleteSequenceCommand
أمر لحذف تسلسل:
- المعرف (Id)

**منفذ الأمر DeleteSequenceCommandHandler**

**الاستجابة bool (نجاح أو فشل العملية)**

#### ChangeSequenceStatusCommand
أمر لتغيير حالة تسلسل:
- المعرف (Id)
- الحالة الجديدة (NewStatus)
- سبب التغيير (Reason) - اختياري

**منفذ الأمر ChangeSequenceStatusCommandHandler**

**الاستجابة bool (نجاح أو فشل العملية)**

#### ResetSequenceCounterCommand
أمر لإعادة تعيين عداد التسلسل:
- المعرف (Id)
- القيمة الجديدة (NewValue)
- سبب إعادة التعيين (Reason)

**منفذ الأمر ResetSequenceCounterCommandHandler**

**الاستجابة bool (نجاح أو فشل العملية)**

#### ReserveNumberRangeCommand
أمر لحجز نطاق من الأرقام:
- معرف التسلسل (SequenceId)
- بداية النطاق (RangeStart)
- نهاية النطاق (RangeEnd)
- سبب الحجز (Reason)
- معرف الفرع (BranchId) - اختياري
- تاريخ انتهاء الصلاحية (ExpiryDate) - اختياري

**منفذ الأمر ReserveNumberRangeCommandHandler**

**الاستجابة Guid (معرف الحجز الجديد)**

#### ReleaseReservedNumberCommand
أمر لإلغاء حجز رقم محجوز:
- معرف التسلسل (SequenceId)
- معرف الحجز (AllocationId) أو الرقم (Number)
- سبب الإلغاء (Reason)

**منفذ الأمر ReleaseReservedNumberCommandHandler**

**الاستجابة bool (نجاح أو فشل العملية)**

#### CancelNumberCommand
أمر لإلغاء رقم مستخدم:
- معرف التسلسل (SequenceId)
- الرقم المنسق (FormattedNumber)
- سبب الإلغاء (Reason)

**منفذ الأمر CancelNumberCommandHandler**

**الاستجابة bool (نجاح أو فشل العملية)**

### نماذج الكائنات (DTOs)

#### SequenceListItemDto
نموذج لعرض عنصر في قائمة التسلسلات:
- المعرف (Id)
- الرمز (Code)
- الاسم بالعربية (NameAr)
- الاسم بالإنجليزية (NameEn)
- المجموعة (Group)
- نوع المستند (DocumentType)
- الحالة (Status)
- النطاق الحالي (CurrentRange)
- الرقم الحالي (CurrentNumber)
- نسبة استخدام النطاق (RangeUtilizationPercentage)

#### SequenceDetailsDto
نموذج لعرض تفاصيل التسلسل:
- المعرف (Id)
- الرمز (Code)
- الاسم بالعربية (NameAr)
- الاسم بالإنجليزية (NameEn)
- نوع المستند (DocumentType)
- المجموعة (Group)
- الوصف (Description)
- الحالة (Status)
- الشاشات المستخدمة (UsedInScreens)
- البادئة (Prefix)
- اللاحقة (Suffix)
- تكوين رقم التسلسل (NumberConfiguration)
- إعدادات نطاق الترقيم (RangeSettings)
- إعدادات الصلاحيات (PermissionSettings)
- ملاحظات (Notes)
- إحصائيات استخدام التسلسل (UsageStatistics)

#### NextNumberDto
نموذج للرقم التالي في التسلسل:
- الرقم المنسق (FormattedNumber)
- الرقم الخام (RawNumber)
- تسلسل الإنشاء (GenerationSequence)
- تاريخ الإنشاء (GenerationDate)

#### NumberValidationResultDto
نموذج لنتيجة التحقق من صحة الرقم:
- صالح (IsValid)
- رسالة التحقق (ValidationMessage)
- حالة الرقم (NumberStatus) - مستخدم، ملغى، غير موجود، إلخ.
- بيانات الرقم (NumberDetails) - في حال وجود الرقم

#### SequenceNumberHistoryDto
نموذج لعرض سجل استخدام الأرقام:
- المعرف (Id)
- الرقم المنسق (FormattedNumber)
- الرقم الخام (RawNumber)
- نوع السجل (RecordType) - مستخدم أو ملغى
- تاريخ الاستخدام/الإلغاء (Date)
- اسم المستخدم (UserName)
- اسم الفرع (BranchName)
- معرف المستند المرتبط (DocumentId)
- نوع المستند المرتبط (DocumentType)
- السبب (Reason) - للأرقام الملغاة

#### SequenceAuditLogDto
نموذج لعرض سجل تدقيق التسلسل:
- المعرف (Id)
- نوع الحدث (AuditType)
- تاريخ الحدث (EventDate)
- اسم المستخدم (UserName)
- اسم الفرع (BranchName)
- القيمة القديمة (OldValue)
- القيمة الجديدة (NewValue)
- الوصف (Description)

#### NumberGapDto
نموذج لعرض فجوة في التسلسل:
- المعرف (Id)
- بداية الفجوة (GapStart)
- نهاية الفجوة (GapEnd)
- حجم الفجوة (GapSize)
- سبب الفجوة (Reason)
- تاريخ الاكتشاف (DiscoveryDate)
- حالة المعالجة (ResolutionStatus)
- تاريخ المعالجة (ResolutionDate)
- اسم المستخدم المعالج (ResolvedByUserName)
- تفاصيل المعالجة (ResolutionDetails)
