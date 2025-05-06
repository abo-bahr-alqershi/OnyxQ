# معمارية طبقة المجال (Domain Layer) في نظام ERP Pro

## نظرة عامة

طبقة المجال (Domain Layer) هي قلب النظام وتحتوي على جميع نماذج المجال (Domain Models) والقواعد التجارية (Business Rules) للنظام. تُبنى هذه الطبقة وفقًا لمبادئ التصميم المُوجَّه بالمجال (Domain-Driven Design - DDD) وتمثل بنية العمل الأساسية للنظام بأكمله.

## هيكل الطبقة

```
ERP_Pro.Domain/
├── Common/                  # العناصر المشتركة بين جميع الوحدات
│   ├── AuditableEntity.cs   # كيان أساسي قابل للتدقيق
│   ├── BaseEntity.cs        # الكيان الأساسي لجميع الكيانات
│   ├── IAggregateRoot.cs    # واجهة للكيانات الجذرية
│   ├── IEntity.cs           # واجهة للكيانات
│   ├── ValueObject.cs       # كائن القيمة الأساسي
│   └── DomainEvent.cs       # حدث المجال الأساسي
├── FinanceAccounting/       # وحدة المحاسبة والمالية
│   ├── Account.cs           # كيان الحساب
│   ├── AccountType.cs       # كيان نوع الحساب
│   ├── Currency.cs          # كيان العملة
│   ├── JournalEntry.cs      # كيان القيد اليومية
│   ├── Events/              # أحداث المجال الخاصة بالوحدة المالية
│   ├── Interfaces/          # واجهات المستودعات
│   └── ValueObjects/        # كائنات القيمة
├── InventoryWarehousing/    # وحدة المخزون والمستودعات
│   ├── Item.cs              # كيان الصنف
│   ├── ItemCategory.cs      # كيان فئة الصنف
│   ├── Warehouse.cs         # كيان المستودع
│   ├── InventoryTransaction.cs # كيان حركة المخزون
│   ├── Events/              # أحداث المجال الخاصة بالمخزون
│   ├── Interfaces/          # واجهات المستودعات
│   └── ValueObjects/        # كائنات القيمة
└── Modules/                 # وحدات أخرى في النظام
    ├── HumanResources/      # وحدة الموارد البشرية
    ├── Sales/               # وحدة المبيعات
    ├── Purchasing/          # وحدة المشتريات
    ├── Production/          # وحدة الإنتاج
    └── Projects/            # وحدة المشاريع
```

## الأنماط المستخدمة

### 1. الكيانات الجذرية (Aggregate Roots)

الكيانات الجذرية هي المدخل الرئيسي للتفاعل مع مجموعة من الكيانات المترابطة. وهي تضمن تطبيق قواعد التجارية المتسقة على مجموعة الكيانات.

مثال:

```csharp
public class Account : AuditableEntity, IAggregateRoot
{
    public string AccountNumber { get; private set; }
    public string Name { get; private set; }
    public AccountType Type { get; private set; }
    public bool IsActive { get; private set; }
    public ICollection<JournalEntryDetail> Entries { get; private set; }
    
    // بقية التفاصيل...
}
```

### 2. كائنات القيمة (Value Objects)

كائنات القيمة هي كائنات بدون هوية وتعرَّف بمحتواها. يُستخدم لتمثيل المفاهيم في المجال.

مثال:

```csharp
public class Money : ValueObject
{
    public decimal Amount { get; }
    public string CurrencyCode { get; }
    
    public Money(decimal amount, string currencyCode)
    {
        Amount = amount;
        CurrencyCode = currencyCode;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return CurrencyCode;
    }
}
```

### 3. أحداث المجال (Domain Events)

تُستخدم أحداث المجال للتعبير عن أمر مهم في المجال، ويمكن استخدامها لتحقيق انفصال بين أجزاء النظام.

مثال:

```csharp
public class AccountCreatedEvent : DomainEvent
{
    public Account Account { get; }
    
    public AccountCreatedEvent(Account account)
    {
        Account = account;
    }
}
```

## القواعد والإرشادات

### 1. تصميم الكيانات

- جميع الخصائص يجب أن تكون `private set` لضمان التحكم في التغييرات
- يجب تطبيق قواعد التحقق في البناء (Constructor) أو في أساليب التحديث
- يجب إطلاق أحداث المجال عند تغييرات مهمة في الكيان
- تجنب المُنشئين العامة الفارغة (إلا إذا كانت مطلوبة للـ ORM)
- الكيانات المرتبطة ببعضها بقوة يجب أن تكون في نفس الكيان الجذري (Aggregate)

### 2. تصميم القيم

- كائنات القيمة يجب أن تكون غير قابلة للتغيير (Immutable)
- يجب تنفيذ `GetEqualityComponents` لتوفير تحقق المساواة
- استخدم كائنات القيمة لتمثيل المفاهيم مثل المال، العنوان، رقم الهاتف، إلخ

### 3. واجهات المستودع

- يجب تعريف واجهات المستودع في طبقة المجال
- لكل كيان جذري، يجب أن يكون هناك واجهة مستودع خاصة به
- يجب تعريف طرق الاستعلام الشائعة في واجهة المستودع

### 4. التعاملات بين الكيانات الجذرية

- لا يجب الوصول المباشر من كيان جذري إلى آخر
- استخدم المراجع بالهوية (Identity Reference) بدلاً من الإشارة المباشرة
- استخدم خدمة المجال (Domain Service) للتعامل مع عمليات تشمل كيانات جذرية متعددة

## خطوات إضافة كيان جديد

1. تحديد المجال الفرعي (Subdomain) الذي ينتمي إليه الكيان
2. تحديد ما إذا كان الكيان هو كيان جذري (Aggregate Root) أم كيان عادي أم كائن قيمة
3. تحديد الخصائص والسلوكيات للكيان
4. تنفيذ الكيان مع التحقق من الصحة وقواعد العمل
5. تعريف أحداث المجال المرتبطة بالكيان إذا لزم الأمر
6. تعريف واجهة المستودع للكيان الجذري

## تحديد العلاقات بين الكيانات

### 1. علاقة 1:1

```csharp
public class Employee : AuditableEntity, IAggregateRoot
{
    // خصائص الموظف
    public EmployeeDetails Details { get; private set; }
}

public class EmployeeDetails : Entity
{
    // خصائص تفاصيل الموظف
    public int EmployeeId { get; private set; }
    public Employee Employee { get; private set; }
}
```

### 2. علاقة 1:n

```csharp
public class Customer : AuditableEntity, IAggregateRoot
{
    // خصائص العميل
    public ICollection<Address> Addresses { get; private set; }
}

public class Address : Entity
{
    // خصائص العنوان
    public int CustomerId { get; private set; }
}
```

### 3. علاقة n:n

```csharp
// علاقة بين العميل والصنف من خلال كيان وسيط
public class CustomerPreferredItem : Entity
{
    public int CustomerId { get; private set; }
    public int ItemId { get; private set; }
    
    public Customer Customer { get; private set; }
    public Item Item { get; private set; }
}
```

## أمثلة لنماذج المجال الشائعة

### 1. كيان العملة (Currency)

```csharp
public class Currency : AuditableEntity, IAggregateRoot
{
    public string Code { get; private set; }
    public string NameAr { get; private set; }
    public string NameEn { get; private set; }
    public decimal ExchangeRate { get; private set; }
    public bool IsBaseCurrency { get; private set; }
    public string Symbol { get; private set; }
    public bool IsActive { get; private set; }
    
    // يتبع بقية التفاصيل...
}
```

### 2. كيان الصنف (Item)

```csharp
public class Item : AuditableEntity, IAggregateRoot
{
    public string Code { get; private set; }
    public string NameAr { get; private set; }
    public string NameEn { get; private set; }
    public ItemType Type { get; private set; }
    public int CategoryId { get; private set; }
    public ItemCategory Category { get; private set; }
    public bool IsActive { get; private set; }
    public string Barcode { get; private set; }
    public ICollection<ItemUnit> Units { get; private set; }
    
    // يتبع بقية التفاصيل...
}
```

### 3. كيان الفاتورة (Invoice)

```csharp
public class Invoice : AuditableEntity, IAggregateRoot
{
    public string Number { get; private set; }
    public DateTime Date { get; private set; }
    public int CustomerId { get; private set; }
    public InvoiceStatus Status { get; private set; }
    public Money TotalAmount { get; private set; }
    public ICollection<InvoiceItem> Items { get; private set; }
    
    // يتبع بقية التفاصيل...
}
```

## ملاحظات هامة

- لا تستخدم المكتبات أو التبعيات الخارجية غير الضرورية في طبقة المجال
- حافظ على بساطة الكيانات وتركيزها على المسؤوليات المحددة
- تأكد من إخفاء التفاصيل الداخلية واستخدام واجهات عامة محددة جيدًا
- استخدم الكائنات غير القابلة للتغيير (Immutable) حيثما أمكن
- استخدم الأنماط المناسبة (Design Patterns) لحل المشكلات المتكررة 