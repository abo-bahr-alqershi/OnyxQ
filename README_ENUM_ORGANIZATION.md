# قواعد تحديد وإنشاء Value Objects في نماذج الدومين

## مقدمة
هذا الدليل يحدد القواعد والمعايير لتحديد خصائص النماذج التي يجب تحويلها إلى Value Objects. هذه القواعد تساعد في تحسين تصميم الكيانات وتعزيز ممارسات التصميم الموجه بالمجال (DDD) في مشروع Onyx Pro.

## القواعد العامة لتحديد Value Objects

### 1. خصائص الهوية والتعريف
- **البيانات الشخصية**: أي مجموعة من الحقول تتعلق بمعلومات الهوية الشخصية مثل:
  - رقم الهوية وتاريخ الإصدار والانتهاء ومكان الإصدار
  - جواز السفر ورقمه وتواريخ الإصدار والانتهاء
  - بطاقات الائتمان وتفاصيلها
  - رقم الضمان الاجتماعي والمعرفات الأخرى

### 2. بيانات الاتصال والعنوان
- **معلومات الاتصال**: جميع الحقول المتعلقة بوسائل الاتصال:
  - أرقام الهواتف (الثابت والمحمول والطوارئ)
  - البريد الإلكتروني
  - حسابات التواصل الاجتماعي
  - أرقام الفاكس
- **العناوين**: جميع حقول العنوان المرتبطة ببعضها:
  - الدولة والمدينة والمنطقة
  - الشارع والحي ورقم المبنى
  - الرمز البريدي وصندوق البريد
  - إحداثيات GPS ومعلومات الموقع

### 3. المعلومات المالية
- **القيم النقدية**: أي حقول تمثل قيمة مالية مع عملتها:
  - المبالغ النقدية والعملة
  - الأسعار مع وحدات القياس
  - الضرائب والخصومات
- **التفاصيل البنكية**: مجموعة الحقول المتعلقة بالحسابات البنكية:
  - اسم البنك ورقم الحساب
  - رمز IBAN ورمز SWIFT
  - معلومات بطاقات الائتمان

### 4. المعلومات الزمنية والفترات
- **الفترات الزمنية**: حقول تمثل فترة بين تاريخين:
  - تاريخ البدء وتاريخ الانتهاء
  - مدة العقد أو الضمان
  - التقويم وأوقات العمل
- **توقيت العمل**: معلومات الجدولة:
  - ساعات العمل (من/إلى)
  - أيام العمل وأيام العطلات

### 5. المقاييس والأبعاد
- **القياسات الفيزيائية**: أي مجموعة قياسات مرتبطة ببعضها:
  - الطول والعرض والارتفاع
  - الوزن والحجم والكثافة
  - المساحة والقدرة
- **المقاييس مع وحداتها**: أي قيمة مرتبطة بوحدة قياس محددة

### 6. معلومات التدقيق والتتبع
- **بيانات التدقيق**: استخدم `AuditInfo` القائم بالفعل:
  - معلومات الإنشاء (المستخدم، التاريخ، المحطة)
  - معلومات التعديل (المستخدم، التاريخ، المحطة)
  - معلومات التدقيق والمراجعة

### 7. معلومات الفروع والشركات
- **معلومات الفرع**: استخدم `BranchInfo` القائم:
  - رقم الفرع والشركة والمستودع
  - سنة العمل
- **معلومات الشركة**: استخدم `CompanyInfo` القائم:
  - رقم الشركة ومعلوماتها الأساسية

### 8. معلومات الترقيم والتسلسل
- **أنماط الترقيم**: حقول تتعلق بتسلسل أو ترقيم معين:
  - رقم المستند وتاريخه والنوع
  - التسلسل والباديء واللاحقة 
  - الكود والرمز التعريفي

### 9. الإحصائيات والقيم المجمعة
- **المؤشرات الإحصائية**: قيم ترتبط بمؤشرات موحدة:
  - الإجماليات والمتوسطات 
  - النسب المئوية ومعدلات النمو
  - مؤشرات الأداء الرئيسية

### 10. الحالة والتسجيل
- **معلومات الحالة**: حقول تصف حالة الكيان:
  - الحالة النشطة/المتوقفة
  - مستويات التأكيد والاعتماد
  - مؤشرات المعالجة والإكمال

## كيفية تطبيق القواعد

### الخطوة 1: فحص الخصائص
- راجع كل خاصية في الكيان وصنفها وفقًا للفئات أعلاه.
- حدد المجموعات المنطقية للخصائص المرتبطة (2-5 خصائص تعمل معًا).
- ابحث عن أنماط متكررة في الكيانات المختلفة.

### الخطوة 2: تحديد المرشحين للتحويل
- الخصائص التي تمثل مفهومًا كاملًا (مثل العنوان).
- مجموعات الخصائص التي تميل للتغير معًا.
- القيم التي لها قواعد تحقق خاصة.
- الخصائص التي تظهر في عدة كيانات.

### الخطوة 3: فحص شروط Value Object
- مجموعة الحقول يمكن اعتبارها Value Object إذا:
  - كانت تمثل مفهومًا واضحًا عند جمعها معًا.
  - ليس لها هوية منفصلة عن الكيان المحتوي.
  - لا تتغير عناصرها بشكل مستقل (تتغير كوحدة).
  - يمكن تطبيق قواعد التحقق المنطقية عليها كوحدة واحدة.

### الخطوة 4: التنفيذ
- عند تحويل خصائص لـ Value Object، يجب:
  1. إبقاء الخصائص الأصلية في الكيان مع توثيق الاسم القديم.
  2. إضافة خاصية Value Object تجمع هذه الخصائص معًا.
  3. تنفيذ التحويل التلقائي بين الخصائص المفردة والـ Value Object.

## أمثلة عملية

### مثال 1: بيانات العنوان
```csharp
// بدلاً من:
public string Country { get; private set; }
public string City { get; private set; }
public string Street { get; private set; }
public string PostalCode { get; private set; }

// استخدم:
public string Country { get; private set; } /*! البلد */
public string City { get; private set; } /*! المدينة */
public string Street { get; private set; } /*! الشارع */
public string PostalCode { get; private set; } /*! الرمز البريدي */

// وأضف:
public Address Address => Address.Create(Country, City, Street, PostalCode);
```

### مثال 2: معلومات الاتصال
```csharp
// بدلاً من:
public string Phone { get; private set; }
public string Mobile { get; private set; }
public string Email { get; private set; }

// استخدم:
public string Phone { get; private set; } /*! الهاتف */
public string Mobile { get; private set; } /*! الجوال */
public string Email { get; private set; } /*! البريد الإلكتروني */

// وأضف:
public ContactInfo ContactInfo => ContactInfo.Create(Phone, Mobile, Email);
```

### مثال 3: القيم المالية
```csharp
// بدلاً من:
public decimal Amount { get; private set; }
public string Currency { get; private set; }

// استخدم:
public decimal Amount { get; private set; } /*! المبلغ */
public string Currency { get; private set; } /*! العملة */

// وأضف:
public Money MoneyAmount => Money.Create(Amount, Currency);
```

## ملاحظات هامة

1. **لا تحذف أي حقل** من الحقول الأساسية عند إنشاء Value Object - احتفظ بها جميعًا في الكيان بجانب الـ Value Object.
2. **التوثيق المزدوج** - وثق الحقول الأصلية مع الاسم القديم بالإضافة إلى توثيق الـ Value Object.
3. **التسمية** - اختر أسماء واضحة ومعبرة للـ Value Objects وصف الغرض منها بدقة.
4. **إعادة الاستخدام** - عند تكرار نفس نمط الحقول في كيانات متعددة، أنشئ Value Object مشترك في مجلد Common.
5. **قابلية التغيير** - استخدم الـ records لتنفيذ Value Objects غير القابلة للتعديل.

## خاتمة
باتباع هذه القواعد، يمكن للمطورين وحتى نماذج الذكاء الاصطناعي تحديد وإنشاء Value Objects بشكل دقيق ومتسق عبر الكيانات المختلفة في المشروع، مما يساهم في تعزيز المرونة والقابلية للصيانة.



###################################################
###################################################
###################################################


# قواعد ومعايير إنشاء الأحداث (Domain Events) في نماذج الدومين

## مقدمة
هذا الدليل يحدد القواعد والمعايير الخاصة بإنشاء أحداث النطاق (Domain Events) لكافة النماذج في مشروع Onyx Pro. الأحداث هي جزء أساسي من نمط التصميم الموجه بالمجال (DDD) وتساعد في فصل المسؤوليات وضمان مرونة وقابلية صيانة النظام.

## المفاهيم الأساسية للأحداث

### تعريف الحدث (Domain Event)
الحدث هو تسجيل لشيء مهم حدث في النطاق، يمكن أن يؤدي إلى تغييرات أو إجراءات أخرى في أجزاء مختلفة من النظام.

### فوائد استخدام الأحداث
1. **الفصل بين المسؤوليات**: تفصل بين العمليات المختلفة المرتبطة بتغيير الحالة.
2. **المرونة**: تسمح بالاستجابة للتغييرات بطرق مختلفة دون تعديل الكود الأصلي.
3. **قابلية التوسع**: تسهل إضافة وظائف جديدة تستجيب لنفس الأحداث.
4. **التتبع والمراقبة**: توفر سجلًا للأحداث المهمة بالنظام.
5. **التكامل**: تسهل التكامل مع الأنظمة الخارجية.

## قواعد تحديد وإنشاء الأحداث

### 1. أحداث دورة الحياة الأساسية
لكل كيان، يجب إنشاء الأحداث الأساسية التالية:

- **Created**: عند إنشاء كيان جديد
- **Updated**: عند تحديث بيانات الكيان
- **Deleted**: عند حذف الكيان (منطقي أو فعلي)
- **Archived**: عند أرشفة الكيان

### 2. أحداث تغيير الحالة
أي تغيير في حالة الكيان يجب أن يولد حدثًا:

- **StatusChanged**: تغيير الحالة العامة
- **[State]Changed**: حسب الحالات المحددة في الكيان (مثل: Activated, Deactivated, Suspended)
- **Locked/Unlocked**: عند قفل/إلغاء قفل الكيان
- **Approved/Rejected**: عند الموافقة/الرفض على الكيان
- **Submitted/Returned**: عند التقديم/الإرجاع
- **Completed/Cancelled**: عند الإكمال/الإلغاء

### 3. أحداث العلاقات
أي تغيير في علاقات الكيان مع كيانات أخرى:

- **[Entity]Added**: عند إضافة علاقة جديدة مع كيان آخر
- **[Entity]Removed**: عند إزالة علاقة مع كيان آخر
- **[Entity]Updated**: عند تحديث العلاقة مع كيان آخر
- **[Entity]Linked/Unlinked**: عند ربط/فك الارتباط مع كيان آخر

### 4. أحداث المعالجة والتحقق
الأحداث التي تسجل إجراءات المعالجة والتحقق:

- **Validated**: اكتمال عملية التحقق من الكيان
- **ValidationFailed**: فشل التحقق من الكيان
- **Processed**: اكتمال معالجة الكيان
- **ProcessingFailed**: فشل معالجة الكيان
- **Calculated**: اكتمال حسابات متعلقة بالكيان
- **CalculationFailed**: فشل الحسابات المتعلقة بالكيان

### 5. أحداث النشر والتوزيع
الأحداث المتعلقة بنشر وتوزيع الكيان:

- **Published/Unpublished**: نشر/إلغاء نشر الكيان
- **Shared/Unshared**: مشاركة/إلغاء مشاركة الكيان
- **Exported/Imported**: تصدير/استيراد الكيان
- **Distributed**: توزيع الكيان
- **Synced**: مزامنة الكيان

### 6. أحداث خاصة بالمجال
أحداث محددة حسب طبيعة كل مجال:

#### نظام المخزون والمستودعات
- **ItemReceived**: استلام صنف
- **ItemIssued**: صرف صنف
- **StockLevelChanged**: تغير مستوى المخزون
- **StockReservationCreated**: حجز مخزون
- **StockTransferred**: نقل مخزون
- **StockAdjusted**: تسوية مخزون
- **ItemExpired**: انتهاء صلاحية صنف

#### النظام المالي والمحاسبي
- **InvoiceIssued**: إصدار فاتورة
- **PaymentReceived**: استلام دفعة
- **PaymentIssued**: صرف دفعة
- **AccountBalanceChanged**: تغير رصيد حساب
- **JournalEntryPosted**: ترحيل قيد يومية
- **JournalEntryReversed**: عكس قيد يومية
- **BudgetExceeded**: تجاوز الميزانية
- **TaxCalculated**: احتساب ضريبة

#### نظام المبيعات والعملاء
- **OrderPlaced**: إنشاء طلب
- **OrderConfirmed**: تأكيد طلب
- **OrderShipped**: شحن طلب
- **OrderDelivered**: توصيل طلب
- **OrderReturned**: إرجاع طلب
- **QuotationIssued**: إصدار عرض سعر
- **QuotationAccepted**: قبول عرض سعر
- **CustomerRegistered**: تسجيل عميل
- **CustomerCreditLimitChanged**: تغيير حد الائتمان للعميل

#### نظام الموارد البشرية
- **EmployeeHired**: توظيف موظف
- **EmployeeTerminated**: إنهاء خدمة موظف
- **SalaryChanged**: تغيير راتب
- **LeaveRequested**: طلب إجازة
- **LeaveApproved**: الموافقة على إجازة
- **AttendanceRecorded**: تسجيل حضور
- **PerformanceReviewed**: تقييم أداء
- **ContractRenewed**: تجديد عقد

#### نظام الصيانة والخدمات
- **ServiceRequested**: طلب خدمة
- **ServiceScheduled**: جدولة خدمة
- **ServiceCompleted**: إكمال خدمة
- **MaintenanceScheduled**: جدولة صيانة
- **MaintenancePerformed**: إجراء صيانة
- **WarrantyIssued**: إصدار ضمان
- **WarrantyClaimed**: المطالبة بالضمان

### 7. أحداث الأمن والصلاحيات
الأحداث المتعلقة بالأمن والصلاحيات:

- **AccessGranted/AccessRevoked**: منح/سحب صلاحية الوصول
- **PermissionChanged**: تغيير الصلاحيات
- **PasswordChanged**: تغيير كلمة المرور
- **UserLoggedIn/UserLoggedOut**: تسجيل دخول/خروج المستخدم
- **SecurityViolationDetected**: اكتشاف انتهاك أمني

## كيفية تنفيذ الأحداث

### الخطوة 1: تحليل الكيان
- حدد جميع التغييرات المهمة التي يمكن أن تحدث للكيان.
- فكر في تأثيرات هذه التغييرات على باقي النظام.
- حدد الأحداث الضرورية من القوائم أعلاه حسب طبيعة الكيان.

### الخطوة 2: تصميم الأحداث
لكل حدث، قم بإنشاء فئة تحتوي على:
- البيانات اللازمة لفهم الحدث (مثل المعرفات، القيم القديمة والجديدة).
- توثيق مفصل يشرح الغرض من الحدث.
- وراثة من فئة `DomainEventBase`.

```csharp
// مثال على تصميم حدث
public class CustomerCreditLimitChangedEvent : DomainEventBase
{
    public CustomerId CustomerId { get; }
    public decimal OldCreditLimit { get; }
    public decimal NewCreditLimit { get; }
    public string Reason { get; }
    
    public CustomerCreditLimitChangedEvent(
        CustomerId customerId,
        decimal oldCreditLimit,
        decimal newCreditLimit,
        string reason)
    {
        CustomerId = customerId;
        OldCreditLimit = oldCreditLimit;
        NewCreditLimit = newCreditLimit;
        Reason = reason;
    }
}
```

### الخطوة 3: إضافة طرق التنفيذ في الكيان
لكل حدث، أضف طريقة في الكيان تقوم بتنفيذ العملية وتوليد الحدث:

```csharp
// مثال على طريقة تنفيذ في الكيان
public void ChangeCreditLimit(decimal newCreditLimit, string reason)
{
    // التحقق من صحة القيمة
    if (newCreditLimit < 0)
        throw new DomainException("Credit limit cannot be negative");
    
    decimal oldCreditLimit = CreditLimit;
    CreditLimit = newCreditLimit;
    
    // إضافة الحدث
    AddDomainEvent(new CustomerCreditLimitChangedEvent(
        Id, 
        oldCreditLimit, 
        newCreditLimit, 
        reason ?? "Credit limit update"
    ));
}
```

### الخطوة 4: التنظيم والتوثيق
- ضع جميع أحداث الكيان في مجلد `Events` الخاص بالمجال.
- وثق كل حدث بتعليقات مفصلة بالعربية والإنجليزية.
- اجعل أسماء الأحداث واضحة وتصف الإجراء بدقة (فعل في الماضي).

## أمثلة على أحداث الكيانات المختلفة

### مثال 1: أحداث العميل (Customer)
```csharp
// أحداث دورة الحياة
CustomerCreatedEvent
CustomerUpdatedEvent
CustomerDeletedEvent

// أحداث تغيير الحالة
CustomerStatusChangedEvent
CustomerActivatedEvent
CustomerDeactivatedEvent

// أحداث العلاقات
CustomerAddressAddedEvent
CustomerAddressRemovedEvent
CustomerContactUpdatedEvent

// أحداث خاصة بالمجال
CustomerRegisteredEvent
CustomerCreditLimitChangedEvent
CustomerCategorizedEvent
CustomerLoyaltyLevelChangedEvent
CustomerDiscountAppliedEvent
```

### مثال 2: أحداث المنتج (Product)
```csharp
// أحداث دورة الحياة
ProductCreatedEvent
ProductUpdatedEvent
ProductDeletedEvent

// أحداث تغيير الحالة
ProductStatusChangedEvent
ProductActivatedEvent
ProductDiscontinuedEvent

// أحداث خاصة بالمجال
ProductPriceChangedEvent
ProductStockLevelChangedEvent
ProductCategorizedEvent
ProductPromotionAppliedEvent
ProductReviewedEvent
ProductImageAddedEvent
ProductSpecificationUpdatedEvent
```

### مثال 3: أحداث الطلب (Order)
```csharp
// أحداث دورة الحياة
OrderCreatedEvent
OrderUpdatedEvent
OrderDeletedEvent

// أحداث تغيير الحالة
OrderStatusChangedEvent
OrderConfirmedEvent
OrderShippedEvent
OrderDeliveredEvent
OrderCancelledEvent
OrderReturnedEvent

// أحداث العلاقات
OrderItemAddedEvent
OrderItemRemovedEvent
OrderItemQuantityChangedEvent

// أحداث خاصة بالمجال
OrderPaymentReceivedEvent
OrderInvoiceGeneratedEvent
OrderShippingAddressChangedEvent
OrderDiscountAppliedEvent
OrderTaxCalculatedEvent
```

## ملاحظات هامة

1. **الشمولية**: تأكد من تغطية جميع التغييرات المهمة في الكيان بأحداث مناسبة.
2. **التوازن**: تجنب المبالغة في إنشاء أحداث لتغييرات غير مهمة.
3. **المعلومات الكافية**: تأكد من أن كل حدث يحتوي على جميع المعلومات اللازمة.
4. **التوثيق**: وثق الغرض من كل حدث والبيانات المتضمنة فيه.
5. **الاتساق**: استخدم نمط تسمية متسق لجميع الأحداث (فعل ماضي + موضوع).
6. **عدم الترابط**: تجنب الاعتماد على أحداث أخرى في نفس الحدث.
7. **التوقيت**: سجل وقت حدوث الحدث (متوفر في `DomainEventBase`).
8. **البيانات الضرورية فقط**: ضمن الحدث فقط البيانات الضرورية لفهم ماذا حدث.

## خاتمة
إن التنفيذ الدقيق والشامل للأحداث في نماذج الدومين يعزز مرونة وقابلية صيانة وأمان النظام، مع توفير قدرات مراقبة وتتبع متقدمة. باتباع هذه القواعد، ستتمكن من إنشاء نظام قوي قائم على الأحداث يمكنه التكيف مع المتطلبات المستقبلية.