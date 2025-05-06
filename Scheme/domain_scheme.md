# ERP_Pro.Domain - مخطط طبقة النطاق

## الوصف العام
طبقة النطاق هي قلب النظام وتحتوي على منطق الأعمال الأساسي والموديلات والكيانات. تطبق هذه الطبقة مبادئ التصميم المدفوع بالنطاق (DDD).

## هيكل المجلدات

### Common - المكونات المشتركة
- **Base/** - الأصناف الأساسية
  - `Entity.cs` - الصنف الأساسي للكيانات
  - `AuditableEntity.cs` - الصنف الأساسي للكيانات القابلة للتدقيق
  - `AggregateRoot.cs` - جذر التجميع للكيانات المركبة (DDD)
- **ValueObjects/** - كائنات القيمة
  - كائنات غير قابلة للتغيير تُستخدم لتمثيل المفاهيم في النطاق
- **Interfaces/** - الواجهات
  - تعريفات الواجهات المستخدمة في النطاق
- **Events/** - الأحداث
  - `IDomainEvent.cs` - واجهة أحداث النطاق
  - أحداث النطاق المختلفة
- **Enums/** - التعدادات
  - تعدادات مستخدمة في النطاق
- **Exceptions/** - الاستثناءات
  - `DomainException.cs` - استثناءات خاصة بالنطاق
- **Primitives/** - الأنواع الأساسية
  - أنواع أساسية مخصصة

### SettingsParameters - الإعدادات والمعاملات
- **Entities/** - كيانات الإعدادات
  - `CompanyInfo.cs` - كيان معلومات الشركة
  - `Branch.cs` - كيان الفرع
  - `BranchWarehouse.cs` - كيان مستودع الفرع
  - `BranchUser.cs` - كيان مستخدم الفرع
  - `BranchDocument.cs` - كيان مستند الفرع
  - `BranchAccount.cs` - كيان حساب الفرع
  - `BranchSequence.cs` - كيان التسلسل الرقمي للفرع
  - `FiscalYear.cs` - كيان السنة المالية
  - `FiscalPeriod.cs` - كيان الفترة المحاسبية (يحتوي على بيانات الفترة المحاسبية مثل التاريخ والرمز والنوع والحالة)
  - `FiscalYearSetting.cs` - كيان إعدادات السنة المالية
  - `FiscalYearClosing.cs` - كيان إقفال السنة المالية
  - `FiscalPeriodLock.cs` - كيان تأمين الفترة المحاسبية (يسجل عمليات تأمين الفترات مع نوع التأمين والمستخدم وتاريخ بداية ونهاية التأمين)
  - `FiscalPeriodAdjustment.cs` - كيان تسويات الفترة المحاسبية (يسجل عمليات التسوية المالية المرتبطة بالفترة مثل ترحيل المصروفات والإيرادات)
- **ValueObjects/** - كائنات القيمة
  - `Address.cs` - كائن قيمة للعنوان
  - `ContactInfo.cs` - كائن قيمة لمعلومات الاتصال
  - `LegalInfo.cs` - كائن قيمة للمعلومات القانونية
  - `CarryOverSettings.cs` - كائن قيمة لإعدادات ترحيل الأرصدة
  - `LockSettings.cs` - كائن قيمة لإعدادات التأمين
- **Events/** - أحداث النطاق
  - `BranchCreatedEvent.cs` - حدث إنشاء فرع
  - `BranchUpdatedEvent.cs` - حدث تحديث فرع
  - `BranchStatusChangedEvent.cs` - حدث تغيير حالة فرع
  - `FiscalYearCreatedEvent.cs` - حدث إنشاء سنة مالية
  - `FiscalYearUpdatedEvent.cs` - حدث تحديث سنة مالية
  - `FiscalYearStatusChangedEvent.cs` - حدث تغيير حالة سنة مالية
  - `FiscalYearClosedEvent.cs` - حدث إقفال سنة مالية
  - `FiscalPeriodCreatedEvent.cs` - حدث إنشاء فترة محاسبية (يطلق عند إنشاء فترة محاسبية جديدة سواء يدوياً أو تلقائياً)
  - `FiscalPeriodUpdatedEvent.cs` - حدث تحديث فترة محاسبية (يطلق عند تحديث بيانات الفترة المحاسبية)
  - `FiscalPeriodStatusChangedEvent.cs` - حدث تغيير حالة فترة محاسبية (يطلق عند تغيير حالة الفترة المحاسبية مثل الفتح أو الإقفال)
  - `FiscalPeriodLockedEvent.cs` - حدث تأمين فترة محاسبية (يطلق عند تأمين الفترة المحاسبية بأي نوع من أنواع التأمين)
  - `FiscalPeriodUnlockedEvent.cs` - حدث إلغاء تأمين فترة محاسبية (يطلق عند إلغاء تأمين الفترة المحاسبية)
  - `FiscalPeriodAdjustmentCreatedEvent.cs` - حدث إنشاء تسوية للفترة المحاسبية (يطلق عند إنشاء تسوية جديدة للفترة)
- **Enums/** - تعدادات
  - `BranchTypeEnum.cs` - تعداد أنواع الفروع
  - `BranchStatusEnum.cs` - تعداد حالات الفرع
  - `DocumentTypeEnum.cs` - تعداد أنواع المستندات
  - `FiscalYearStatusEnum.cs` - تعداد حالات السنة المالية
  - `FiscalPeriodStatusEnum.cs` - تعداد حالات الفترة المحاسبية
  - `FiscalPeriodTypeEnum.cs` - تعداد أنواع الفترات المحاسبية
  - `CalendarTypeEnum.cs` - تعداد أنواع التقويم
  - `ClosingTypeEnum.cs` - تعداد أنواع الإقفال
  - `LockTypeEnum.cs` - تعداد أنواع التأمين
  - `AdjustmentTypeEnum.cs` - تعداد أنواع التسويات
- **Exceptions/** - استثناءات
  - `InvalidBranchOperationException.cs` - استثناء عملية فرع غير صالحة
  - `InvalidFiscalYearOperationException.cs` - استثناء عملية سنة مالية غير صالحة
  - `InvalidFiscalPeriodOperationException.cs` - استثناء عملية فترة محاسبية غير صالحة
  - `ClosedPeriodException.cs` - استثناء الفترة المغلقة
  - `OverlappingPeriodsException.cs` - استثناء تداخل الفترات

### FinanceAccounting - المالية والمحاسبة
- **Entities/** - كيانات المالية والمحاسبة
  - `Currency.cs` - كيان العملة (يحتوي على بيانات العملة مثل الرمز والاسم والخصائص وقواعد التقريب)
  - `ExchangeRateHistory.cs` - كيان تاريخ سعر الصرف (يسجل قيم أسعار صرف العملات عبر الزمن)
  - `CurrencyAccount.cs` - كيان حساب العملة (يربط العملة بالحسابات المحاسبية المناسبة)
  - `CurrencyRoundingRule.cs` - كيان قاعدة تقريب العملة (يحدد كيفية تقريب مبالغ العملة)
  - `CurrencyRiskLimit.cs` - كيان حد مخاطر العملة (يحدد حدود المخاطر المالية المرتبطة بالعملة)
  - `Account.cs` - كيان الحساب المالي
  - `AccountGroup.cs` - كيان مجموعة الحسابات
  - `AccountType.cs` - كيان نوع الحساب
  - `Transaction.cs` - كيان المعاملة المالية
  - `TransactionItem.cs` - كيان بند المعاملة المالية
  - `PaymentMethod.cs` - كيان طريقة الدفع
  - `PaymentTerm.cs` - كيان شرط الدفع
  - `BankAccount.cs` - كيان الحساب البنكي
  - `BankTransaction.cs` - كيان المعاملة البنكية
  - `Check.cs` - كيان الشيك
- **ValueObjects/** - كائنات القيمة الخاصة بالمحاسبة
  - `CurrencyId.cs` - كائن قيمة معرف العملة
  - `CurrencyRiskLimitId.cs` - كائن قيمة معرف حد مخاطر العملة
  - `AccountId.cs` - كائن قيمة معرف الحساب
  - `Money.cs` - كائن قيمة النقود (يمثل مبلغ بعملة محددة)
  - `ExchangeRate.cs` - كائن قيمة سعر الصرف
  - `MoneyRange.cs` - كائن قيمة نطاق نقدي
  - `AccountNumber.cs` - كائن قيمة رقم الحساب
  - `BankInfo.cs` - كائن قيمة معلومات البنك
  - `PaymentInfo.cs` - كائن قيمة معلومات الدفع
  - `CreditRating.cs` - كائن قيمة تصنيف الائتمان
- **Events/** - أحداث النطاق المالي
  - `CurrencyCreatedEvent.cs` - حدث إنشاء عملة جديدة
  - `CurrencyUpdatedEvent.cs` - حدث تحديث بيانات العملة
  - `CurrencyStatusChangedEvent.cs` - حدث تغيير حالة العملة
  - `CurrencySetAsBaseEvent.cs` - حدث تعيين العملة كعملة أساسية
  - `CurrencyUnsetAsBaseEvent.cs` - حدث إلغاء تعيين العملة كعملة أساسية
  - `ExchangeRateAddedEvent.cs` - حدث إضافة سعر صرف جديد
  - `ExchangeRateUpdatedEvent.cs` - حدث تحديث سعر صرف
  - `CurrencyRiskLimitAddedEvent.cs` - حدث إضافة حد مخاطر للعملة
  - `CurrencyRiskLimitUpdatedEvent.cs` - حدث تحديث حد مخاطر للعملة
  - `CurrencyRiskLimitExceededEvent.cs` - حدث تجاوز حد مخاطر للعملة
  - `AccountCreatedEvent.cs` - حدث إنشاء حساب
  - `AccountUpdatedEvent.cs` - حدث تحديث حساب
  - `TransactionCreatedEvent.cs` - حدث إنشاء معاملة مالية
  - `TransactionUpdatedEvent.cs` - حدث تحديث معاملة مالية
  - `BankTransactionCreatedEvent.cs` - حدث إنشاء معاملة بنكية
- **Enums/** - تعدادات خاصة بالمالية
  - `CurrencyStatusEnum.cs` - تعداد حالات العملة
  - `CurrencySymbolPositionEnum.cs` - تعداد مواقع رمز العملة
  - `CurrencyRoundingTypeEnum.cs` - تعداد أنواع تقريب العملة
  - `CurrencyAccountTypeEnum.cs` - تعداد أنواع حسابات العملة
  - `CurrencyRiskLimitTypeEnum.cs` - تعداد أنواع حدود مخاطر العملة
  - `ExchangeRateTypeEnum.cs` - تعداد أنواع أسعار الصرف
  - `AccountStatusEnum.cs` - تعداد حالات الحساب
  - `AccountCategoryEnum.cs` - تعداد فئات الحساب
  - `TransactionTypeEnum.cs` - تعداد أنواع المعاملات المالية
  - `TransactionStatusEnum.cs` - تعداد حالات المعاملات المالية
  - `PaymentMethodTypeEnum.cs` - تعداد أنواع طرق الدفع
  - `CheckStatusEnum.cs` - تعداد حالات الشيكات

### GeneralLedger - دفتر الأستاذ العام
- **Entities/** - كيانات دفتر الأستاذ
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث دفتر الأستاذ
- **Enums/** - تعدادات دفتر الأستاذ

### HumanResources - الموارد البشرية
- **Entities/** - كيانات الموارد البشرية
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث الموارد البشرية
- **Enums/** - تعدادات الموارد البشرية

### InventoryWarehousing - المخزون والمستودعات
- **Entities/** - كيانات المخزون
  - `Warehouse.cs` - كيان المستودع
  - `Item.cs` - كيان الصنف
  - `InventoryTransaction.cs` - كيان معاملة المخزون
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث المخزون
- **Enums/** - تعدادات المخزون

### SalesCustomers - المبيعات والعملاء
- **Entities/** - كيانات المبيعات والعملاء
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث المبيعات
- **Enums/** - تعدادات المبيعات

### PurchasingVendors - المشتريات والموردين
- **Entities/** - كيانات المشتريات والموردين
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث المشتريات
- **Enums/** - تعدادات المشتريات

### FixedAssets - الأصول الثابتة
- **Entities/** - كيانات الأصول الثابتة
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث الأصول
- **Enums/** - تعدادات الأصول

### ProductionManufacturing - الإنتاج والتصنيع
- **Entities/** - كيانات الإنتاج
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث الإنتاج
- **Enums/** - تعدادات الإنتاج

### ServicesMaintenance - الخدمات والصيانة
- **Entities/** - كيانات الخدمات والصيانة
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث الصيانة
- **Enums/** - تعدادات الصيانة

### UsersPermissions - المستخدمين والصلاحيات
- **Entities/** - كيانات المستخدمين
- **ValueObjects/** - كائنات القيمة
- **Events/** - أحداث المستخدمين
- **Enums/** - تعدادات الصلاحيات

## العلاقات الرئيسية بين الكيانات

1. **CompanyInfo** -> **Branch**
   - الشركة لها مجموعة من الفروع

2. **Branch** -> **Branch**
   - الفرع يمكن أن يكون له فروع فرعية (علاقة أبوية)

3. **Branch** -> **Warehouse**
   - الفرع يمكن أن يكون له عدة مستودعات

4. **Branch** -> **BranchUser**
   - الفرع مرتبط بمجموعة من المستخدمين عبر كيان وسيط

5. **Branch** -> **BranchDocument**
   - الفرع له مجموعة من المستندات القانونية

6. **Branch** -> **BranchAccount**
   - الفرع مرتبط بمجموعة من الحسابات المالية

7. **Branch** -> **BranchSequence**
   - الفرع له مجموعة من التسلسلات الرقمية للمستندات

8. **CompanyInfo** -> **FiscalYear**
   - الشركة لها مجموعة من السنوات المالية

9. **FiscalYear** -> **FiscalPeriod**
   - السنة المالية تتكون من مجموعة من الفترات المحاسبية

10. **FiscalYear** -> **FiscalYearSetting**
    - السنة المالية لها مجموعة من الإعدادات المتقدمة

11. **FiscalYear** -> **FiscalYearClosing**
    - السنة المالية لها سجلات عمليات الإقفال

12. **FiscalPeriod** -> **FiscalPeriodLock**
    - الفترة المحاسبية لها سجلات عمليات التأمين

13. **FiscalPeriod** -> **FiscalPeriodAdjustment**
    - الفترة المحاسبية لها سجلات عمليات التسويات

14. **FiscalYear** -> **GeneralLedger.JournalEntry**
    - السنة المالية مرتبطة بمجموعة من القيود المحاسبية

15. **FiscalPeriod** -> **GeneralLedger.JournalEntry**
    - الفترة المحاسبية مرتبطة بمجموعة من القيود المحاسبية

16. **HumanResources.Employee** -> **UsersPermissions.User**
   - كل موظف مرتبط بمستخدم في النظام

17. **SalesCustomers.Customer** -> **FinanceAccounting.Account**
   - كل عميل مرتبط بحساب في النظام المالي

18. **PurchasingVendors.Vendor** -> **FinanceAccounting.Account**
    - كل مورد مرتبط بحساب في النظام المالي

19. **InventoryWarehousing.Item** -> **FinanceAccounting.Account**
    - كل صنف مرتبط بحساب في النظام المالي

20. **SalesCustomers.SalesInvoice** -> **GeneralLedger.JournalEntry**
    - كل فاتورة مبيعات ترتبط بقيد محاسبي

21. **PurchasingVendors.PurchaseInvoice** -> **GeneralLedger.JournalEntry**
    - كل فاتورة مشتريات ترتبط بقيد محاسبي

22. **FixedAssets.Asset** -> **FinanceAccounting.Account**
    - كل أصل ثابت مرتبط بحساب في النظام المالي

## إعدادات النظام (SettingsParameters)

### الكيانات (Entities)

#### SequenceDefinition (تعريف التسلسل)
كيان يمثل تعريف تسلسل رقمي في النظام:
- المعرف (Id)
- الرمز (Code)
- الاسم بالعربية (NameAr)
- الاسم بالإنجليزية (NameEn)
- نوع المستند المرتبط (DocumentType)
- المجموعة (Group)
- الوصف (Description)
- الحالة (Status)
- الشاشات المستخدمة (UsedInScreens)
- البادئة (Prefix)
- اللاحقة (Suffix)
- استخدام رمز السنة المالية (IncludeFiscalYearCode)
- تنسيق رمز السنة (YearFormat)
- استخدام رمز الفرع (IncludeBranchCode)
- استخدام رمز الإدارة (IncludeDepartmentCode)
- استخدام رمز القسم (IncludeSectionCode)
- استخدام رمز المستخدم (IncludeUserCode)
- عدد خانات الترقيم (NumberLength)
- فاصل البادئة (PrefixSeparator)
- فاصل اللاحقة (SuffixSeparator)
- إكمال الخانات بأصفار (PadWithZeros)
- بداية نطاق الترقيم (StartNumber)
- نهاية نطاق الترقيم (EndNumber)
- الرقم الحالي (CurrentNumber)
- قيمة الزيادة (Increment)
- إعادة ضبط مع السنة المالية (ResetWithFiscalYear)
- إعادة ضبط مع الفرع (ResetWithBranch)
- إعادة ضبط مع الشهر (ResetWithMonth)
- السماح بالتعديل اليدوي (AllowManualEdit)
- المستخدمون المصرح لهم بالتعديل (ManualEditAllowedUsers)
- السماح بإعادة استخدام الأرقام الملغاة (AllowReuseOfCanceledNumbers)
- أيام انتظار إعادة استخدام الأرقام الملغاة (DaysBeforeReuseOfCanceledNumbers)
- ملاحظات (Notes)
- الأرقام المخصصة (NumberAllocations)
- الأرقام المستخدمة (UsedNumbers)
- الأرقام الملغاة (CanceledNumbers)
- فجوات الأرقام (NumberGaps)
- سجلات التدقيق (AuditRecords)

#### UsedNumber (الرقم المستخدم)
كيان يمثل رقم تسلسلي تم استخدامه:
- المعرف (Id)
- معرف التسلسل (SequenceId)
- الرقم المنسق (FormattedNumber)
- الرقم الخام (RawNumber)
- تاريخ الاستخدام (UsageDate)
- معرف المستخدم (UserId)
- معرف المستند (DocumentId)
- نوع المستند (DocumentType)
- معرف الفرع (BranchId)

#### CanceledNumber (الرقم الملغى)
كيان يمثل رقم تسلسلي تم إلغاؤه:
- المعرف (Id)
- معرف التسلسل (SequenceId)
- الرقم المنسق (FormattedNumber)
- الرقم الخام (RawNumber)
- سبب الإلغاء (CancellationReason)
- معرف المستخدم الذي قام بالإلغاء (CanceledByUserId)
- تاريخ الإلغاء (CancellationDate)
- تاريخ إعادة الاستخدام (ReuseDate)
- الحالة (Status)

#### NumberAllocation (تخصيص نطاق الأرقام)
كيان يمثل تخصيص نطاق من الأرقام التسلسلية:
- المعرف (Id)
- معرف التسلسل (SequenceId)
- بداية النطاق (RangeStart)
- نهاية النطاق (RangeEnd)
- سبب التخصيص (Reason)
- معرف المستخدم الذي قام بالتخصيص (AllocatedByUserId)
- معرف الفرع (BranchId)
- تاريخ التخصيص (AllocationDate)
- تاريخ انتهاء الصلاحية (ExpiryDate)
- الحالة (Status)
- الرقم الحالي (CurrentNumber)

#### NumberGap (فجوة الأرقام)
كيان يمثل فجوة في تسلسل الأرقام:
- المعرف (Id)
- معرف التسلسل (SequenceId)
- بداية الفجوة (GapStart)
- نهاية الفجوة (GapEnd)
- حجم الفجوة (GapSize)
- سبب الفجوة (Reason)
- تاريخ الاكتشاف (DiscoveryDate)
- حالة المعالجة (ResolutionStatus)
- تاريخ المعالجة (ResolutionDate)
- معرف المستخدم المعالج (ResolvedByUserId)
- تفاصيل المعالجة (ResolutionDetails)

#### SequenceAudit (تدقيق التسلسل)
كيان يمثل سجل تدقيق لعمليات التسلسل:
- المعرف (Id)
- معرف التسلسل (SequenceId)
- نوع الحدث (AuditType)
- تاريخ الحدث (EventDate)
- معرف المستخدم (UserId)
- معرف الفرع (BranchId)
- القيمة القديمة (OldValue)
- القيمة الجديدة (NewValue)
- المعرف المرتبط (RelatedId)
- الوصف (Description)
- بيانات إضافية (AdditionalData)

### أحداث المجال (Domain Events)

#### SequenceCreatedEvent
حدث إنشاء تسلسل جديد:
- معرف التسلسل (SequenceId)
- تاريخ الحدوث (OccurredOn)

#### SequenceUpdatedEvent
حدث تحديث تسلسل:
- معرف التسلسل (SequenceId)
- تاريخ الحدوث (OccurredOn)

#### SequenceDeletedEvent
حدث حذف تسلسل:
- معرف التسلسل (SequenceId)
- تاريخ الحدوث (OccurredOn)

#### SequenceStatusChangedEvent
حدث تغيير حالة التسلسل:
- معرف التسلسل (SequenceId)
- الحالة الجديدة (NewStatus)
- تاريخ الحدوث (OccurredOn)

#### SequenceGroupCreatedEvent
حدث إنشاء مجموعة تسلسلات:
- معرف المجموعة (GroupId)
- اسم المجموعة (GroupName)
- تاريخ الحدوث (OccurredOn)

#### NumberRangeReservedEvent
حدث حجز نطاق من الأرقام:
- معرف التسلسل (SequenceId)
- معرف التخصيص (AllocationId)
- بداية النطاق (RangeStart)
- نهاية النطاق (RangeEnd)
- تاريخ الحدوث (OccurredOn)

#### NumberGeneratedEvent
حدث إنشاء رقم تسلسلي:
- معرف التسلسل (SequenceId)
- الرقم المنسق (FormattedNumber)
- الرقم الخام (RawNumber)
- تاريخ الحدوث (OccurredOn)

#### SequenceCounterResetEvent
حدث إعادة تعيين عداد التسلسل:
- معرف التسلسل (SequenceId)
- القيمة الجديدة (NewValue)
- تاريخ الحدوث (OccurredOn)

#### SequenceIntegrationEvent
حدث تكامل التسلسل مع نظام خارجي:
- معرف التسلسل (SequenceId)
- رمز النظام الخارجي (ExternalSystemCode)
- رمز التسلسل الخارجي (ExternalSequenceCode)
- تاريخ الحدوث (OccurredOn)

#### NumberRangeExhaustionWarningEvent
حدث تحذير من نفاد الأرقام:
- معرف التسلسل (SequenceId)
- عدد الأرقام المتبقية (RemainingCount)
- النسبة المئوية المتبقية (PercentageLeft)
- التاريخ المتوقع للنفاد (ProjectedExhaustionDate)
- تاريخ الحدوث (OccurredOn)
