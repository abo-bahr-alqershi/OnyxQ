/**
 * @class CompanyTemporarySettings
 * @description كلاس الإعدادات المؤقتة للشركة المستخدم في تخزين وإدارة الإعدادات والتفضيلات المؤقتة للشركة
 * @author OnyxQ Team
 */
public class CompanyTemporarySettings
{
    /// <summary>
    /// رقم الشركة
    /// </summary>
    public short CompanyNumber { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public int BranchNumber { get; private set; }

    /// <summary>
    /// السنة المالية
    /// </summary>
    public short FiscalYear { get; private set; }

    /// <summary>
    /// رمز العملة
    /// </summary>
    public string? CurrencyCode { get; private set; }

    /// <summary>
    /// رمز الحساب
    /// </summary>
    public string? AccountCode { get; private set; }

    /// <summary>
    /// رمز مركز التكلفة
    /// </summary>
    public string? CostCenterCode { get; private set; }

    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string? ProjectNumber { get; private set; }

    /// <summary>
    /// رقم النشاط
    /// </summary>
    public string? ActivityNumber { get; private set; }

    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AddUserId { get; private set; }

    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime? AddDate { get; private set; }

    /// <summary>
    /// معرف مستخدم التحديث
    /// </summary>
    public int? UpdateUserId { get; private set; }

    /// <summary>
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdateDate { get; private set; }
}