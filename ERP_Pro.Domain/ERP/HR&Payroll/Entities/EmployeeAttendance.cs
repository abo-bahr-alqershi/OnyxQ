public class EmployeeAttendance
{
    /// <summary>الرقم الوظيفي للموظف</summary>
    public string EmployeeNumber { get; private set; }
    /// <summary>تاريخ الحضور</summary>
    public DateTime AttendanceDate { get; private set; }
    /// <summary>وقت الدخول</summary>
    public TimeSpan? CheckInTime { get; private set; }
    /// <summary>وقت الخروج</summary>
    public TimeSpan? CheckOutTime { get; private set; }
    /// <summary>نوع الحضور (عادي/إجازة/غياب)</summary>
    public string? AttendanceType { get; private set; }
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
}