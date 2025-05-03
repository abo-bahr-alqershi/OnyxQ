namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد حالة المستند في النظام
/// Represents the document status in the system
/// </summary>
public enum DocumentStatus
{
    /// <summary>
    /// نشط
    /// Active
    /// </summary>
    Active = 1,

    /// <summary>
    /// منتهي
    /// Expired
    /// </summary>
    Expired = 2,

    /// <summary>
    /// قيد التجديد
    /// Under Renewal
    /// </summary>
    UnderRenewal = 3,

    /// <summary>
    /// ملغي
    /// Cancelled
    /// </summary>
    Cancelled = 4,

    /// <summary>
    /// معلق
    /// Suspended
    /// </summary>
    Suspended = 5,

    /// <summary>
    /// مؤرشف
    /// Archived
    /// </summary>
    Archived = 6
} 