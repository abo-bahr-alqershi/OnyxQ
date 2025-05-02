public class AuditAccDetail
{
    /// <summary>رقم التدقيق (معرف السطر)</summary>
    public long? AuditNumber { get; private set; }
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
    /// <summary>رمز الحساب الرئيسي</summary>
    public string? AccountCode { get; private set; }
    /// <summary>رمز الحساب التفصيلي</summary>
    public string? AccountDetailCode { get; private set; }
    /// <summary>نوع الحساب التفصيلي</summary>
    public short? AccountDetailType { get; private set; }
    /// <summary>رمز العملة</summary>
    public string? CurrencyCode { get; private set; }
    /// <summary>سعر العملة</summary>
    public int? AccountRate { get; private set; }
    /// <summary>رمز العميل</summary>
    public string? CustomerCode { get; private set; }
    /// <summary>رمز المورد</summary>
    public string? VendorCode { get; private set; }
    /// <summary>المبلغ بالعملة المحلية</summary>
    public int? Amount { get; private set; }
    /// <summary>المبلغ بالعملة الأجنبية</summary>
    public int? ForeignAmount { get; private set; }
    /// <summary>وصف الحساب</summary>
    public string? AccountDescription { get; private set; }
    /// <summary>رمز مركز التكلفة</summary>
    public string? CostCenterCode { get; private set; }
    /// <summary>رقم الاعتماد المستندي</summary>
    public string? LetterOfCreditNumber { get; private set; }
    /// <summary>رقم المرجع</summary>
    public string? ReferenceNumber { get; private set; }
    /// <summary>رمز المندوب</summary>
    public string? RepresentativeCode { get; private set; }
    /// <summary>رقم السند النقدي</summary>
    public long? CashNumber { get; private set; }
    /// <summary>رقم الشيك</summary>
    public long? ChequeNumber { get; private set; }
    /// <summary>تاريخ الاستحقاق</summary>
    public DateTime? ValueDate { get; private set; }
    /// <summary>حالة الترحيل الخارجي</summary>
    public int? ExternalPost { get; private set; }
    /// <summary>اسم الجهاز المستخدم</summary>
    public string? TerminalName { get; private set; }
    /// <summary>رقم السجل</summary>
    public long? RecordNumber { get; private set; }
    /// <summary>تاريخ استحقاق المستند</summary>
    public DateTime? DocumentDueDate { get; private set; }
    /// <summary>رقم الفاتورة</summary>
    public long? BillNumber { get; private set; }
    /// <summary>سيريال الفاتورة</summary>
    public long? BillSerial { get; private set; }
    /// <summary>رقم الإشعار</summary>
    public long? InvoiceNumber { get; private set; }
    /// <summary>رقم أمر العمل</summary>
    public long? WorkOrderNumber { get; private set; }
    /// <summary>سيريال أمر العمل</summary>
    public long? WorkOrderSerial { get; private set; }
    /// <summary>رقم القيد</summary>
    public long? EntryNumber { get; private set; }
    /// <summary>سيريال القيد</summary>
    public long? EntrySerial { get; private set; }
    /// <summary>رقم الشركة</summary>
    public short? CompanyNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int BranchNumber { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    public AuditAccMaster AuditAccMaster { get; private set; } // Navigation
}