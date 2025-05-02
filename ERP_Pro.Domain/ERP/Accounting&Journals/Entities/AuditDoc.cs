public class AuditDoc
{
    /// <summary>نوع المستند</summary>
    public int DocumentType { get; private set; }
    /// <summary>نوع القيد اليومي</summary>
    public long JournalVoucherType { get; private set; }
    /// <summary>رقم المستند</summary>
    public long DocumentNumber { get; private set; }
    /// <summary>سيريال المستند</summary>
    public long DocumentSerial { get; private set; }
    /// <summary>تاريخ المستند</summary>
    public DateTime DocumentDate { get; private set; }
    /// <summary>رمز الحساب الرئيسي</summary>
    public string? AccountCode { get; private set; }
    /// <summary>رمز الحساب التفصيلي</summary>
    public string? AccountDetailCode { get; private set; }
    /// <summary>نوع الحساب التفصيلي</summary>
    public short? AccountDetailType { get; private set; }
    /// <summary>رمز العملة</summary>
    public string? CurrencyCode { get; private set; }
    /// <summary>المبلغ بالعملة المحلية</summary>
    public int? Amount { get; private set; }
    /// <summary>المبلغ بالعملة الأجنبية</summary>
    public int? ForeignAmount { get; private set; }
    /// <summary>تسلسل التدقيق</summary>
    public int? AuditSequence { get; private set; }
    /// <summary>رقم المستخدم المحول منه</summary>
    public int? FromUserId { get; private set; }
    /// <summary>رقم المستخدم المحول إليه</summary>
    public int? ToUserId { get; private set; }
    /// <summary>هل تمت معالجة السجل</summary>
    public bool? IsProcessed { get; private set; }
    /// <summary>رمز مركز التكلفة</summary>
    public string? CostCenterCode { get; private set; }
    /// <summary>رقم المشروع</summary>
    public string? ProjectNumber { get; private set; }
    /// <summary>رقم النشاط</summary>
    public string? ActivityNumber { get; private set; }
    /// <summary>وصف المستند</summary>
    public string? DocumentDescription { get; private set; }
    /// <summary>رقم المرجع</summary>
    public string? ReferenceNumber { get; private set; }
    /// <summary>رمز العميل</summary>
    public string? CustomerCode { get; private set; }
    /// <summary>رمز المورد</summary>
    public string? VendorCode { get; private set; }
    /// <summary>رقم نوع المستند</summary>
    public long? DocumentTypeNumber { get; private set; }
    /// <summary>هل المستند مرحل</summary>
    public bool? IsDocumentPosted { get; private set; }
    /// <summary>اسم الجهاز المستخدم</summary>
    public string? TerminalName { get; private set; }
    /// <summary>هل المرجع قديم</summary>
    public bool? IsAuditReferenceOld { get; private set; }
    /// <summary>هل يوجد مرجع تدقيق</summary>
    public bool? HasAuditReference { get; private set; }
    /// <summary>وصف مرجع التدقيق</summary>
    public string? AuditReferenceDescription { get; private set; }
    /// <summary>رقم مستخدم مرجع التدقيق</summary>
    public int? AuditReferenceUserId { get; private set; }
    /// <summary>تاريخ مرجع التدقيق</summary>
    public DateTime? AuditReferenceDate { get; private set; }
    /// <summary>رمز المستودع</summary>
    public long? WarehouseCode { get; private set; }
    /// <summary>رقم السند النقدي</summary>
    public long? CashNumber { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي دقق السجل</summary>
    public int? AuditedByUserId { get; private set; }
    /// <summary>تاريخ التدقيق</summary>
    public DateTime? AuditDate { get; private set; }
    /// <summary>رقم الشركة</summary>
    public short CompanyNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int BranchNumber { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>رقم تقرير الطباعة</summary>
    public long? PrintReport { get; private set; }
}