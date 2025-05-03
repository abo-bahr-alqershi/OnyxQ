namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد حالة الصلاحية في النظام
/// Represents the privilege status in the system
/// </summary>
public enum PrivilegeStatus
{
    /// <summary>
    /// نشط
    /// Active
    /// </summary>
    Active = 1,

    /// <summary>
    /// معلق
    /// Suspended
    /// </summary>
    Suspended = 2,

    /// <summary>
    /// منتهي
    /// Expired
    /// </summary>
    Expired = 3,

    /// <summary>
    /// ملغي
    /// Cancelled
    /// </summary>
    Cancelled = 4,

    /// <summary>
    /// قيد المراجعة
    /// Under Review
    /// </summary>
    UnderReview = 5,

    /// <summary>
    /// مؤقت
    /// Temporary
    /// </summary>
    Temporary = 6
} 