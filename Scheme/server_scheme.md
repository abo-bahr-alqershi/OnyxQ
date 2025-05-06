# ERP_Pro.Server - مخطط طبقة الخادم

## الوصف العام
طبقة الخادم هي طبقة العرض التي تستضيف واجهة برمجة التطبيقات (API) وربما واجهة المستخدم. تتعامل مع طلبات HTTP، وتدير المصادقة والتفويض، وتوجه الطلبات إلى طبقة التطبيق المناسبة.

## هيكل المجلدات

### Controllers - المتحكمات
- **Api/** - واجهة برمجة التطبيقات
  - `BaseApiController.cs` - المتحكم الأساسي لـ API
  - **v1/** - الإصدار 1
    - **SettingsParameters/** - الإعدادات والمعاملات
      - `CompanyInfoController.cs` - متحكم معلومات الشركة
      - `BranchesController.cs` - متحكم الفروع
      - `BranchDocumentsController.cs` - متحكم مستندات الفروع
      - `BranchWarehousesController.cs` - متحكم مستودعات الفروع
      - `BranchUsersController.cs` - متحكم مستخدمي الفروع
      - `BranchSequencesController.cs` - متحكم التسلسلات الرقمية للفروع
      - `FiscalYearsController.cs` - متحكم السنوات المالية
      - `FiscalPeriodsController.cs` - ✓ متحكم الفترات المحاسبية
      - `FiscalYearSettingsController.cs` - متحكم إعدادات السنة المالية
      - `FiscalYearClosingController.cs` - متحكم إقفال السنة المالية
    - **FinanceAccounting/** - المحاسبة المالية
      - `CurrenciesController.cs` - متحكم العملات
      - `ExchangeRatesController.cs` - متحكم أسعار الصرف
      - `AccountsController.cs` - متحكم الحسابات
    - **GeneralLedger/** - دفتر الأستاذ العام
      - `JournalEntriesController.cs` - متحكم القيود اليومية
    - **InventoryWarehousing/** - المخزون والمستودعات
      - `ItemsController.cs` - متحكم الأصناف
      - `WarehousesController.cs` - متحكم المستودعات
    - **SalesCustomers/** - المبيعات والعملاء
      - `CustomersController.cs` - متحكم العملاء
      - `SalesInvoicesController.cs` - متحكم فواتير المبيعات
    - **PurchasingVendors/** - المشتريات والموردين
      - `VendorsController.cs` - متحكم الموردين
      - `PurchaseInvoicesController.cs` - متحكم فواتير المشتريات
    - **HumanResources/** - الموارد البشرية
      - `EmployeesController.cs` - متحكم الموظفين
    - **Auth/** - المصادقة
      - `AuthController.cs` - متحكم المصادقة
    - **Identity/** - الهوية
      - `UsersController.cs` - متحكم المستخدمين
      - `RolesController.cs` - متحكم الأدوار

### Middlewares - الوسائط
- `ErrorHandlingMiddleware.cs` - وسيط معالجة الأخطاء
- `RequestLoggingMiddleware.cs` - وسيط تسجيل الطلبات
- `JwtMiddleware.cs` - وسيط JWT
- `LanguageMiddleware.cs` - وسيط اللغة

### Filters - الفلاتر
- `ApiExceptionFilterAttribute.cs` - سمة فلتر استثناء API
- `ValidationFilterAttribute.cs` - سمة فلتر التحقق من الصحة
- `ApiKeyAuthFilter.cs` - فلتر مصادقة مفتاح API

### Extensions - الامتدادات
- `ServiceCollectionExtensions.cs` - امتدادات مجموعة الخدمات
- `ApplicationBuilderExtensions.cs` - امتدادات منشئ التطبيق
- `HttpContextExtensions.cs` - امتدادات سياق HTTP

### Models - النماذج
- **ViewModels/** - نماذج العرض
  - نماذج عرض خاصة بطبقة العرض
- **Requests/** - الطلبات
  - طلبات خاصة بواجهة المستخدم
- **Responses/** - الاستجابات
  - استجابات خاصة بواجهة المستخدم

### Validation - التحقق من الصحة
- `ModelStateValidationFilter.cs` - فلتر التحقق من صحة حالة النموذج
- القواعد والتحققات الخاصة بواجهة المستخدم

### Services - الخدمات
- `CurrentUserService.cs` - خدمة المستخدم الحالي
- `RazorViewRenderer.cs` - عارض Razor

### Settings - الإعدادات
- `AppSettings.cs` - إعدادات التطبيق
- `CorsSettings.cs` - إعدادات CORS
- `SwaggerSettings.cs` - إعدادات Swagger

### Resources - الموارد
- **Localization/** - التعريب
  - ملفات موارد التعريب
- **Templates/** - القوالب
  - قوالب البريد الإلكتروني والتقارير

### OpenApi - واجهة API المفتوحة
- `SwaggerConfiguration.cs` - تكوين Swagger
- `SecurityRequirementsOperationFilter.cs` - فلتر عملية متطلبات الأمان
- توثيق API

### Pages - الصفحات
- صفحات Razor
- مكونات Blazor

### wwwroot - جذر الويب
- **css/** - أوراق الأنماط المتتالية
- **js/** - جافا سكريبت
- **lib/** - المكتبات
- **images/** - الصور
- الملفات الثابتة الأخرى

## تدفق طلب API لإدارة الفروع

1. **استقبال الطلب**:
   - استلام طلب HTTP (مثل GET /api/settings/branches)
   - معالجة الوسائط (التسجيل، مصادقة المستخدم، التحقق من اللغة)
   - التحقق من صلاحيات المستخدم للوصول لإدارة الفروع

2. **معالجة المتحكم**:
   - توجيه الطلب إلى `BranchesController`
   - تنفيذ العملية المطلوبة (الحصول على قائمة الفروع، إنشاء فرع جديد، إلخ)
   - استخدام الوسيط MediatR لإرسال الاستعلام أو الأمر المناسب

3. **التفاعل مع طبقة التطبيق**:
   - إرسال أوامر مثل `CreateBranchCommand` أو استعلامات مثل `GetBranchesQuery`
   - استلام النتائج من طبقة التطبيق

4. **إعداد الاستجابة**:
   - تنسيق النتائج (تحويلها إلى نموذج استجابة)
   - إضافة معلومات التوجيه (HATEOAS) إذا كان مطلوباً
   - إرجاع الاستجابة مع رمز الحالة المناسب

## نقاط النهاية الرئيسية (Endpoints) لمتحكم الفروع

1. **GET /api/settings/branches**
   - الحصول على قائمة الفروع مع دعم التصفية والترتيب والصفحات
   - المعاملات الاختيارية: companyId، activeOnly، searchTerm، page، pageSize، sortBy

2. **GET /api/settings/branches/{id}**
   - الحصول على تفاصيل فرع محدد بواسطة المعرف
   - المعاملات الإلزامية: id

3. **POST /api/settings/branches**
   - إنشاء فرع جديد
   - المتطلبات: نموذج بيانات الفرع، مصادقة المستخدم

4. **PUT /api/settings/branches/{id}**
   - تحديث بيانات فرع موجود
   - المتطلبات: معرف الفرع، نموذج البيانات المحدثة، مصادقة المستخدم

5. **DELETE /api/settings/branches/{id}**
   - حذف فرع (منطقياً أو فعلياً)
   - المتطلبات: معرف الفرع، مصادقة المستخدم

6. **PATCH /api/settings/branches/{id}/status**
   - تغيير حالة الفرع (نشط، غير نشط، مغلق)
   - المتطلبات: معرف الفرع، الحالة الجديدة، مصادقة المستخدم

7. **GET /api/settings/branches/{id}/warehouses**
   - الحصول على قائمة المستودعات المرتبطة بالفرع
   - المتطلبات: معرف الفرع، مصادقة المستخدم

8. **GET /api/settings/branches/{id}/users**
   - الحصول على قائمة المستخدمين المرتبطين بالفرع
   - المتطلبات: معرف الفرع، مصادقة المستخدم

9. **GET /api/settings/branches/{id}/documents**
   - الحصول على قائمة المستندات القانونية للفرع
   - المتطلبات: معرف الفرع، مصادقة المستخدم

10. **GET /api/settings/branches/hierarchy**
    - الحصول على الهيكل الهرمي للفروع
    - المعاملات الاختيارية: companyId، activeOnly، includeDetails

## نقاط النهاية الرئيسية (Endpoints) لمتحكم السنوات المالية

1. **GET /api/settings/fiscal-years**
   - الحصول على قائمة السنوات المالية مع دعم التصفية والترتيب والصفحات
   - المعاملات الاختيارية: companyId، status، searchTerm، page، pageSize، sortBy

2. **GET /api/settings/fiscal-years/{id}**
   - الحصول على تفاصيل سنة مالية محددة بواسطة المعرف
   - المعاملات الإلزامية: id

3. **GET /api/settings/fiscal-years/code/{code}**
   - الحصول على سنة مالية بواسطة الرمز
   - المعاملات الإلزامية: code

4. **GET /api/settings/fiscal-years/default**
   - الحصول على السنة المالية الافتراضية
   - بدون معاملات

5. **GET /api/settings/fiscal-years/{id}/statistics**
   - الحصول على إحصائيات السنة المالية
   - المعاملات الإلزامية: id

6. **GET /api/settings/fiscal-years/{id}/settings**
   - الحصول على إعدادات السنة المالية
   - المعاملات الإلزامية: id

7. **POST /api/settings/fiscal-years**
   - إنشاء سنة مالية جديدة
   - المتطلبات: نموذج بيانات السنة المالية، مصادقة المستخدم

8. **PUT /api/settings/fiscal-years/{id}**
   - تحديث بيانات سنة مالية موجودة
   - المتطلبات: معرف السنة المالية، نموذج البيانات المحدثة، مصادقة المستخدم

9. **DELETE /api/settings/fiscal-years/{id}**
   - حذف سنة مالية (منطقياً أو فعلياً)
   - المتطلبات: معرف السنة المالية، مصادقة المستخدم

10. **PATCH /api/settings/fiscal-years/{id}/status**
    - تغيير حالة السنة المالية (نشطة، غير نشطة، مغلقة)
    - المتطلبات: معرف السنة المالية، الحالة الجديدة، مصادقة المستخدم

11. **POST /api/settings/fiscal-years/{id}/set-default**
    - تعيين السنة المالية كافتراضية
    - المتطلبات: معرف السنة المالية، مصادقة المستخدم

12. **POST /api/settings/fiscal-years/{id}/copy**
    - نسخ إعدادات سنة مالية لإنشاء سنة جديدة
    - المتطلبات: معرف السنة المالية المصدر، بيانات السنة المالية الجديدة، مصادقة المستخدم

13. **POST /api/settings/fiscal-years/{id}/close**
    - إقفال سنة مالية
    - المتطلبات: معرف السنة المالية، إعدادات الإقفال، مصادقة المستخدم

14. **POST /api/settings/fiscal-years/{id}/reopen**
    - إعادة فتح سنة مالية مغلقة مؤقتاً
    - المتطلبات: معرف السنة المالية، مصادقة المستخدم

15. **POST /api/settings/fiscal-years/{id}/carry-over-balances**
    - ترحيل أرصدة السنة المالية
    - المتطلبات: معرف السنة المالية المصدر، معرف السنة المالية الهدف، إعدادات الترحيل، مصادقة المستخدم

## نقاط النهاية الرئيسية (Endpoints) لمتحكم الفترات المحاسبية

1. **GET /api/settings/fiscal-periods**
   - الحصول على قائمة الفترات المحاسبية مع دعم التصفية والترتيب والصفحات
   - المعاملات الاختيارية: fiscalYearId، status، searchTerm، page، pageSize، sortBy

2. **GET /api/settings/fiscal-periods/{id}**
   - الحصول على تفاصيل فترة محاسبية محددة بواسطة المعرف
   - المعاملات الإلزامية: id

3. **GET /api/settings/fiscal-periods/current**
   - الحصول على الفترة المحاسبية الحالية
   - المعاملات الاختيارية: fiscalYearId

4. **GET /api/settings/fiscal-periods/by-date**
   - الحصول على فترة محاسبية بالتاريخ
   - المعاملات الإلزامية: date
   - المعاملات الاختيارية: fiscalYearId

5. **GET /api/settings/fiscal-periods/{id}/adjustments**
   - الحصول على تسويات الفترة المحاسبية
   - المعاملات الإلزامية: id
   - المعاملات الاختيارية: adjustmentType

6. **GET /api/settings/fiscal-periods/check-status**
   - التحقق من حالة الفترة لتاريخ محدد
   - المعاملات الإلزامية: date
   - المعاملات الاختيارية: fiscalYearId

7. **POST /api/settings/fiscal-years/{id}/periods/auto-create**
   - إنشاء فترات محاسبية تلقائياً
   - المتطلبات: معرف السنة المالية، نمط الفترات، عدد الفترات، مصادقة المستخدم

8. **POST /api/settings/fiscal-years/{id}/periods**
   - إنشاء فترة محاسبية يدوياً
   - المتطلبات: معرف السنة المالية، نموذج بيانات الفترة المحاسبية، مصادقة المستخدم

9. **PUT /api/settings/fiscal-periods/{id}**
   - تحديث بيانات فترة محاسبية موجودة
   - المتطلبات: معرف الفترة المحاسبية، نموذج البيانات المحدثة، مصادقة المستخدم

10. **DELETE /api/settings/fiscal-periods/{id}**
    - حذف فترة محاسبية (منطقياً أو فعلياً)
    - المتطلبات: معرف الفترة المحاسبية، مصادقة المستخدم

11. **PATCH /api/settings/fiscal-periods/{id}/status**
    - تغيير حالة الفترة المحاسبية (مفتوحة، مغلقة مؤقتاً، مغلقة نهائياً)
    - المتطلبات: معرف الفترة المحاسبية، الحالة الجديدة، مصادقة المستخدم

12. **POST /api/settings/fiscal-periods/{id}/lock**
    - تأمين فترة محاسبية
    - المتطلبات: معرف الفترة المحاسبية، نوع التأمين، سبب التأمين، مصادقة المستخدم

13. **POST /api/settings/fiscal-periods/{id}/unlock**
    - إلغاء تأمين فترة محاسبية
    - المتطلبات: معرف الفترة المحاسبية، مصادقة المستخدم

14. **POST /api/settings/fiscal-periods/{id}/adjustments**
    - إنشاء تسوية للفترة المحاسبية
    - المتطلبات: معرف الفترة المحاسبية، نموذج بيانات التسوية، مصادقة المستخدم

## أنماط الأمان

1. **المصادقة**:
   - المصادقة القائمة على JWT
   - تكامل OAuth
   - المصادقة بواسطة مزود خارجي

2. **التفويض**:
   - التفويض القائم على الأدوار
   - التفويض القائم على المطالبات
   - سياسات التفويض

## نقاط النهاية الرئيسية (Endpoints) لمتحكم العملات

1. **GET /api/finance-accounting/currencies**
   - الحصول على قائمة العملات مع دعم التصفية والترتيب والصفحات
   - المعاملات الاختيارية: activeOnly، isBase، searchTerm، page، pageSize، sortBy

2. **GET /api/finance-accounting/currencies/{id}**
   - الحصول على تفاصيل عملة محددة بواسطة المعرف
   - المعاملات الإلزامية: id

3. **GET /api/finance-accounting/currencies/code/{code}**
   - الحصول على عملة بواسطة الرمز
   - المعاملات الإلزامية: code

4. **GET /api/finance-accounting/currencies/base**
   - الحصول على العملة الأساسية
   - بدون معاملات

5. **GET /api/finance-accounting/currencies/{id}/accounts**
   - الحصول على الحسابات المرتبطة بالعملة
   - المعاملات الإلزامية: id
   - المعاملات الاختيارية: accountType

6. **GET /api/finance-accounting/currencies/{id}/rounding-rules**
   - الحصول على قواعد تقريب العملة
   - المعاملات الإلزامية: id
   - المعاملات الاختيارية: transactionType، isActive

7. **GET /api/finance-accounting/currencies/{id}/risk-limits**
   - الحصول على حدود مخاطر العملة
   - المعاملات الإلزامية: id
   - المعاملات الاختيارية: limitType، isActive

8. **POST /api/finance-accounting/currencies**
   - إنشاء عملة جديدة
   - المتطلبات: نموذج بيانات العملة، مصادقة المستخدم

9. **PUT /api/finance-accounting/currencies/{id}**
   - تحديث بيانات عملة موجودة
   - المتطلبات: معرف العملة، نموذج البيانات المحدثة، مصادقة المستخدم

10. **DELETE /api/finance-accounting/currencies/{id}**
    - حذف عملة
    - المتطلبات: معرف العملة، مصادقة المستخدم

11. **PATCH /api/finance-accounting/currencies/{id}/status**
    - تغيير حالة العملة (نشطة، معطلة)
    - المتطلبات: معرف العملة، الحالة الجديدة، مصادقة المستخدم

12. **POST /api/finance-accounting/currencies/{id}/set-base**
    - تعيين العملة كعملة أساسية
    - المتطلبات: معرف العملة، مصادقة المستخدم

13. **POST /api/finance-accounting/currencies/{id}/update-rounding**
    - تحديث قواعد تقريب العملة
    - المتطلبات: معرف العملة، بيانات التقريب، مصادقة المستخدم

14. **POST /api/finance-accounting/currencies/{id}/accounts**
    - إضافة حساب للعملة
    - المتطلبات: معرف العملة، بيانات الحساب، مصادقة المستخدم

15. **PUT /api/finance-accounting/currencies/{id}/accounts/{accountId}**
    - تحديث حساب مرتبط بالعملة
    - المتطلبات: معرف العملة، معرف الحساب، بيانات محدثة، مصادقة المستخدم

16. **POST /api/finance-accounting/currencies/{id}/risk-limits**
    - إضافة حد مخاطر للعملة
    - المتطلبات: معرف العملة، بيانات حد المخاطر، مصادقة المستخدم

17. **PUT /api/finance-accounting/currencies/{id}/risk-limits/{limitId}**
    - تحديث حد مخاطر للعملة
    - المتطلبات: معرف العملة، معرف الحد، بيانات محدثة، مصادقة المستخدم

## نقاط النهاية الرئيسية (Endpoints) لمتحكم أسعار الصرف

1. **GET /api/finance-accounting/exchange-rates**
   - الحصول على قائمة أسعار الصرف مع دعم التصفية والترتيب والصفحات
   - المعاملات الاختيارية: currencyCode، fromDate، toDate، rateType، page، pageSize، sortBy

2. **GET /api/finance-accounting/exchange-rates/current**
   - الحصول على أسعار الصرف الحالية لجميع العملات
   - المعاملات الاختيارية: baseCurrencyOnly، rateType

3. **GET /api/finance-accounting/exchange-rates/{currencyCode}**
   - الحصول على سعر الصرف الحالي لعملة محددة
   - المعاملات الإلزامية: currencyCode
   - المعاملات الاختيارية: rateType

4. **GET /api/finance-accounting/exchange-rates/{currencyCode}/history**
   - الحصول على تاريخ أسعار صرف عملة محددة
   - المعاملات الإلزامية: currencyCode
   - المعاملات الاختيارية: fromDate، toDate، rateType، page، pageSize

5. **POST /api/finance-accounting/exchange-rates**
   - إضافة سعر صرف جديد
   - المتطلبات: بيانات سعر الصرف، مصادقة المستخدم

6. **PUT /api/finance-accounting/exchange-rates/{id}**
   - تحديث سعر صرف موجود
   - المتطلبات: معرف سعر الصرف، بيانات محدثة، مصادقة المستخدم

7. **POST /api/finance-accounting/exchange-rates/import**
   - استيراد أسعار الصرف من مصدر خارجي
   - المتطلبات: بيانات الاستيراد، مصادقة المستخدم

8. **POST /api/finance-accounting/exchange-rates/convert**
   - تحويل مبلغ من عملة إلى أخرى
   - المتطلبات: بيانات التحويل (العملة المصدر، العملة الهدف، المبلغ، تاريخ الصرف)
   - المعاملات الاختيارية: rateType، applyRounding

9. **POST /api/finance-accounting/exchange-rates/batch-convert**
   - تحويل مجموعة من المبالغ بعملات مختلفة إلى عملة واحدة
   - المتطلبات: بيانات التحويل (قائمة المبالغ والعملات، العملة الهدف)
   - المعاملات الاختيارية: asOfDate، rateType، applyRounding

## نقاط النهاية الرئيسية (Endpoints) لمتحكم التسلسلات الرقمية

1. **GET /api/settings/sequences**
   - الحصول على قائمة التسلسلات الرقمية مع دعم التصفية والترتيب والصفحات
   - المعاملات الاختيارية: GroupFilter، StatusFilter، SearchTerm، PageNumber، PageSize، OrderBy
   - الاستجابة: PaginatedList<SequenceListItemDto>

2. **GET /api/settings/sequences/{id}**
   - الحصول على تفاصيل تسلسل محدد بواسطة المعرف
   - المعاملات الإلزامية: id
   - الاستجابة: SequenceDetailsDto

3. **GET /api/settings/sequences/code/{code}**
   - الحصول على تسلسل بواسطة الرمز
   - المعاملات الإلزامية: code
   - الاستجابة: SequenceDetailsDto

4. **GET /api/settings/sequences/next-number**
   - الحصول على الرقم التالي في التسلسل
   - المعاملات الإلزامية: SequenceCode/SequenceId
   - المعاملات الاختيارية: BranchCode، DepartmentCode، SectionCode، UserCode، FiscalYearCode
   - الاستجابة: NextNumberDto

5. **POST /api/settings/sequences/validate-number**
   - التحقق من صحة رقم تسلسلي
   - الجسم: ValidateNumberQuery
   - الاستجابة: NumberValidationResultDto

6. **GET /api/settings/sequences/{id}/numbers-history**
   - الحصول على سجل الأرقام المستخدمة للتسلسل
   - المعاملات الإلزامية: id
   - المعاملات الاختيارية: RecordType، FromDate، ToDate، UserId، BranchId، PageNumber، PageSize
   - الاستجابة: PaginatedList<SequenceNumberHistoryDto>

7. **GET /api/settings/sequences/{id}/audit-log**
   - الحصول على سجل تدقيق التسلسل
   - المعاملات الإلزامية: id
   - المعاملات الاختيارية: AuditType، FromDate، ToDate، UserId، PageNumber، PageSize
   - الاستجابة: PaginatedList<SequenceAuditLogDto>

8. **GET /api/settings/sequences/{id}/gaps**
   - الحصول على فجوات الأرقام في التسلسل
   - المعاملات الإلزامية: id
   - المعاملات الاختيارية: ResolutionStatus، FromDate، ToDate، PageNumber، PageSize
   - الاستجابة: PaginatedList<NumberGapDto>

9. **POST /api/settings/sequences**
   - إنشاء تسلسل جديد
   - الجسم: CreateSequenceCommand
   - الاستجابة: Guid (معرف التسلسل الجديد)

10. **PUT /api/settings/sequences/{id}**
    - تحديث بيانات تسلسل موجود
    - المعاملات الإلزامية: id
    - الجسم: UpdateSequenceCommand
    - الاستجابة: bool (نجاح أو فشل العملية)

11. **DELETE /api/settings/sequences/{id}**
    - حذف تسلسل
    - المعاملات الإلزامية: id
    - الاستجابة: bool (نجاح أو فشل العملية)

12. **PATCH /api/settings/sequences/{id}/status**
    - تغيير حالة التسلسل (نشط/معطل)
    - المعاملات الإلزامية: id
    - الجسم: ChangeSequenceStatusCommand
    - الاستجابة: bool (نجاح أو فشل العملية)

13. **POST /api/settings/sequences/{id}/reset-counter**
    - إعادة تعيين عداد التسلسل
    - المعاملات الإلزامية: id
    - الجسم: ResetSequenceCounterCommand
    - الاستجابة: bool (نجاح أو فشل العملية)

14. **POST /api/settings/sequences/{id}/reserve-range**
    - حجز نطاق من الأرقام
    - المعاملات الإلزامية: id
    - الجسم: ReserveNumberRangeCommand
    - الاستجابة: Guid (معرف الحجز)

15. **POST /api/settings/sequences/{id}/release-number**
    - إلغاء حجز رقم محجوز
    - المعاملات الإلزامية: id
    - الجسم: ReleaseReservedNumberCommand
    - الاستجابة: bool (نجاح أو فشل العملية)

16. **POST /api/settings/sequences/{id}/cancel-number**
    - إلغاء رقم مستخدم
    - المعاملات الإلزامية: id
    - الجسم: CancelNumberCommand
    - الاستجابة: bool (نجاح أو فشل العملية)
