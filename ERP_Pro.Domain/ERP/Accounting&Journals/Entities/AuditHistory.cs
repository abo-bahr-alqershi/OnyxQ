public class AuditHistory
{
    /// <summary>نوع العملية (إضافة/تعديل/حذف)</summary>
    public bool OperationType { get; private set; }
    /// <summary>تسلسل العملية</summary>
    public long OperationSerial { get; private set; }
    /// <summary>رقم النموذج</summary>
    public int? FormNumber { get; private set; }
    /// <summary>اسم الجهاز المستخدم</summary>
    public string? TerminalName { get; private set; }
    /// <summary>اسم الجدول</summary>
    public string TableName { get; private set; }
    /// <summary>اسم العمود</summary>
    public string ColumnName { get; private set; }
    /// <summary>القيمة القديمة</summary>
    public string? OldValue { get; private set; }
    /// <summary>القيمة الجديدة</summary>
    public string? NewValue { get; private set; }
    /// <summary>المفتاح الأساسي 1</summary>
    public string? ColumnPrimaryKey1 { get; private set; }
    /// <summary>المفتاح الأساسي 2</summary>
    public string? ColumnPrimaryKey2 { get; private set; }
    /// <summary>المفتاح الأساسي 3</summary>
    public string? ColumnPrimaryKey3 { get; private set; }
    /// <summary>رقم المستخدم الذي دقق السجل</summary>
    public int? AuditedByUserId { get; private set; }
    /// <summary>تاريخ التدقيق</summary>
    public DateTime? AuditDate { get; private set; }
    /// <summary>رقم الشركة</summary>
    public short? CompanyNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int? BranchNumber { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>نوع التدقيق</summary>
    public short? AuditType { get; private set; }
    /// <summary>نوع المستند</summary>
    public int? DocumentType { get; private set; }
    /// <summary>نوع القيد اليومي</summary>
    public long? JournalVoucherType { get; private set; }
    /// <summary>رقم المستند</summary>
    public long? DocumentNumber { get; private set; }
    /// <summary>سيريال المستند</summary>
    public long? DocumentSerial { get; private set; }
    /// <summary>رمز الصنف</summary>
    public string? ItemCode { get; private set; }
    /// <summary>كمية الصنف</summary>
    public int? ItemQuantity { get; private set; }
    /// <summary>كمية مجانية</summary>
    public int? FreeQuantity { get; private set; }
    /// <summary>وحدة الصنف</summary>
    public string ItemUnit { get; private set; }
    /// <summary>حجم العبوة</summary>
    public int? PackageSize { get; private set; }
    /// <summary>كمية العبوة</summary>
    public int? PackageQuantity { get; private set; }
    /// <summary>سعر الصنف</summary>
    public int? ItemPrice { get; private set; }
    /// <summary>تكلفة المخزون</summary>
    public int? StockCost { get; private set; }
    /// <summary>كمية الصادر</summary>
    public int? OutQuantity { get; private set; }
    /// <summary>كمية مجانية صادرة</summary>
    public int? OutFreeQuantity { get; private set; }
    /// <summary>رمز المستودع</summary>
    public long? WarehouseCode { get; private set; }
    /// <summary>رمز مركز التكلفة</summary>
    public string? CostCenterCode { get; private set; }
    /// <summary>تاريخ الانتهاء</summary>
    public DateTime? ExpiryDate { get; private set; }
    /// <summary>رقم التشغيلة</summary>
    public string? BatchNumber { get; private set; }
    /// <summary>مبلغ الخصم</summary>
    public int? DiscountAmount { get; private set; }
    /// <summary>مبلغ الضريبة</summary>
    public int? VatAmount { get; private set; }
    /// <summary>مبلغ آخر</summary>
    public int? OtherAmount { get; private set; }
    /// <summary>هل يستخدم الرقم التسلسلي</summary>
    public bool? UseSerialNumber { get; private set; }
    /// <summary>هل الصنف خدمي</summary>
    public bool? IsServiceItem { get; private set; }
    /// <summary>رقم السجل</summary>
    public long? RecordNumber { get; private set; }
    /// <summary>تسلسل المستند</summary>
    public long? DocumentSequence { get; private set; }
    /// <summary>وصف الصنف</summary>
    public string? ItemDescription { get; private set; }
    /// <summary>الباركود</summary>
    public string? Barcode { get; private set; }
    /// <summary>رقم أمر البيع</summary>
    public long? SalesOrderNumber { get; private set; }
    /// <summary>سيريال أمر البيع</summary>
    public long? SalesOrderSerial { get; private set; }
    /// <summary>نوع مستند مرجعي</summary>
    public int? ReferenceDocumentType { get; private set; }
    /// <summary>رقم مستند مرجعي</summary>
    public long? ReferenceDocumentNumber { get; private set; }
    /// <summary>سيريال مستند مرجعي</summary>
    public long? ReferenceDocumentSerial { get; private set; }
    /// <summary>اسم الجهاز المستخدم (مكرر)</summary>
    public string? TerminalNameDuplicate { get; private set; }
    /// <summary>رقم الشركة</summary>
    public short CompanyNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int? BranchNumber { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
}