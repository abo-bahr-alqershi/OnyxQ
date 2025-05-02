public class EmployeeBank
{
    /// <summary>الرقم الوظيفي للموظف</summary>
    public string EmployeeNumber { get; private set; }
    /// <summary>اسم البنك</summary>
    public string BankName { get; private set; }
    /// <summary>رقم الحساب البنكي</summary>
    public string BankAccountNumber { get; private set; }
    /// <summary>اسم صاحب الحساب</summary>
    public string AccountHolderName { get; private set; }
    /// <summary>رمز البنك (اختياري)</summary>
    public string? BankCode { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ الإضافة</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>أولوية التقرير</summary>
    public long? ReportPriority { get; private set; }
    public Employee Employee { get; private set; } // Navigation
}