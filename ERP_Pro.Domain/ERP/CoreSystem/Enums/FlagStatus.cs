namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد حالة العلامة في النظام
/// Represents the flag status in the system
/// </summary>
public enum FlagStatus
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
    Archived = 5
} 