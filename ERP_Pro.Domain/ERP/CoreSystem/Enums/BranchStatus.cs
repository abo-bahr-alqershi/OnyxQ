namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد حالة الفرع في النظام
/// Represents the branch status in the system
/// </summary>
public enum BranchStatus
{
    /// <summary>
    /// نشط
    /// Active
    /// </summary>
    Active = 1,

    /// <summary>
    /// غير نشط
    /// Inactive
    /// </summary>
    Inactive = 2,

    /// <summary>
    /// معلق
    /// Suspended
    /// </summary>
    Suspended = 3,

    /// <summary>
    /// مغلق
    /// Closed
    /// </summary>
    Closed = 4,

    /// <summary>
    /// تحت الصيانة
    /// Under Maintenance
    /// </summary>
    UnderMaintenance = 5,

    /// <summary>
    /// تحت الإنشاء
    /// Under Construction
    /// </summary>
    UnderConstruction = 6,

    /// <summary>
    /// مدمج
    /// Merged
    /// </summary>
    Merged = 7
} 