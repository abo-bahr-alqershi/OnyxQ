public class EmployeeGuarantor
{
    /// <summary>الرقم الوظيفي للموظف</summary>
    public string EmployeeNumber { get; private set; }
    /// <summary>اسم الكفيل</summary>
    public string GuarantorName { get; private set; }
    /// <summary>رقم الهوية الوطنية للكفيل</summary>
    public string? GuarantorNationalId { get; private set; }
    /// <summary>رقم الجوال للكفيل</summary>
    public string? GuarantorMobileNumber { get; private set; }
    /// <summary>العنوان</summary>
    public string? Address { get; private set; }
    /// <summary>ملاحظات</summary>
    public string? Notes { get; private set; }
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
    /// <summary>علم خاص بالراتب</summary>
    public bool? SalaryFlag { get; private set; }
    public Employee Employee { get; private set; } // Navigation
}