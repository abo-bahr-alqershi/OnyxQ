namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد حالة الشركة في النظام
/// Represents the company status in the system
/// </summary>
public enum CompanyStatus
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
    /// تحت التصفية
    /// Under Liquidation
    /// </summary>
    UnderLiquidation = 5,

    /// <summary>
    /// مدمج
    /// Merged
    /// </summary>
    Merged = 6
} 