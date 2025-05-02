public class Audit
{
    /// <summary>معرف المستخدم الذي قام بالإجراء</summary>
    public int? UserId { get; private set; }
    /// <summary>رقم النموذج أو المستند المرتبط بالتدقيق</summary>
    public int? FormNumber { get; private set; }
    /// <summary>هل تم تعديل السجل (تدقيق التعديل)</summary>
    public bool? IsModified { get; private set; }
    /// <summary>هل تم حذف السجل (تدقيق الحذف)</summary>
    public bool? IsDeleted { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل على السجل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التعديل على السجل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>اسم الجهاز الذي تم التعديل منه</summary>
    public string? UpdatedTerminalName { get; private set; }
    public User User { get; private set; } // Navigation
}