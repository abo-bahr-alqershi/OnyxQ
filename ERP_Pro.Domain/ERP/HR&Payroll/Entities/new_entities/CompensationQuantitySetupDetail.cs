/**
 * @class CompensationQuantitySetupDetail
 * @description كلاس تفاصيل إعداد كميات التعويضات المستخدم في تنظيم وإدارة إعدادات كميات التعويضات للمنتجات
 * @author OnyxQ Team
 */
public class CompensationQuantitySetupDetail
{
    /// <summary>
    /// نوع التعويض
    /// </summary>
    public int CompensationType { get; private set; }

    /// <summary>
    /// رمز المنتج
    /// </summary>
    public string ProductCode { get; private set; }

    /// <summary>
    /// وحدة المنتج
    /// </summary>
    public string ProductUnit { get; private set; }

    /// <summary>
    /// الكمية المستهدفة
    /// </summary>
    public decimal TargetQuantity { get; private set; }

    /// <summary>
    /// نسبة التعويض
    /// </summary>
    public decimal CompensationPercentage { get; private set; }

    /// <summary>
    /// رمز المستودع
    /// </summary>
    public string? WarehouseCode { get; private set; }

    /// <summary>
    /// رمز مركز التكلفة
    /// </summary>
    public string? CostCenterCode { get; private set; }

    /// <summary>
    /// مؤشر الإيقاف
    /// </summary>
    public bool IsInactive { get; private set; }

    /// <summary>
    /// سبب الإيقاف
    /// </summary>
    public string? InactiveReason { get; private set; }

    /// <summary>
    /// تاريخ الإيقاف
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

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