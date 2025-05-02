public class CashCustomerGroup
{
    /// <summary>كود مجموعة العملاء النقديين</summary>
    public int? CustomerGroupCode { get; private set; }
    /// <summary>اسم المجموعة (طويل)</summary>
    public string? CustomerGroupLongName { get; private set; }
    /// <summary>اسم المجموعة (قصير)</summary>
    public string? CustomerGroupShortName { get; private set; }
    /// <summary>هل يتم إرسال رسالة عند التعامل مع هذه المجموعة</summary>
    public bool? SendMessage { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السطر</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ الإضافة</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدل السطر</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>رقم التقرير المرتبط</summary>
    public int? ReportNumber { get; private set; }
    /// <summary>عدد مرات التحديث</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminal { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminal { get; private set; }
}