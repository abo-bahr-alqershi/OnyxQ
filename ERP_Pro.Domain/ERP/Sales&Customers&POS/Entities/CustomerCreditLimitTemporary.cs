/**
 * @class CustomerCreditLimitTemporary
 * @description كلاس حد الائتمان المؤقت للعملاء المستخدم في تخزين وإدارة حدود الائتمان المؤقتة للعملاء وتتبع تغيراتها
 * @author OnyxQ Team
 */
public class CustomerCreditLimitTemporary
{
    /// <summary>
    /// رمز العميل
    /// </summary>
    public string? CustomerCode { get; private set; }

    /// <summary>
    /// حد الائتمان المؤقت
    /// </summary>
    public decimal? TemporaryCreditLimit { get; private set; }

    /// <summary>
    /// تاريخ بداية الصلاحية
    /// </summary>
    public DateTime? ValidFromDate { get; private set; }

    /// <summary>
    /// تاريخ نهاية الصلاحية
    /// </summary>
    public DateTime? ValidToDate { get; private set; }

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