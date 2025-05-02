public class GlsAccntDtlCurr
{
    /// <summary>رمز الحساب التفصيلي</summary>
    public string? AccountDetailCode { get; private set; }
    /// <summary>نوع الحساب التفصيلي</summary>
    public int? AccountDetailType { get; private set; }
    /// <summary>رمز العملة</summary>
    public string? CurrencyCode { get; private set; }
    /// <summary>هل الحساب غير نشط</summary>
    public bool? Inactive { get; private set; }
    /// <summary>سبب التعطيل</summary>
    public string? InactiveReason { get; private set; }
    /// <summary>تاريخ التعطيل</summary>
    public DateTime? InactiveDate { get; private set; }
    /// <summary>رقم المستخدم الذي عطل الحساب</summary>
    public int? InactiveUserId { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>هل تم استخدام الحساب</summary>
    public bool? Used { get; private set; }
}