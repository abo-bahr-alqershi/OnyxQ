public class CustomerClass
{
    /// <summary> كود تصنيف العميل </summary>
    public short? ClassCode { get; private set; }
    /// <summary> اسم التصنيف عربي </summary>
    public string? ClassArabicName { get; private set; }
    /// <summary> اسم التصنيف إنجليزي </summary>
    public string? ClassEnglishName { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary> عدد مرات التحديث </summary>
    public long? UpdateCount { get; private set; }
    /// <summary> أولوية التقرير </summary>
    public long? ReportPriority { get; private set; }
    /// <summary> اسم الجهاز عند الإضافة </summary>
    public string? AddedTerminal { get; private set; }
    /// <summary> اسم الجهاز عند التعديل </summary>
    public string? UpdatedTerminal { get; private set; }
    public string? CustomerClassTypeName { get; private set; }
    public string? CustomerClassTypeFullName { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary> أولوية التقرير </summary>
    public int? ReportPriority { get; private set; }
    /// <summary> عدد مرات التحديث </summary>
    public long? UpdateCount { get; private set; }
    /// <summary> اسم الجهاز عند الإضافة </summary>
    public string? AddedTerminal { get; private set; }
    /// <summary> اسم الجهاز عند التعديل </summary>
    public string? UpdatedTerminal { get; private set; }
    public string? AccountCurrency { get; private set; }
    public decimal? CreditLimit { get; private set; }
    public decimal? InvoiceLimit { get; private set; }
    public int? CustomerLimitPercentage { get; private set; }
    public bool? CustomerLimitType { get; private set; }
    public short? LevelNumber { get; private set; }
    public bool? Inactive { get; private set; }
    public DateTime? ConfirmationLastDate { get; private set; }
    public short? LevelNumberCash { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary> عدد مرات التحديث </summary>
    public long? UpdateCount { get; private set; }
    public int? ExternalPost { get; private set; }
    public bool? InactiveSales { get; private set; }
    public ICollection<Customer> Customers { get; private set; } // Inverse Navigation
    public ICollection<CustomerRequest> CustomerRequests { get; private set; } // Inverse Navigation
    public ICollection<SalesDiscount> SalesDiscounts { get; private set; } // Inverse Navigation
    public ICollection<SalesFreeQty> SalesFreeQties { get; private set; } // Inverse Navigation
}

public class WarehouseBusinessInfo : ValueObject
{
    public string? ProjectNumber { get; private set; }
    public string? ActivityCode { get; private set; }
    public string? SalesOrderDescription { get; private set; }
    public int? SalesOrderType { get; private set; }
    public int? ServiceCenterNumber { get; private set; }
    public int? BankNumber { get; private set; }
    public string? ReportCode { get; private set; }
    public int? ColumnNumber { get; private set; }
    public string? CustomerCode { get; private set; }
    public int? CalculationTypeNoTax { get; private set; }
    public int? CustomerGroupCode { get; private set; }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return ProjectNumber ?? string.Empty;
        yield return ActivityCode ?? string.Empty;
        yield return SalesOrderDescription ?? string.Empty;
        yield return SalesOrderType ?? 0;
        yield return ServiceCenterNumber ?? 0;
        yield return BankNumber ?? 0;
        yield return ReportCode ?? string.Empty;
        yield return ColumnNumber ?? 0;
        yield return CustomerCode ?? string.Empty;
        yield return CalculationTypeNoTax ?? 0;
        yield return CustomerGroupCode ?? 0;
    }
}