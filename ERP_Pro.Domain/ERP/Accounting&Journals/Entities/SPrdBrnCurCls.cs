public class BranchCurrencyPeriodClosing
{
    /// <summary>رقم الفترة</summary>
    public short? PeriodNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int? BranchNumber { get; private set; }
    /// <summary>رمز العملة</summary>
    public string? CurrencyCode { get; private set; }
    /// <summary>سعر العملة</summary>
    public int? CurrencyRate { get; private set; }
    /// <summary>تاريخ الفترة</summary>
    public DateTime? PeriodDate { get; private set; }
    /// <summary>سنة الفترة</summary>
    public short YearNumber { get; private set; }
    /// <summary>هل الفترة غير نشطة</summary>
    public bool? Inactive { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
}