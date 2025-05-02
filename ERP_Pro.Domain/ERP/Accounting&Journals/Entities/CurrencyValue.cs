public class CurrencyValue
{
    /// <summary>رمز العملة</summary>
    public string? CurrencyCode { get; private set; }
    /// <summary>قيمة العملة</summary>
    public int? CurrencyAmount { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل على السجل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>رقم تقرير الطباعة</summary>
    public long? PrintReport { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminalName { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminalName { get; private set; }
    /// <summary>رقم الشركة</summary>
    public short? CompanyNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int? BranchNumber { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    /// <summary>رمز مركز التكلفة</summary>
    public string? CostCenterCode { get; private set; }
    /// <summary>حد الائتمان</summary>
    public decimal? CreditLimit { get; private set; }
    /// <summary>حد الفاتورة</summary>
    public decimal? InvoiceLimit { get; private set; }
    /// <summary>نسبة حد العميل</summary>
    public int? CustomerLimitPercent { get; private set; }
    /// <summary>نوع حد العميل</summary>
    public bool? CustomerLimitType { get; private set; }
    /// <summary>حد فارغ</summary>
    public int? EmptyLimit { get; private set; }
    public CurrencyExchangeRate CurrencyExchangeRate { get; private set; } // Navigation
}