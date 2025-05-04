# قواعد توليد أحداث النطاق (Domain Events) للكيانات في النظام

## فئات الأحداث الرئيسية

### فئة lifecycle
| الحدث | الوصف |
| --- | --- |
| Created | يتم إطلاق هذا الحدث عند إنشاء كيان جديد |
| Updated | يتم إطلاق هذا الحدث عند تحديث بيانات الكيان |
| Deleted | يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي) |
| Archived | يتم إطلاق هذا الحدث عند أرشفة الكيان |

### فئة status
| الحدث | الوصف |
| --- | --- |
| StatusChanged | يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية |
| Activated | يتم إطلاق هذا الحدث عند تفعيل الكيان |
| Deactivated | يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان |
| Locked | يتم إطلاق هذا الحدث عند قفل الكيان |
| Unlocked | يتم إطلاق هذا الحدث عند إلغاء قفل الكيان |

### فئة approval
| الحدث | الوصف |
| --- | --- |
| Approved | يتم إطلاق هذا الحدث عند الموافقة على الكيان |
| Rejected | يتم إطلاق هذا الحدث عند رفض الكيان |
| Submitted | يتم إطلاق هذا الحدث عند تقديم الكيان للموافقة |
| Returned | يتم إطلاق هذا الحدث عند إرجاع الكيان بعد المراجعة |

### فئة validation
| الحدث | الوصف |
| --- | --- |
| Validated | يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان |
| ValidationFailed | يتم إطلاق هذا الحدث عند فشل التحقق من الكيان |

### فئة financial
| الحدث | الوصف |
| --- | --- |
| PaymentReceived | يتم إطلاق هذا الحدث عند استلام دفعة |
| PaymentIssued | يتم إطلاق هذا الحدث عند إصدار دفعة |
| InvoiceIssued | يتم إطلاق هذا الحدث عند إصدار فاتورة |
| BalanceChanged | يتم إطلاق هذا الحدث عند تغير الرصيد |
| CreditLimitChanged | يتم إطلاق هذا الحدث عند تغيير حد الائتمان |
| TaxCalculated | يتم إطلاق هذا الحدث عند احتساب الضريبة |

### فئة accounting
| الحدث | الوصف |
| --- | --- |
| AccountPosted | يتم إطلاق هذا الحدث عند ترحيل حساب |
| JournalEntryCreated | يتم إطلاق هذا الحدث عند إنشاء قيد يومية |
| JournalEntryPosted | يتم إطلاق هذا الحدث عند ترحيل قيد يومية |
| JournalEntryReversed | يتم إطلاق هذا الحدث عند عكس قيد يومية |
| BudgetExceeded | يتم إطلاق هذا الحدث عند تجاوز الميزانية |

### فئة inventory
| الحدث | الوصف |
| --- | --- |
| ItemReceived | يتم إطلاق هذا الحدث عند استلام صنف |
| ItemIssued | يتم إطلاق هذا الحدث عند صرف صنف |
| StockLevelChanged | يتم إطلاق هذا الحدث عند تغير مستوى المخزون |
| StockReserved | يتم إطلاق هذا الحدث عند حجز مخزون |
| StockReleased | يتم إطلاق هذا الحدث عند إلغاء حجز مخزون |
| StockTransferred | يتم إطلاق هذا الحدث عند نقل مخزون |
| StockAdjusted | يتم إطلاق هذا الحدث عند تسوية مخزون |
| ItemExpired | يتم إطلاق هذا الحدث عند انتهاء صلاحية صنف |
| PriceChanged | يتم إطلاق هذا الحدث عند تغيير سعر الصنف |

### فئة sales
| الحدث | الوصف |
| --- | --- |
| OrderPlaced | يتم إطلاق هذا الحدث عند إنشاء طلب |
| OrderConfirmed | يتم إطلاق هذا الحدث عند تأكيد طلب |
| OrderShipped | يتم إطلاق هذا الحدث عند شحن طلب |
| OrderDelivered | يتم إطلاق هذا الحدث عند توصيل طلب |
| OrderReturned | يتم إطلاق هذا الحدث عند إرجاع طلب |
| QuotationIssued | يتم إطلاق هذا الحدث عند إصدار عرض سعر |
| QuotationAccepted | يتم إطلاق هذا الحدث عند قبول عرض سعر |
| DiscountApplied | يتم إطلاق هذا الحدث عند تطبيق خصم |

### فئة hr
| الحدث | الوصف |
| --- | --- |
| EmployeeHired | يتم إطلاق هذا الحدث عند توظيف موظف |
| EmployeeTerminated | يتم إطلاق هذا الحدث عند إنهاء خدمة موظف |
| SalaryChanged | يتم إطلاق هذا الحدث عند تغيير راتب |
| LeaveRequested | يتم إطلاق هذا الحدث عند طلب إجازة |
| LeaveApproved | يتم إطلاق هذا الحدث عند الموافقة على إجازة |
| AttendanceRecorded | يتم إطلاق هذا الحدث عند تسجيل حضور |
| PerformanceReviewed | يتم إطلاق هذا الحدث عند تقييم أداء |
| ContractRenewed | يتم إطلاق هذا الحدث عند تجديد عقد |

### فئة service
| الحدث | الوصف |
| --- | --- |
| ServiceRequested | يتم إطلاق هذا الحدث عند طلب خدمة |
| ServiceScheduled | يتم إطلاق هذا الحدث عند جدولة خدمة |
| ServiceCompleted | يتم إطلاق هذا الحدث عند إكمال خدمة |
| MaintenanceScheduled | يتم إطلاق هذا الحدث عند جدولة صيانة |
| MaintenancePerformed | يتم إطلاق هذا الحدث عند إجراء صيانة |
| WarrantyIssued | يتم إطلاق هذا الحدث عند إصدار ضمان |
| WarrantyClaimed | يتم إطلاق هذا الحدث عند المطالبة بالضمان |

### فئة security
| الحدث | الوصف |
| --- | --- |
| AccessGranted | يتم إطلاق هذا الحدث عند منح صلاحية الوصول |
| AccessRevoked | يتم إطلاق هذا الحدث عند سحب صلاحية الوصول |
| PermissionChanged | يتم إطلاق هذا الحدث عند تغيير الصلاحيات |
| PasswordChanged | يتم إطلاق هذا الحدث عند تغيير كلمة المرور |
| UserLoggedIn | يتم إطلاق هذا الحدث عند تسجيل دخول المستخدم |
| UserLoggedOut | يتم إطلاق هذا الحدث عند تسجيل خروج المستخدم |

### فئة relationship
| الحدث | الوصف |
| --- | --- |
| EntityLinked | يتم إطلاق هذا الحدث عند ربط الكيان بكيان آخر |
| EntityUnlinked | يتم إطلاق هذا الحدث عند فك ارتباط الكيان بكيان آخر |
| AssociationCreated | يتم إطلاق هذا الحدث عند إنشاء علاقة ارتباط |
| AssociationRemoved | يتم إطلاق هذا الحدث عند إزالة علاقة ارتباط |

## فئات الأحداث حسب الوحدات (Modules)
| الوحدة | فئات الأحداث |
| --- | --- |
| Core System | lifecycle, status, approval, security, relationship, validation |
| Activities | lifecycle, status, relationship |
| Users & Permissions | lifecycle, status, security, relationship |
| General Ledger | lifecycle, status, accounting, approval, financial, validation |
| Fixed Assets | lifecycle, status, financial, approval |
| Finance & Accounting | lifecycle, status, financial, accounting, approval, validation |
| Sales & Customers | lifecycle, status, financial, sales, approval, validation |
| Purchasing & Vendors | lifecycle, status, financial, approval, validation |
| Inventory & Warehousing | lifecycle, status, inventory, approval, validation |
| Production & Manufacturing | lifecycle, status, inventory, approval, validation |
| Services & Maintenance | lifecycle, status, service, approval, validation |
| Human Resources | lifecycle, status, hr, approval, validation |
| Attendance | lifecycle, status, hr, validation |
| Insurance & Claims | lifecycle, status, financial, approval, validation |
| Guarantees & Warranties | lifecycle, status, service, approval, validation |
| Stations & Fuel | lifecycle, status, inventory, financial, approval, validation |
| Transportation & Shipping | lifecycle, status, service, approval, validation |
| Doctors & Patients | lifecycle, status, service, validation |
| Articles & Content | lifecycle, status, security |
| Archiving & Documents | lifecycle, status, security |
| Tracking & Monitoring | lifecycle, status, security |
| Projects & Regions | lifecycle, status, financial, approval, validation |
| Messages & Notifications | lifecycle, status, security |
| Forms & Surveys | lifecycle, status, approval, validation |
| Settings & Parameters | lifecycle, status, security |
| Replication & Duplication | lifecycle, status, security |
| Judicial & Legal | lifecycle, status, approval, validation |
| Tax & Fees | lifecycle, status, financial, approval, validation |
| Web Services & Interfaces | lifecycle, status, security |
| Temporary Tables | lifecycle |

## أمثلة توليد أحداث لبعض الكيانات

### أحداث كيان Customer
**الوحدة:** Sales & Customers

**الأحداث المقترحة:**
- **Created**: يتم إطلاق هذا الحدث عند إنشاء كيان جديد (فئة: lifecycle)
- **Updated**: يتم إطلاق هذا الحدث عند تحديث بيانات الكيان (فئة: lifecycle)
- **Deleted**: يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي) (فئة: lifecycle)
- **Archived**: يتم إطلاق هذا الحدث عند أرشفة الكيان (فئة: lifecycle)
- **StatusChanged**: يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية (فئة: status)
- **Activated**: يتم إطلاق هذا الحدث عند تفعيل الكيان (فئة: status)
- **Deactivated**: يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان (فئة: status)
- **Locked**: يتم إطلاق هذا الحدث عند قفل الكيان (فئة: status)
- **Unlocked**: يتم إطلاق هذا الحدث عند إلغاء قفل الكيان (فئة: status)
- **PaymentReceived**: يتم إطلاق هذا الحدث عند استلام دفعة (فئة: financial)
- **PaymentIssued**: يتم إطلاق هذا الحدث عند إصدار دفعة (فئة: financial)
- **InvoiceIssued**: يتم إطلاق هذا الحدث عند إصدار فاتورة (فئة: financial)
- **BalanceChanged**: يتم إطلاق هذا الحدث عند تغير الرصيد (فئة: financial)
- **CreditLimitChanged**: يتم إطلاق هذا الحدث عند تغيير حد الائتمان (فئة: financial)
- **TaxCalculated**: يتم إطلاق هذا الحدث عند احتساب الضريبة (فئة: financial)
- **OrderPlaced**: يتم إطلاق هذا الحدث عند إنشاء طلب (فئة: sales)
- **OrderConfirmed**: يتم إطلاق هذا الحدث عند تأكيد طلب (فئة: sales)
- **OrderShipped**: يتم إطلاق هذا الحدث عند شحن طلب (فئة: sales)
- **OrderDelivered**: يتم إطلاق هذا الحدث عند توصيل طلب (فئة: sales)
- **OrderReturned**: يتم إطلاق هذا الحدث عند إرجاع طلب (فئة: sales)
- **QuotationIssued**: يتم إطلاق هذا الحدث عند إصدار عرض سعر (فئة: sales)
- **QuotationAccepted**: يتم إطلاق هذا الحدث عند قبول عرض سعر (فئة: sales)
- **DiscountApplied**: يتم إطلاق هذا الحدث عند تطبيق خصم (فئة: sales)
- **Approved**: يتم إطلاق هذا الحدث عند الموافقة على الكيان (فئة: approval)
- **Rejected**: يتم إطلاق هذا الحدث عند رفض الكيان (فئة: approval)
- **Submitted**: يتم إطلاق هذا الحدث عند تقديم الكيان للموافقة (فئة: approval)
- **Returned**: يتم إطلاق هذا الحدث عند إرجاع الكيان بعد المراجعة (فئة: approval)
- **Validated**: يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان (فئة: validation)
- **ValidationFailed**: يتم إطلاق هذا الحدث عند فشل التحقق من الكيان (فئة: validation)

**مثال على فئة الحدث CustomerCreatedEvent:**
```csharp
using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إنشاء كيان جديد
    /// </summary>
    public class CustomerCreatedEvent : DomainEventBase
    {
        public CustomerId CustomerId { get; }
        
        public CustomerCreatedEvent(CustomerId customerId)
        {
            CustomerId = customerId;
        }
    }
}
```

**مثال على طريقة إثارة الحدث في كيان Customer:**
```csharp

    /// <summary>
    /// يتم إطلاق هذا الحدث عند فشل التحقق من الكيان
    /// </summary>
    public void Create()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerCreatedEvent(Id));
    }
```

### أحداث كيان Employee
**الوحدة:** Human Resources

**الأحداث المقترحة:**
- **Created**: يتم إطلاق هذا الحدث عند إنشاء كيان جديد (فئة: lifecycle)
- **Updated**: يتم إطلاق هذا الحدث عند تحديث بيانات الكيان (فئة: lifecycle)
- **Deleted**: يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي) (فئة: lifecycle)
- **Archived**: يتم إطلاق هذا الحدث عند أرشفة الكيان (فئة: lifecycle)
- **StatusChanged**: يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية (فئة: status)
- **Activated**: يتم إطلاق هذا الحدث عند تفعيل الكيان (فئة: status)
- **Deactivated**: يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان (فئة: status)
- **Locked**: يتم إطلاق هذا الحدث عند قفل الكيان (فئة: status)
- **Unlocked**: يتم إطلاق هذا الحدث عند إلغاء قفل الكيان (فئة: status)
- **EmployeeHired**: يتم إطلاق هذا الحدث عند توظيف موظف (فئة: hr)
- **EmployeeTerminated**: يتم إطلاق هذا الحدث عند إنهاء خدمة موظف (فئة: hr)
- **SalaryChanged**: يتم إطلاق هذا الحدث عند تغيير راتب (فئة: hr)
- **LeaveRequested**: يتم إطلاق هذا الحدث عند طلب إجازة (فئة: hr)
- **LeaveApproved**: يتم إطلاق هذا الحدث عند الموافقة على إجازة (فئة: hr)
- **AttendanceRecorded**: يتم إطلاق هذا الحدث عند تسجيل حضور (فئة: hr)
- **PerformanceReviewed**: يتم إطلاق هذا الحدث عند تقييم أداء (فئة: hr)
- **ContractRenewed**: يتم إطلاق هذا الحدث عند تجديد عقد (فئة: hr)
- **Approved**: يتم إطلاق هذا الحدث عند الموافقة على الكيان (فئة: approval)
- **Rejected**: يتم إطلاق هذا الحدث عند رفض الكيان (فئة: approval)
- **Submitted**: يتم إطلاق هذا الحدث عند تقديم الكيان للموافقة (فئة: approval)
- **Returned**: يتم إطلاق هذا الحدث عند إرجاع الكيان بعد المراجعة (فئة: approval)
- **Validated**: يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان (فئة: validation)
- **ValidationFailed**: يتم إطلاق هذا الحدث عند فشل التحقق من الكيان (فئة: validation)

**مثال على فئة الحدث EmployeeCreatedEvent:**
```csharp
using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Human Resources.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إنشاء كيان جديد
    /// </summary>
    public class EmployeeCreatedEvent : DomainEventBase
    {
        public EmployeeId EmployeeId { get; }
        
        public EmployeeCreatedEvent(EmployeeId employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}
```

**مثال على طريقة إثارة الحدث في كيان Employee:**
```csharp

    /// <summary>
    /// يتم إطلاق هذا الحدث عند فشل التحقق من الكيان
    /// </summary>
    public void Create()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new EmployeeCreatedEvent(Id));
    }
```

### أحداث كيان User
**الوحدة:** Users & Permissions

**الأحداث المقترحة:**
- **Created**: يتم إطلاق هذا الحدث عند إنشاء كيان جديد (فئة: lifecycle)
- **Updated**: يتم إطلاق هذا الحدث عند تحديث بيانات الكيان (فئة: lifecycle)
- **Deleted**: يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي) (فئة: lifecycle)
- **Archived**: يتم إطلاق هذا الحدث عند أرشفة الكيان (فئة: lifecycle)
- **StatusChanged**: يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية (فئة: status)
- **Activated**: يتم إطلاق هذا الحدث عند تفعيل الكيان (فئة: status)
- **Deactivated**: يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان (فئة: status)
- **Locked**: يتم إطلاق هذا الحدث عند قفل الكيان (فئة: status)
- **Unlocked**: يتم إطلاق هذا الحدث عند إلغاء قفل الكيان (فئة: status)
- **AccessGranted**: يتم إطلاق هذا الحدث عند منح صلاحية الوصول (فئة: security)
- **AccessRevoked**: يتم إطلاق هذا الحدث عند سحب صلاحية الوصول (فئة: security)
- **PermissionChanged**: يتم إطلاق هذا الحدث عند تغيير الصلاحيات (فئة: security)
- **PasswordChanged**: يتم إطلاق هذا الحدث عند تغيير كلمة المرور (فئة: security)
- **UserLoggedIn**: يتم إطلاق هذا الحدث عند تسجيل دخول المستخدم (فئة: security)
- **UserLoggedOut**: يتم إطلاق هذا الحدث عند تسجيل خروج المستخدم (فئة: security)
- **EntityLinked**: يتم إطلاق هذا الحدث عند ربط الكيان بكيان آخر (فئة: relationship)
- **EntityUnlinked**: يتم إطلاق هذا الحدث عند فك ارتباط الكيان بكيان آخر (فئة: relationship)
- **AssociationCreated**: يتم إطلاق هذا الحدث عند إنشاء علاقة ارتباط (فئة: relationship)
- **AssociationRemoved**: يتم إطلاق هذا الحدث عند إزالة علاقة ارتباط (فئة: relationship)

**مثال على فئة الحدث UserCreatedEvent:**
```csharp
using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Users & Permissions.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إنشاء كيان جديد
    /// </summary>
    public class UserCreatedEvent : DomainEventBase
    {
        public UserId UserId { get; }
        
        public UserCreatedEvent(UserId userId)
        {
            UserId = userId;
        }
    }
}
```

**مثال على طريقة إثارة الحدث في كيان User:**
```csharp

    /// <summary>
    /// يتم إطلاق هذا الحدث عند إزالة علاقة ارتباط
    /// </summary>
    public void Create()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new UserCreatedEvent(Id));
    }
```

## إرشادات التنفيذ

1. **إنشاء الأحداث المناسبة**: لكل كيان، حدد الأحداث المناسبة من الفئات أعلاه حسب طبيعة الكيان ووحدته.
2. **إنشاء فئات الأحداث**: أنشئ فئة C# لكل حدث تحتوي على البيانات اللازمة لفهم ما حدث.
3. **إضافة طرق عمل في الكيان**: أضف طرق تنفيذ في الكيان تقوم بإثارة الأحداث المناسبة عند حدوث تغييرات.
4. **استخدام الأحداث في تنفيذ الأعمال**: ربط معالجات الأحداث في طبقة التطبيق لتنفيذ الإجراءات اللازمة.
5. **توثيق الأحداث بدقة**: وثق كل حدث وشرح متى وكيف يتم إثارته.

### ملاحظات هامة
- **حافظ على تماسك الأحداث**: تأكد من أن كل حدث يمثل تغييرًا مهمًا وذا مغزى في حالة الكيان.
- **ضمّن البيانات الكافية**: تأكد من أن كل حدث يحتوي على معلومات كافية لفهم ماذا حدث.
- **حافظ على البساطة**: تجنب الأحداث المعقدة جدًا، فقد تشير إلى الحاجة لتقسيم المسؤوليات.
- **استخدم صيغة الماضي**: سمّ الأحداث بأفعال في صيغة الماضي (مثل: Created, Updated).
- **لا تستخدم الأحداث للاستعلامات**: استخدم الأحداث للإشعار عن تغييرات، وليس كآلية استعلام.
