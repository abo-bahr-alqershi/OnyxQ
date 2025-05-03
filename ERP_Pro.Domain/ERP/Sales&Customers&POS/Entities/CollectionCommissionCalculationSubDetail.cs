/**
 * @class CollectionCommissionCalculationSubDetail
 * @description كلاس تفاصيل حساب عمولات التحصيل الفرعية المستخدم في تخزين وإدارة تفاصيل حساب العمولات للمحصلين
 * @author OnyxQ Team
 */
public class CollectionCommissionCalculationSubDetail
{
    /// <summary>
    /// رقم التحصيل
    /// </summary>
    public long CollectionNumber { get; private set; }

    /// <summary>
    /// رمز العميل
    /// </summary>
    public string CustomerCode { get; private set; }

    /// <summary>
    /// نوع العمولة
    /// </summary>
    public int CommissionType { get; private set; }

    /// <summary>
    /// نسبة العمولة
    /// </summary>
    public decimal CommissionPercentage { get; private set; }

    /// <summary>
    /// مبلغ العمولة
    /// </summary>
    public decimal CommissionAmount { get; private set; }

    /// <summary>
    /// تاريخ التحصيل
    /// </summary>
    public DateTime CollectionDate { get; private set; }

    /// <summary>
    /// رمز المندوب
    /// </summary>
    public string? RepresentativeCode { get; private set; }

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