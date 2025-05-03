/**
 * @class CollectionPlan
 * @description كلاس خطة التحصيل المستخدم في تنظيم وإدارة خطط التحصيل وأهدافها للعملاء
 * @author OnyxQ Team
 */
public class CollectionPlan
{
    /// <summary>
    /// رقم الخطة
    /// </summary>
    public long PlanNumber { get; private set; }

    /// <summary>
    /// رمز العميل
    /// </summary>
    public string CustomerCode { get; private set; }

    /// <summary>
    /// تاريخ بداية الخطة
    /// </summary>
    public DateTime StartDate { get; private set; }

    /// <summary>
    /// تاريخ نهاية الخطة
    /// </summary>
    public DateTime EndDate { get; private set; }

    /// <summary>
    /// المبلغ المستهدف
    /// </summary>
    public decimal TargetAmount { get; private set; }

    /// <summary>
    /// نسبة التحصيل المستهدفة
    /// </summary>
    public decimal TargetCollectionPercentage { get; private set; }

    /// <summary>
    /// رمز المندوب
    /// </summary>
    public string? RepresentativeCode { get; private set; }

    /// <summary>
    /// حالة الخطة
    /// </summary>
    public int PlanStatus { get; private set; }

    /// <summary>
    /// وصف الخطة
    /// </summary>
    public string? PlanDescription { get; private set; }

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