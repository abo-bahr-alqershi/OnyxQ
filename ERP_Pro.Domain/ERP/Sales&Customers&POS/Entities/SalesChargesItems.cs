public class SalesChargesItems
{
    /// <summary> رقم المصروف </summary>
    public short? ChargeNo { get; private set; }
    /// <summary> تصنيف العميل </summary>
    public short? CustomerClass { get; private set; }
    /// <summary> كود العميل </summary>
    public string? CustomerCode { get; private set; }
    /// <summary> كود الصنف المرتبط بالمصروف </summary>
    public string ItemCode { get; private set; }
    /// <summary> وحدة الصنف </summary>
    public string? ItemUnit { get; private set; }
    /// <summary> حجم العبوة </summary>
    public int? PackSize { get; private set; }
    /// <summary> كود مجموعة الصنف </summary>
    public string? GroupCode { get; private set; }
    /// <summary> مبلغ المصروف </summary>
    public int? Amount { get; private set; }
    /// <summary> نسبة المصروف من الإجمالي </summary>
    public int? PercentAmount { get; private set; }
    /// <summary> كود المستودع المرتبط </summary>
    public long? WarehouseCode { get; private set; }
    /// <summary> نوع الفاتورة </summary>
    public int? SalesInvoiceType { get; private set; }
    /// <summary> تاريخ البداية </summary>
    public DateTime? FromDate { get; private set; }
    /// <summary> تاريخ النهاية </summary>
    public DateTime? ToDate { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary> عدد مرات التحديث </summary>
    public long? UpdateCount { get; private set; }
    /// <summary> أولوية التقرير </summary>
    public long? ReportPriority { get; private set; }
    /// <summary> اسم الجهاز عند الإضافة </summary>
    public string? AddedTerminal { get; private set; }
    /// <summary> اسم الجهاز عند التعديل </summary>
    public string? UpdatedTerminal { get; private set; }
    /// <summary> كود مجموعة الصنف </summary>
    public string? GroupCode { get; private set; }
    /// <summary> كود العميل </summary>
    public string? CustomerCode { get; private set; }
    /// <summary> تصنيف العميل </summary>
    public short? CustomerClass { get; private set; }
    /// <summary> كود الصنف المرتبط بالمصروف </summary>
    public string? ItemCode { get; private set; }
    /// <summary> حجم العبوة </summary>
    public int? PackSize { get; private set; }
    /// <summary> وحدة الصنف </summary>
    public string? ItemUnit { get; private set; }
    public bool? AmountType { get; private set; }
    /// <summary> مبلغ المصروف </summary>
    public decimal? Amount { get; private set; }
    public string? AccountCurrency { get; private set; }
    public int? AccountRate { get; private set; }
    /// <summary> كود المستودع المرتبط </summary>
    public long? WarehouseGroupCode { get; private set; }
    public long? WarehouseGroupCode { get; private set; }
    /// <summary> تاريخ البداية </summary>
    public DateTime? FromDate { get; private set; }
    /// <summary> تاريخ النهاية </summary>
    public DateTime? ToDate { get; private set; }
    public short? LevelNumber { get; private set; }
    public int? FromQuantity { get; private set; }
    public int? ToQuantity { get; private set; }
    public string? BatchNo { get; private set; }
    public int? ItemPrice { get; private set; }
    public int? StockCost { get; private set; }
    public int? AvailableQuantity { get; private set; }
    public string? DocumentDescription { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    public int BranchNumber { get; private set; }
    /// <summary> عدد مرات التحديث </summary>
    public long? UpdateCount { get; private set; }
    /// <summary> أولوية التقرير </summary>
    public long? ReportPriority { get; private set; }
    /// <summary> اسم الجهاز عند الإضافة </summary>
    public string? AddedTerminal { get; private set; }
    /// <summary> اسم الجهاز عند التعديل </summary>
    public string? UpdatedTerminal { get; private set; }
    public int? Amount2 { get; private set; }
    public int? Amount3 { get; private set; }
    public long? CustomerGroupCode { get; private set; }
    /// <summary> كود العميل </summary>
    public string? CustomerCode { get; private set; }
    /// <summary> تصنيف العميل </summary>
    public short? CustomerClass { get; private set; }
    /// <summary> كود الصنف المرتبط بالمصروف </summary>
    public string? ItemCode { get; private set; }
    /// <summary> حجم العبوة </summary>
    public int? PackSize { get; private set; }
    /// <summary> وحدة الصنف </summary>
    public string? ItemUnit { get; private set; }
    public bool? PaymentType { get; private set; }
    public int? LowQuantity { get; private set; }
    public int? PercentageQuantity { get; private set; }
    /// <summary> كود المستودع المرتبط </summary>
    public long? WarehouseGroupCode { get; private set; }
    public long? WarehouseGroupCode { get; private set; }
    public short? BillDocumentType { get; private set; }
    public long? RecordNumber { get; private set; }
    public int? FromQuantity { get; private set; }
    public int? ToQuantity { get; private set; }
    /// <summary> تاريخ البداية </summary>
    public DateTime? FromDate { get; private set; }
    /// <summary> تاريخ النهاية </summary>
    public DateTime? ToDate { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    public int BranchNumber { get; private set; }
    /// <summary> عدد مرات التحديث </summary>
    public long? UpdateCount { get; private set; }
    /// <summary> أولوية التقرير </summary>
    public long? ReportPriority { get; private set; }
    /// <summary> اسم الجهاز عند الإضافة </summary>
    public string? AddedTerminal { get; private set; }
    /// <summary> اسم الجهاز عند التعديل </summary>
    public string? UpdatedTerminal { get; private set; }
    public string? RepresentativeArabicName { get; private set; }
    public string? RepresentativeEnglishName { get; private set; }
    public string? RepresentativeCode { get; private set; }
    public short? SalesmanType { get; private set; }
    public short? CountryNumber { get; private set; }
    public long? CityNumber { get; private set; }
    public long? RegionCode { get; private set; }
    public string? RepresentativePhone { get; private set; }
    public string? RepresentativeBox { get; private set; }
    public string? RepresentativeFax { get; private set; }
    public string? RepresentativeNote { get; private set; }
    public string? RepresentativeMobile { get; private set; }
    public string? RepresentativeAddress { get; private set; }
    public decimal? CommissionPercentage { get; private set; }
    public string? GuarantorName { get; private set; }
    public string? GuarantorAddress { get; private set; }
    public DateTime? GuarantorStartDate { get; private set; }
    public DateTime? GuarantorExpireDate { get; private set; }
    public bool? GuarantorType { get; private set; }
    public int? GuarantorAmount { get; private set; }
    public bool? GuarantorStatus { get; private set; }
    public string? GuarantorFinancialCenter { get; private set; }
    public string? GuarantorWork { get; private set; }
    public DateTime? GuarantorDocumentDate { get; private set; }
    public string? GuarantorRegistrationCourt { get; private set; }
    public string? GuarantorRegistrationTrade { get; private set; }
    public string? GuarantorFileTrade { get; private set; }
    public string? GuarantorTelephone { get; private set; }
    public string? GuarantorFax { get; private set; }
    public string? RepresentativeCodeParent { get; private set; }
    public long? SortInRoute { get; private set; }
    public long? CashNumber { get; private set; }
    /// <summary> كود المستودع المرتبط </summary>
    public long? WarehouseCode { get; private set; }
    public string? CostCenterCode { get; private set; }
    public string? ProjectNumber { get; private set; }
    public string? ActivityNumber { get; private set; }
    public long? BankNo { get; private set; }
    public string? GroupCode { get; private set; }
    public string? SalesmanPassword { get; private set; }
    public bool? UseInvoiceDetails { get; private set; }
    public int? CreditLimit { get; private set; }
    public string? AccountCodeDetail { get; private set; }
    public short? AccountDetailType { get; private set; }
    public short? ChequeType { get; private set; }
    public int? PostChequeTypeReceived { get; private set; }
    public int? ConnectBranchNumber { get; private set; }
    public bool? WorkWithoutPlan { get; private set; }
    public short? VisitOpenType { get; private set; }
    public long? VisitOpenDistance { get; private set; }
    public long? RegionRange { get; private set; }
    public bool? ImplementPlanSortRouteMandatory { get; private set; }
    public bool? ShowQuantityInAllWarehouses { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int? AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary> عدد مرات التحديث </summary>
    public long? UpdateCount { get; private set; }
    /// <summary> أولوية التقرير </summary>
    public long? ReportPriority { get; private set; }
    /// <summary> اسم الجهاز عند الإضافة </summary>
    public string? AddedTerminal { get; private set; }
    /// <summary> اسم الجهاز عند التعديل </summary>
    public string? UpdatedTerminal { get; private set; }
    public bool? AllowChangeCustomerGPS { get; private set; }
    public int? CalculationTypeNoTax { get; private set; }
    public bool? AllowCancelDocument { get; private set; }
    public bool? AllowReturnAllItemsFlag { get; private set; }
    public int? AppCustomerPlanInsertMaxLimit { get; private set; }
    public bool? AllowModifyCustomerLocation { get; private set; }
    public bool? NoSales { get; private set; }
    public bool? NoCollection { get; private set; }
    public string? ApplicationVersionCode { get; private set; }
    public bool? AllowFileShare { get; private set; }
    public long? RepresentativeSerial { get; private set; }
    public bool? ConnectSupervisorSalesman { get; private set; }
    public bool? NotAllowEnterReturnSales { get; private set; }
    public bool? SaveVoucherOnline { get; private set; }
    public short? SynchronizationMethod { get; private set; }
    public DateTime? LastUpdateDetails { get; private set; }
    public DateTime? LastPostDateDetails { get; private set; }
    public bool? DetailsCloseFlag { get; private set; }
    public int? DetailsCloseUserId { get; private set; }
    public DateTime? DetailsCloseDate { get; private set; }
    public int? CashAmountLimit { get; private set; }
    public int? CashAmountDailyLimit { get; private set; }
    public long? PlanNumber { get; private set; }
    public long? PlanSerial { get; private set; }
    public SalesCharges SalesCharges { get; private set; } // Navigation
    public Customer Customer { get; private set; } // Navigation
}