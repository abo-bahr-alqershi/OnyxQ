public class EmployeeFamily
{
    /// <summary>الرقم الوظيفي للموظف</summary>
    public string EmployeeNumber { get; private set; }
    /// <summary>اسم فرد العائلة</summary>
    public string FamilyMemberName { get; private set; }
    /// <summary>صلة القرابة</summary>
    public string Relationship { get; private set; }
    /// <summary>تاريخ الميلاد</summary>
    public DateTime? BirthDate { get; private set; }
    /// <summary>الجنسية</summary>
    public string? Nationality { get; private set; }
    /// <summary>رقم الهوية</summary>
    public string? NationalId { get; private set; }
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
    public Employee Employee { get; private set; } // Navigation
}