public class ItemPriceHistory
{
    /// <summary> رقم السجل التاريخي </summary>
    public long? AuditNumber { get; private set; }
    /// <summary> نوع السجل (إضافة/تعديل) </summary>
    public bool? AuditType { get; private set; }
    /// <summary> رقم مستوى التسعير </summary>
    public short? LevelNumber { get; private set; }
    /// <summary> كود الصنف </summary>
    public string? ItemCode { get; private set; }
    /// <summary> وحدة الصنف </summary>
    public string? ItemUnit { get; private set; }
    /// <summary> حجم العبوة </summary>
    public int? PackSize { get; private set; }
    /// <summary> كود المستودع </summary>
    public long? WarehouseCode { get; private set; }
    /// <summary> الكمية من </summary>
    public long? FromQuantity { get; private set; }
    /// <summary> الكمية إلى </summary>
    public long? ToQuantity { get; private set; }
    /// <summary> سعر الصنف الجديد </summary>
    public decimal? ItemPrice { get; private set; }
    /// <summary> السعر السابق </summary>
    public int? PreviousItemPrice { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary> المستخدم الذي راجع التعديل </summary>
    public int? AuditUserId { get; private set; }
    /// <summary> تاريخ التدقيق </summary>
    public DateTime? AuditDate { get; private set; }
    /// <summary> رقم المستند </summary>
    public long? DocumentNumber { get; private set; }
    /// <summary> تاريخ المستند </summary>
    public DateTime? DocumentDate { get; private set; }
    /// <summary> رقم الفرع </summary>
    public int BranchNumber { get; private set; }
    /// <summary> عدد مرات التعديل </summary>
    public long? UpdateCount { get; private set; }
    /// <summary> أولوية التقرير </summary>
    public long? ReportPriority { get; private set; }
    /// <summary> الجهاز عند الإضافة </summary>
    public string? AddedTerminal { get; private set; }
    /// <summary> الجهاز عند التعديل </summary>
    public string? UpdatedTerminal { get; private set; }
    /// <summary> تاريخ انتهاء السعر </summary>
    public DateTime ExpireDate { get; private set; }
    /// <summary> رقم الدفعة </summary>
    public string BatchNumber { get; private set; }
    /// <summary> الحد الأدنى للسعر الجديد </summary>
    public int? MinimumItemPrice { get; private set; }
    /// <summary> الحد الأعلى للسعر الجديد </summary>
    public int? MaximumItemPrice { get; private set; }
    /// <summary> الحد الأعلى السابق للسعر </summary>
    public int? PreviousMaximumItemPrice { get; private set; }
    /// <summary> الحد الأدنى السابق للسعر </summary>
    public int? PreviousMinimumItemPrice { get; private set; }
}