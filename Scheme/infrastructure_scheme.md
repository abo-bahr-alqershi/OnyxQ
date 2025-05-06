# ERP_Pro.Infrastructure - مخطط طبقة البنية التحتية

## الوصف العام
طبقة البنية التحتية توفر التنفيذ الفعلي للواجهات المحددة في طبقة النطاق والتطبيق، وتتضمن الوصول إلى قواعد البيانات، وخدمات الطرف الثالث، والمستودعات.

## هيكل المجلدات

### Data - البيانات
- **Context/** - سياق البيانات
  - `ApplicationDbContext.cs` - سياق قاعدة بيانات التطبيق
  - `ApplicationContextFactory.cs` - مصنع سياق التطبيق
  - `ConnectionManager.cs` - مدير الاتصال
- **Contexts/** - سياقات متعددة إذا لزم الأمر
  - سياقات خاصة لأجزاء مختلفة من النظام
- **Migrations/** - الترحيلات
  - ملفات ترحيل قاعدة البيانات
- **Repositories/** - المستودعات
  - `Repository.cs` - المستودع العام
  - `UnitOfWork.cs` - وحدة العمل
  - مستودعات خاصة بكل كيان
  - **FinanceAccounting/** - مستودعات المالية والمحاسبة
    - `CurrencyRepository.cs` - مستودع العملات (تنفيذ لواجهة ICurrencyRepository)
    - `ExchangeRateRepository.cs` - مستودع أسعار الصرف
    - `CurrencyAccountRepository.cs` - مستودع حسابات العملات
    - `AccountRepository.cs` - مستودع الحسابات المالية
    - `TransactionRepository.cs` - مستودع المعاملات المالية
    - `BankAccountRepository.cs` - مستودع الحسابات البنكية
  - **SettingsParameters/** - مستودعات الإعدادات والمعاملات
    - `CompanyInfoRepository.cs` - مستودع معلومات الشركة
    - `BranchRepository.cs` - مستودع الفروع
    - `BranchWarehouseRepository.cs` - مستودع مستودعات الفروع
    - `BranchDocumentRepository.cs` - مستودع مستندات الفروع
    - `FiscalYearRepository.cs` - مستودع السنوات المالية
    - `FiscalPeriodRepository.cs` - مستودع الفترات المحاسبية
    - `FiscalYearSettingRepository.cs` - مستودع إعدادات السنة المالية
    - `FiscalYearClosingRepository.cs` - مستودع إقفال السنة المالية
    - `FiscalPeriodLockRepository.cs` - مستودع تأمين الفترة المحاسبية
    - `FiscalPeriodAdjustmentRepository.cs` - مستودع تسويات الفترة المحاسبية
- **Seed/** - البذور
  - بيانات أولية لقاعدة البيانات
- **Common/** - عناصر مشتركة
  - أدوات مساعدة للتعامل مع البيانات

### DependencyInjection - حقن التبعيات
- `InfrastructureServiceRegistration.cs` - تسجيل خدمات البنية التحتية

### Identity - الهوية
- **Services/** - خدمات الهوية
  - `IdentityService.cs` - خدمة الهوية
  - `TokenService.cs` - خدمة الرموز
- **Models/** - نماذج الهوية
  - `ApplicationUser.cs` - نموذج المستخدم
  - `ApplicationRole.cs` - نموذج الدور

### Configurations - الإعدادات
- `EntityTypeConfiguration.cs` - تكوين نوع الكيان
- مجموعة من ملفات تكوين الكيانات
- **FinanceAccounting/** - تكوينات المالية والمحاسبة
  - `CurrencyConfiguration.cs` - تكوين العملة (تعريف الجدول والقيود والعلاقات مع الكيانات الأخرى)
  - `ExchangeRateHistoryConfiguration.cs` - تكوين تاريخ سعر الصرف
  - `CurrencyAccountConfiguration.cs` - تكوين حساب العملة
  - `CurrencyRoundingRuleConfiguration.cs` - تكوين قاعدة تقريب العملة
  - `CurrencyRiskLimitConfiguration.cs` - تكوين حد مخاطر العملة
  - `AccountConfiguration.cs` - تكوين الحساب المالي
  - `TransactionConfiguration.cs` - تكوين المعاملة المالية
  - `BankAccountConfiguration.cs` - تكوين الحساب البنكي
- **SettingsParameters/** - تكوينات الإعدادات والمعاملات
  - `FiscalYearConfiguration.cs` - تكوين السنة المالية
  - `FiscalPeriodConfiguration.cs` - تكوين الفترة المحاسبية (تعريف الجدول والعلاقات مع السنة المالية وقيود الفهارس)
  - `FiscalYearSettingConfiguration.cs` - تكوين إعدادات السنة المالية
  - `FiscalYearClosingConfiguration.cs` - تكوين إقفال السنة المالية
  - `FiscalPeriodLockConfiguration.cs` - تكوين تأمين الفترة المحاسبية (تعريف الجدول والعلاقات مع الفترة المحاسبية وقيود الفهارس)
  - `FiscalPeriodAdjustmentConfiguration.cs` - تكوين تسويات الفترة المحاسبية (تعريف الجدول والعلاقات مع الفترة المحاسبية وقيود الفهارس)

### External - خدمات خارجية
- **Email/** - البريد الإلكتروني
  - `EmailService.cs` - خدمة البريد الإلكتروني
- **SMS/** - الرسائل القصيرة
  - `SmsService.cs` - خدمة الرسائل القصيرة
- **Payment/** - الدفع
  - خدمات الدفع الخارجية
- **Storage/** - التخزين
  - خدمات التخزين الخارجية

### Services - الخدمات
- `DateTimeService.cs` - خدمة التاريخ والوقت
- `FileService.cs` - خدمة الملفات
- تنفيذ لمختلف واجهات الخدمة
- `FiscalCalendarService.cs` - خدمة التقويم المالي
- `PeriodCalculationService.cs` - خدمة حساب الفترات المحاسبية
- `DomainEventService.cs` - خدمة أحداث النطاق
- `DomainEventDispatcher.cs` - موزع أحداث النطاق

### Extensions - امتدادات
- `ServiceCollectionExtensions.cs` - امتدادات مجموعة الخدمات
- `QueryableExtensions.cs` - امتدادات الاستعلامات
- امتدادات أخرى

## تدفق الوصول إلى البيانات

1. **استخدام المستودعات**:
   - الوصول إلى البيانات من خلال المستودعات
   - استخدام وحدة العمل لضمان اتساق المعاملات
   - تجميع التغييرات وحفظها كوحدة واحدة

2. **استخدام سياق EF Core**:
   - استخدام Entity Framework Core للوصول إلى قاعدة البيانات
   - استخدام التكوينات لتعيين العلاقات والخصائص
   - استخدام الترحيلات لإدارة مخطط قاعدة البيانات

3. **الهوية والمصادقة**:
   - استخدام خدمات الهوية للمصادقة والتفويض
   - إدارة المستخدمين والأدوار والمطالبات
   - إنشاء وإدارة رموز JWT

## تكامل الخدمات الخارجية

1. **البريد الإلكتروني**:
   - إرسال إشعارات البريد الإلكتروني
   - استخدام قوالب للرسائل

2. **الرسائل القصيرة**:
   - إرسال إشعارات SMS
   - التكامل مع مزودي خدمة SMS

3. **المدفوعات**:
   - معالجة المدفوعات من خلال بوابات الدفع
   - تتبع معاملات الدفع

4. **التخزين**:
   - تخزين وإدارة الملفات
   - التكامل مع خدمات التخزين السحابية

## إعدادات النظام (SettingsParameters)

### المستودعات (Repositories)

#### ISequenceRepository
واجهة مستودع التسلسلات الرقمية:
- GetById(Guid id): SequenceDefinition
- GetByCode(string code): SequenceDefinition
- GetPaginatedList(SequenceFilterSpecification specification): PaginatedList<SequenceDefinition>
- Add(SequenceDefinition sequence): Task<Guid>
- Update(SequenceDefinition sequence): Task<bool>
- Delete(SequenceDefinition sequence): Task<bool>
- GetNextNumber(Guid sequenceId): Task<(long RawNumber, string FormattedNumber)>
- GetSequenceNumbersHistory(Guid sequenceId, SequenceNumberHistoryRequest request): Task<PaginatedList<SequenceNumberHistoryItem>>
- GetSequenceAuditLog(Guid sequenceId, SequenceAuditLogRequest request): Task<PaginatedList<SequenceAuditLogItem>>
- GetNumberGaps(Guid sequenceId, NumberGapRequest request): Task<PaginatedList<NumberGap>>
- ValidateNumber(Guid sequenceId, string formattedNumber): Task<NumberValidationResult>

**التنفيذ SequenceRepository**

### خدمات البنية التحتية (Infrastructure Services)

#### INumberGenerationService
واجهة خدمة توليد الأرقام التسلسلية:
- GenerateNextNumber(SequenceDefinition sequence, NumberGenerationContext context): Task<GeneratedNumber>
- FormatNumber(SequenceDefinition sequence, long rawNumber, NumberGenerationContext context): string
- ParseFormattedNumber(SequenceDefinition sequence, string formattedNumber): Task<(bool Success, long RawNumber)>
- ValidateNumberFormat(SequenceDefinition sequence, string formattedNumber): Task<(bool IsValid, string ErrorMessage)>
- DetectGaps(SequenceDefinition sequence): Task<List<NumberGap>>

**التنفيذ NumberGenerationService**

#### ISequenceConsistencyService
واجهة خدمة التحقق من تناسق التسلسلات:
- CheckSequenceConsistency(Guid sequenceId): Task<SequenceConsistencyReport>
- FixSequenceConsistency(Guid sequenceId, SequenceConsistencyFixOptions options): Task<bool>
- PerformPeriodicConsistencyCheck(): Task
- GetConsistencyStatistics(): Task<SequenceConsistencyStatistics>

**التنفيذ SequenceConsistencyService**

#### ISequenceIntegrationService
واجهة خدمة تكامل التسلسلات مع الأنظمة الخارجية:
- SynchronizeSequences(List<ExternalSystemMapping> mappings): Task<SynchronizationResult>
- ImportSequencesFromExternalSystem(string externalSystemCode): Task<ImportResult>
- ExportSequencesToExternalSystem(string externalSystemCode, List<Guid> sequenceIds): Task<ExportResult>
- MapExternalNumbers(string externalSystemCode, ExternalNumberMappingRequest request): Task<MappingResult>

**التنفيذ SequenceIntegrationService**

### التكوينات (Configurations)

#### SequenceEntityConfiguration
تكوين كيان التسلسل في قاعدة البيانات:
- جدول SequenceDefinitions
- العلاقات مع الكيانات الأخرى
- فهارس الجدول

#### UsedNumberEntityConfiguration
تكوين كيان الرقم المستخدم في قاعدة البيانات:
- جدول UsedNumbers
- العلاقات مع التسلسلات
- فهارس الجدول

#### CanceledNumberEntityConfiguration
تكوين كيان الرقم الملغى في قاعدة البيانات:
- جدول CanceledNumbers
- العلاقات مع التسلسلات
- فهارس الجدول

#### NumberAllocationEntityConfiguration
تكوين كيان تخصيص نطاق الأرقام في قاعدة البيانات:
- جدول NumberAllocations
- العلاقات مع التسلسلات
- فهارس الجدول

#### NumberGapEntityConfiguration
تكوين كيان فجوة الأرقام في قاعدة البيانات:
- جدول NumberGaps
- العلاقات مع التسلسلات
- فهارس الجدول

#### SequenceAuditEntityConfiguration
تكوين كيان تدقيق التسلسل في قاعدة البيانات:
- جدول SequenceAudits
- العلاقات مع التسلسلات
- فهارس الجدول
