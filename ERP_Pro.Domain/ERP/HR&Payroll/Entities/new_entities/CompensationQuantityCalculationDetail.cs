/**
 * @class CompensationQuantityCalculationDetail
 * @description كلاس تفاصيل حساب كميات التعويضات المستخدم في تنظيم وإدارة عمليات حساب كميات التعويضات للمنتجات
 * @author OnyxQ Team
 */
public class CompensationQuantityCalculationDetail
{
    /// <summary>
    /// رقم الوثيقة
    /// </summary>
    public long DocumentNumber { get; private set; }

    /// <summary>
    /// رمز المنتج
    /// </summary>
    public string ProductCode { get; private set; }

    /// <summary>
    /// وحدة المنتج
    /// </summary>
    public string ProductUnit { get; private set; }

    /// <summary>
    /// كمية التعويض
    /// </summary>
    public decimal CompensationQuantity { get; private set; }

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
    /// حالة المعالجة
    /// </summary>
    public int ProcessingStatus { get; private set; }

    /// <summary>
    /// حالة الموافقة
    /// </summary>
    public bool IsApproved { get; private set; }

    /// <summary>
    /// تاريخ الموافقة
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// معرف مستخدم الموافقة
    /// </summary>
    public int? ApprovalUserId { get; private set; }

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