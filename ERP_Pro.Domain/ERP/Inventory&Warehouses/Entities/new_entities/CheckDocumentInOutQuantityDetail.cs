/**
 * @class CheckDocumentInOutQuantityDetail
 * @description كلاس تفاصيل فحص كميات المستندات الواردة والصادرة المستخدم في تتبع وإدارة حركة المخزون
 * @author OnyxQ Team
 */
public class CheckDocumentInOutQuantityDetail
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
    /// الكمية الواردة
    /// </summary>
    public decimal InQuantity { get; private set; }

    /// <summary>
    /// الكمية الصادرة
    /// </summary>
    public decimal OutQuantity { get; private set; }

    /// <summary>
    /// رمز المستودع
    /// </summary>
    public string? WarehouseCode { get; private set; }

    /// <summary>
    /// رقم الدفعة
    /// </summary>
    public string? BatchNumber { get; private set; }

    /// <summary>
    /// تاريخ الصلاحية
    /// </summary>
    public DateTime? ExpiryDate { get; private set; }

    /// <summary>
    /// حالة المعالجة
    /// </summary>
    public int ProcessingStatus { get; private set; }

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