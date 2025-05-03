/**
 * @class CompensationQuantityCalculationDetail
 * @description كلاس تفاصيل حساب كميات التعويضات المستخدم في تنظيم وإدارة عمليات حساب كميات التعويضات
 * @author OnyxQ Team
 */
public class CompensationQuantityCalculationDetail
{
    /// <summary>
    /// الرقم المتسلسل للوثيقة
    /// </summary>
    public long? DocumentSerial { get; private set; }

    /// <summary>
    /// رقم الوثيقة
    /// </summary>
    public long? DocumentNumber { get; private set; }

    /// <summary>
    /// رمز العنصر
    /// </summary>
    public string? ItemCode { get; private set; }

    /// <summary>
    /// وحدة العنصر
    /// </summary>
    public string? ItemUnit { get; private set; }

    /// <summary>
    /// حجم العبوة
    /// </summary>
    public int? PackageSize { get; private set; }

    /// <summary>
    /// نوع العنصر
    /// </summary>
    public int? ItemType { get; private set; }

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
    /// كمية التعويض
    /// </summary>
    public int? CompensationQuantity { get; private set; }

    /// <summary>
    /// وصف التعويض
    /// </summary>
    public string? CompensationDescription { get; private set; }

    /// <summary>
    /// نسبة التعويض
    /// </summary>
    public int? CompensationPercentage { get; private set; }

    /// <summary>
    /// مبلغ صافي المبيعات
    /// </summary>
    public int? NetSalesAmount { get; private set; }

    /// <summary>
    /// كمية صافي المبيعات
    /// </summary>
    public int? NetSalesQuantity { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public long? RecordNumber { get; private set; }

    /// <summary>
    /// تسلسل الوثيقة
    /// </summary>
    public int? DocumentSequence { get; private set; }

    /// <summary>
    /// رمز المجموعة
    /// </summary>
    public string? GroupCode { get; private set; }

    /// <summary>
    /// رقم الفاتورة
    /// </summary>
    public int? BillNumber { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للفاتورة
    /// </summary>
    public int? BillSerial { get; private set; }

    /// <summary>
    /// مبلغ التحصيل
    /// </summary>
    public int? CollectionAmount { get; private set; }

    /// <summary>
    /// نوع وثيقة الفاتورة
    /// </summary>
    public short? BillDocumentType { get; private set; }

    /// <summary>
    /// الكمية السابقة
    /// </summary>
    public int? PreviousQuantity { get; private set; }

    /// <summary>
    /// تاريخ الانتهاء
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// رقم الدفعة
    /// </summary>
    public string? BatchNumber { get; private set; }

    /// <summary>
    /// سعر العنصر
    /// </summary>
    public int? ItemPrice { get; private set; }

    /// <summary>
    /// تكلفة المخزون
    /// </summary>
    public int? StockCost { get; private set; }

    /// <summary>
    /// تاريخ الوثيقة
    /// </summary>
    public DateTime? DocumentDate { get; private set; }

    /// <summary>
    /// تاريخ البداية
    /// </summary>
    public DateTime? FromDate { get; private set; }

    /// <summary>
    /// تاريخ النهاية
    /// </summary>
    public DateTime? ToDate { get; private set; }

    /// <summary>
    /// نوع التعويض
    /// </summary>
    public int? CompensationType { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string? ReferenceNumber { get; private set; }

    /// <summary>
    /// وصف الوثيقة
    /// </summary>
    public string? DocumentDescription { get; private set; }

    /// <summary>
    /// مؤشر المعالجة
    /// </summary>
    public int? ProcessedFlag { get; private set; }

    /// <summary>
    /// حالة الموافقة
    /// </summary>
    public int? Approved { get; private set; }

    /// <summary>
    /// تاريخ الموافقة
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// معرف مستخدم الموافقة
    /// </summary>
    public int? ApprovalUserId { get; private set; }

    /// <summary>
    /// وصف الموافقة
    /// </summary>
    public string? ApprovalDescription { get; private set; }

    /// <summary>
    /// رقم التقرير
    /// </summary>
    public long? PrintReport { get; private set; }

    /// <summary>
    /// رقم الوثيقة من
    /// </summary>
    public int? FromDocumentNumber { get; private set; }

    /// <summary>
    /// رقم الوثيقة إلى
    /// </summary>
    public int? ToDocumentNumber { get; private set; }

    /// <summary>
    /// رمز العميل
    /// </summary>
    public string? CustomerCode { get; private set; }

    /// <summary>
    /// رقم الطلب
    /// </summary>
    public int? RequestNumber { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للطلب
    /// </summary>
    public int? RequestSerial { get; private set; }

    /// <summary>
    /// رمز الحساب
    /// </summary>
    public string? AccountCode { get; private set; }

    /// <summary>
    /// رمز العملة
    /// </summary>
    public string? CurrencyCode { get; private set; }

    /// <summary>
    /// سعر الوثيقة
    /// </summary>
    public int? DocumentRate { get; private set; }

    /// <summary>
    /// سعر المخزون
    /// </summary>
    public int? StockRate { get; private set; }

    /// <summary>
    /// ترحيل الوثيقة
    /// </summary>
    public bool? DocumentPost { get; private set; }

    /// <summary>
    /// مرجع التدقيق
    /// </summary>
    public bool? AuditReference { get; private set; }

    /// <summary>
    /// في الانتظار
    /// </summary>
    public bool? StandBy { get; private set; }

    /// <summary>
    /// وصف مرجع التدقيق
    /// </summary>
    public string? AuditReferenceDescription { get; private set; }

    /// <summary>
    /// معرف مستخدم مرجع التدقيق
    /// </summary>
    public int? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// تاريخ مرجع التدقيق
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// معرف مستخدم إلغاء الترحيل
    /// </summary>
    public int? UnpostUserId { get; private set; }

    /// <summary>
    /// تاريخ إلغاء الترحيل
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// رقم فرع الوثيقة
    /// </summary>
    public int? DocumentBranchNumber { get; private set; }

    /// <summary>
    /// تاريخ الترحيل
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// معرف مستخدم الترحيل
    /// </summary>
    public int? PostUserId { get; private set; }

    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AddUserId { get; private set; }

    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime AddDate { get; private set; }

    /// <summary>
    /// اسم طرفية الإضافة
    /// </summary>
    public string? AddTerminalName { get; private set; }

    /// <summary>
    /// معرف مستخدم التحديث
    /// </summary>
    public int? UpdateUserId { get; private set; }

    /// <summary>
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdateDate { get; private set; }

    /// <summary>
    /// اسم طرفية التحديث
    /// </summary>
    public string? UpdateTerminalName { get; private set; }

    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpdateCounter { get; private set; }

    /// <summary>
    /// رقم الشركة
    /// </summary>
    public short? CompanyNumber { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public short? BranchYear { get; private set; }

    /// <summary>
    /// رقم مستخدم الفرع
    /// </summary>
    public short? BranchUser { get; private set; }
}