public class AuditAccMaster
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
    /// <summary>تاريخ المستند</summary>
    public DateTime? DocumentDate { get; private set; }
    /// <summary>رمز الحساب الرئيسي</summary>
    public string? AccountCode { get; private set; }
    /// <summary>رمز الحساب التفصيلي</summary>
    public string? AccountDetailCode { get; private set; }
    /// <summary>نوع الحساب التفصيلي</summary>
    public short? AccountDetailType { get; private set; }
    /// <summary>رمز العملة</summary>
    public string? CurrencyCode { get; private set; }
    /// <summary>سعر الصرف</summary>
    public int? ExchangeRate { get; private set; }
    /// <summary>المبلغ بالعملة المحلية</summary>
    public int? Amount { get; private set; }
    /// <summary>المبلغ بالعملة الأجنبية</summary>
    public int? ForeignAmount { get; private set; }
    /// <summary>رمز العميل</summary>
    public string? CustomerCode { get; private set; }
    /// <summary>رمز المورد</summary>
    public string? VendorCode { get; private set; }
    /// <summary>رمز مركز التكلفة</summary>
    public string? CostCenterCode { get; private set; }
    /// <summary>رقم التحصيل</summary>
    public long? CollectionNumber { get; private set; }
    /// <summary>وصف الحساب</summary>
    public string? AccountDescription { get; private set; }
    /// <summary>رقم المرجع</summary>
    public string? ReferenceNumber { get; private set; }
    /// <summary>اسم المرجع</summary>
    public string? ReferenceName { get; private set; }
    /// <summary>رقم السند النقدي</summary>
    public long? CashNumber { get; private set; }
    /// <summary>نوع الشيك</summary>
    public short? ChequeType { get; private set; }
    /// <summary>اسم المستلم</summary>
    public string? ReceiverName { get; private set; }
    /// <summary>اسم المستفيد</summary>
    public string? BeneficiaryName { get; private set; }
    /// <summary>هل السجل احتياطي</summary>
    public bool? IsStandBy { get; private set; }
    /// <summary>عدد المرفقات</summary>
    public short? AttachmentNumber { get; private set; }
    /// <summary>سبب الحذف</summary>
    public string? DeleteReason { get; private set; }
    /// <summary>حالة الترحيل الخارجي</summary>
    public int? ExternalPost { get; private set; }
    /// <summary>رقم تقرير الطباعة</summary>
    public long? PrintReport { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>رقم المستخدم</summary>
    public int? UserId { get; private set; }
    /// <summary>تاريخ التدقيق</summary>
    public DateTime? AuditDate { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي رحّل السجل</summary>
    public int? PostedByUserId { get; private set; }
    /// <summary>تاريخ الترحيل</summary>
    public DateTime? PostDate { get; private set; }
    /// <summary>رقم المستخدم الذي ألغى الترحيل</summary>
    public int? UnpostedByUserId { get; private set; }
    /// <summary>تاريخ إلغاء الترحيل</summary>
    public DateTime? UnpostDate { get; private set; }
    /// <summary>اسم الجهاز المستخدم</summary>
    public string? TerminalName { get; private set; }
    /// <summary>رقم الشركة</summary>
    public short CompanyNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int BranchNumber { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    public ICollection<AuditAccDetail> AuditAccDetails { get; private set; } // Inverse Navigation
}