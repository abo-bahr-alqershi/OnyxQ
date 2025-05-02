public class InsuranceCompanyClass
{
    /// <summary>رقم شركة التأمين</summary>
    public long? InsuranceCompanyNumber { get; private set; }
    /// <summary>رقم التصنيف</summary>
    public string? ClassNumber { get; private set; }
    /// <summary>اسم التصنيف (طويل)</summary>
    public string? ClassLongName { get; private set; }
    /// <summary>اسم التصنيف (قصير)</summary>
    public string? ClassShortName { get; private set; }
    /// <summary>هل التصنيف غير نشط</summary>
    public bool? Inactive { get; private set; }
    /// <summary>تاريخ التعطيل</summary>
    public DateTime? InactiveDate { get; private set; }
    /// <summary>سبب التعطيل</summary>
    public string? InactiveReason { get; private set; }
    /// <summary>رقم المستخدم الذي عطل التصنيف</summary>
    public int? InactiveUserId { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السطر</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ الإضافة</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدل السطر</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التحديث</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>رقم المستفيد</summary>
    public int? BeneficiaryNumber { get; private set; }
    /// <summary>نسبة الخصم</summary>
    public int? DiscountPercent { get; private set; }
    /// <summary>تاريخ بداية العقد</summary>
    public DateTime? ContractStartDate { get; private set; }
    /// <summary>تاريخ نهاية العقد</summary>
    public DateTime? ContractEndDate { get; private set; }
    /// <summary>حد التحديث المسموح به</summary>
    public int? AllowedUpdateLoadPercentLimit { get; private set; }
}