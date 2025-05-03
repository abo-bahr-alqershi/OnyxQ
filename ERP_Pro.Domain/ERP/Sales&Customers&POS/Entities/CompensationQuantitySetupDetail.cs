/**
 * @class CompensationQuantitySetupDetail
 * @description كلاس تفاصيل إعداد كميات التعويضات المستخدم في تنظيم وإدارة إعدادات كميات التعويضات للعناصر
 * @author OnyxQ Team
 */
public class CompensationQuantitySetupDetail
{
    /// <summary>
    /// نوع التعويض
    /// </summary>
    public int? CompensationType { get; private set; }

    /// <summary>
    /// رمز العنصر
    /// </summary>
    public string? ItemCode { get; private set; }

    /// <summary>
    /// وحدة العنصر
    /// </summary>
    public string? ItemUnit { get; private set; }

    /// <summary>
    /// رمز المجموعة
    /// </summary>
    public string? GroupCode { get; private set; }

    /// <summary>
    /// نوع العنصر
    /// </summary>
    public int? ItemType { get; private set; }

    /// <summary>
    /// القيمة من
    /// </summary>
    public int? FromValue { get; private set; }

    /// <summary>
    /// القيمة إلى
    /// </summary>
    public int? ToValue { get; private set; }

    /// <summary>
    /// حجم العبوة
    /// </summary>
    public int? PackageSize { get; private set; }

    /// <summary>
    /// رقم النشاط
    /// </summary>
    public int? ActivityNumber { get; private set; }

    /// <summary>
    /// رمز مركز التكلفة
    /// </summary>
    public string? CostCenterCode { get; private set; }

    /// <summary>
    /// رقم النشاط
    /// </summary>
    public string? ActivityCode { get; private set; }

    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string? ProjectNumber { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public int? BranchNumber { get; private set; }

    /// <summary>
    /// رمز المستودع
    /// </summary>
    public long? WarehouseCode { get; private set; }

    /// <summary>
    /// نسبة التحصيل من
    /// </summary>
    public int? FromCollectionPercentage { get; private set; }

    /// <summary>
    /// نسبة التحصيل إلى
    /// </summary>
    public int? ToCollectionPercentage { get; private set; }

    /// <summary>
    /// الكمية
    /// </summary>
    public int? Quantity { get; private set; }

    /// <summary>
    /// نسبة الحد الأعلى
    /// </summary>
    public int? HighLimitPercentage { get; private set; }

    /// <summary>
    /// نسبة الحد الأدنى
    /// </summary>
    public int? LowLimitPercentage { get; private set; }

    /// <summary>
    /// الاسم المحلي لنوع العمولة
    /// </summary>
    public string? CommissionTypeLocalName { get; private set; }

    /// <summary>
    /// الاسم الأجنبي لنوع العمولة
    /// </summary>
    public string? CommissionTypeForeignName { get; private set; }

    /// <summary>
    /// نوع عنصر التعويض
    /// </summary>
    public short? CompensationItemType { get; private set; }

    /// <summary>
    /// نوع مبيعات التعويض
    /// </summary>
    public short? CompensationSalesType { get; private set; }

    /// <summary>
    /// نوع وظيفة التعويض
    /// </summary>
    public short? CompensationFunctionType { get; private set; }

    /// <summary>
    /// نوع مبلغ التعويض
    /// </summary>
    public bool? CompensationAmountType { get; private set; }

    /// <summary>
    /// مؤشر الإيقاف
    /// </summary>
    public bool? IsInactive { get; private set; }

    /// <summary>
    /// سبب الإيقاف
    /// </summary>
    public string? InactiveReason { get; private set; }

    /// <summary>
    /// تاريخ الإيقاف
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// معرف مستخدم الإيقاف
    /// </summary>
    public int? InactiveUserId { get; private set; }

    /// <summary>
    /// وصف العمولة
    /// </summary>
    public string? CommissionDescription { get; private set; }

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

    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpdateCounter { get; private set; }

    /// <summary>
    /// رقم التقرير
    /// </summary>
    public long? PrintReport { get; private set; }

    /// <summary>
    /// اسم طرفية الإضافة
    /// </summary>
    public string? AddTerminalName { get; private set; }

    /// <summary>
    /// اسم طرفية التحديث
    /// </summary>
    public string? UpdateTerminalName { get; private set; }
} 