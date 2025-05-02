public class IasAccntDtlMsg
{
    /// <summary>رمز الحساب التفصيلي</summary>
    public string? AccountDetailCode { get; private set; }
    /// <summary>رقم الجوال</summary>
    public string? MobileNumber { get; private set; }
    /// <summary>البريد الإلكتروني</summary>
    public string? Email { get; private set; }
    /// <summary>نوع الحركة</summary>
    public bool? MovementType { get; private set; }
    /// <summary>نوع التحويل</summary>
    public bool? TransferType { get; private set; }
    /// <summary>نوع الإرسال</summary>
    public bool? SendType { get; private set; }
    /// <summary>نوع الترحيل</summary>
    public bool? PostType { get; private set; }
    /// <summary>رصيد الحساب</summary>
    public int? BalanceAmount { get; private set; }
    /// <summary>هل الحساب غير نشط</summary>
    public bool? Inactive { get; private set; }
    /// <summary>تاريخ التعطيل</summary>
    public DateTime? InactiveDate { get; private set; }
    /// <summary>رقم المستخدم الذي عطل الحساب</summary>
    public int? InactiveUserNumber { get; private set; }
    /// <summary>سبب التعطيل</summary>
    public string? InactiveReason { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminalName { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminalName { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>رقم تقرير الطباعة</summary>
    public long? PrintReport { get; private set; }
    /// <summary>نوع الحساب التفصيلي</summary>
    public short? AccountDetailType { get; private set; }
    /// <summary>رقم لغة الإرسال</summary>
    public short? SendLanguageNumber { get; private set; }
}