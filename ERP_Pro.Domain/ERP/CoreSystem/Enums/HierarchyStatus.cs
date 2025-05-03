namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// حالات التسلسل الهرمي
/// Hierarchy statuses
/// </summary>
public enum HierarchyStatus
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
    /// مدمج
    /// Merged
    /// </summary>
    Merged = 5,

    /// <summary>
    /// مؤرشف
    /// Archived
    /// </summary>
    Archived = 6
} 