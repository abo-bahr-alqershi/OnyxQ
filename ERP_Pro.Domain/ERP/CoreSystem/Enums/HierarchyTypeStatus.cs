namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// حالات نوع التسلسل الهرمي
/// Hierarchy type statuses
/// </summary>
public enum HierarchyTypeStatus
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
    /// محذوف
    /// Deleted
    /// </summary>
    Deleted = 4,

    /// <summary>
    /// مؤرشف
    /// Archived
    /// </summary>
    Archived = 5,

    /// <summary>
    /// قيد التطوير
    /// Under Development
    /// </summary>
    UnderDevelopment = 6
} 