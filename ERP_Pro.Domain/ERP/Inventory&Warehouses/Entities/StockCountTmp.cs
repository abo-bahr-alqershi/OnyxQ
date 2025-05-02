public class StockCountTmp
{
    /// <summary> كود الصنف. </summary>
    public string? ItemCode { get; private set; }
    /// <summary> اسم الصنف. </summary>
    public string? ItemName { get; private set; }
    /// <summary> وحدة الصنف. </summary>
    public string ItemUnit { get; private set; }
    /// <summary> كود المستودع. </summary>
    public long? WarehouseCode { get; private set; }
    /// <summary> رقم التشغيلة/الدفعة. </summary>
    public string? BatchNumber { get; private set; }
    /// <summary> كمية الافتتاح. </summary>
    public int? OpeningQuantity { get; private set; }
    /// <summary> كمية الوارد. </summary>
    public int? IncomingQuantity { get; private set; }
    /// <summary> كمية المبيعات. </summary>
    public int? SaleQuantity { get; private set; }
    /// <summary> كمية نقطة البيع. </summary>
    public int? PointOfSaleQuantity { get; private set; }
    /// <summary> صافي المبيعات. </summary>
    public int? NetSaleQuantity { get; private set; }
    /// <summary> الكمية المتاحة. </summary>
    public int? AvailableQuantity { get; private set; }
    /// <summary> متوسط المبيعات اليومي. </summary>
    public int? AverageDailySaleQuantity { get; private set; }
    /// <summary> متوسط المبيعات العام. </summary>
    public int? AverageGeneralSaleQuantity { get; private set; }
    /// <summary> نسبة المبيعات للكمية. </summary>
    public int? SaleQuantityPercentage { get; private set; }
    /// <summary> عمر المبيعات للصنف. </summary>
    public int? ItemSaleAge { get; private set; }
    /// <summary> فترة عمر مبيعات الصنف. </summary>
    public int? ItemSaleAgePeriod { get; private set; }
    /// <summary> عمر الصنف في المخزون. </summary>
    public int? ItemAge { get; private set; }
    /// <summary> نسبة الصنف. </summary>
    public int? ItemRatio { get; private set; }
    /// <summary> نسبة مبيعات الصنف. </summary>
    public int? ItemSaleRatio { get; private set; }
    /// <summary> كمية لم يتم استلامها. </summary>
    public long? NotReceivedQuantity { get; private set; }
    /// <summary> مجموع كمية الوارد. </summary>
    public long? TotalIncomingQuantity { get; private set; }
    /// <summary> كمية محولة من المستودع. </summary>
    public long? QuantityFromWarehouse { get; private set; }
    /// <summary> كمية محولة إلى المستودع. </summary>
    public long? QuantityToWarehouse { get; private set; }
    /// <summary> متوسط الكمية لفترة محددة. </summary>
    public long? AverageQuantityPeriod { get; private set; }
    /// <summary> كود مجموعة الصنف. </summary>
    public string? GroupCode { get; private set; }
    /// <summary> كود تصنيف المجموعة. </summary>
    public string? GroupClassCode { get; private set; }
    /// <summary> كود مدير الصنف. </summary>
    public string? ManagerCode { get; private set; }
    /// <summary> كود المجموعة الفرعية. </summary>
    public string? SubGroupCode { get; private set; }
    /// <summary> رقم مساعد. </summary>
    public string? AssistantNumber { get; private set; }
    /// <summary> رقم تفصيلي. </summary>
    public string? DetailNumber { get; private set; }
    /// <summary> رقم النشاط المرتبط. </summary>
    public int? ActivityNumber { get; private set; }
    /// <summary> تاريخ دخول الصنف. </summary>
    public DateTime? IncomeDate { get; private set; }
    /// <summary> نوع الصنف. </summary>
    public int? ItemType { get; private set; }
    /// <summary> رقم المدينة. </summary>
    public long? CityNumber { get; private set; }
    /// <summary> رقم المنطقة. </summary>
    public long? RegionCode { get; private set; }
    /// <summary> ترتيب الصنف. </summary>
    public int? ItemOrder { get; private set; }
    /// <summary> عدد أيام الفترة. </summary>
    public int? PeriodDays { get; private set; }
    /// <summary> رقم المستند. </summary>
    public long? DocumentNumber { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر. </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة. </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر. </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل. </summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary> رقم الشركة. </summary>
    public short? CompanyNumber { get; private set; }
    /// <summary> رقم الفرع. </summary>
    public int? BranchNumber { get; private set; }
    /// <summary> السنة المالية للفرع. </summary>
    public short? BranchYear { get; private set; }
    /// <summary> مستخدم الفرع. </summary>
    public short? BranchUser { get; private set; }
}