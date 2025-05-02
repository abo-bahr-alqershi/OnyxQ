public class VoucherBranch
{
    /// <summary>نوع السند</summary>
    public bool VoucherType { get; private set; }
    /// <summary>نوع الدفع للسند</summary>
    public bool VoucherPayType { get; private set; }
    /// <summary>رقم السند</summary>
    public long VoucherNumber { get; private set; }
    /// <summary>رقم السند النقدي</summary>
    public long CashNumber { get; private set; }
    /// <summary>رمز العملة</summary>
    public string CurrencyCode { get; private set; }
    /// <summary>الرقم التسلسلي للسند</summary>
    public long? VoucherSerial { get; private set; }
    /// <summary>تاريخ السند</summary>
    public DateTime VoucherDate { get; private set; }
    /// <summary>قيمة النقد بالعملة المحلية</summary>
    public int? CashAmount { get; private set; }
    /// <summary>قيمة النقد بالعملة الأجنبية</summary>
    public int? CashAmountForeign { get; private set; }
    /// <summary>سعر الصرف</summary>
    public int? ExchangeRate { get; private set; }
    /// <summary>هل السند مرحل</summary>
    public bool? IsVoucherPosted { get; private set; }
    /// <summary>رقم المرجع</summary>
    public string? ReferenceNumber { get; private set; }
    /// <summary>اسم المرجع</summary>
    public string? ReferenceName { get; private set; }
    /// <summary>وصف السند</summary>
    public string? Description { get; private set; }
    /// <summary>اسم المستلم</summary>
    public string? ReceiverName { get; private set; }
    /// <summary>هل السند احتياطي</summary>
    public bool? IsStandBy { get; private set; }
    /// <summary>هل السند محول</summary>
    public bool? IsTransfer { get; private set; }
    /// <summary>نوع الشيك</summary>
    public int? ChequeType { get; private set; }
    /// <summary>رقم التحصيل</summary>
    public long? CollectionNumber { get; private set; }
    /// <summary>رمز مركز التكلفة</summary>
    public string? CostCenterCode { get; private set; }
    /// <summary>رقم المشروع</summary>
    public string? ProjectNumber { get; private set; }
    /// <summary>رقم النشاط</summary>
    public string? ActivityNumber { get; private set; }
    /// <summary>عدد المرفقات</summary>
    public short? AttachmentNumber { get; private set; }
    /// <summary>رقم تقرير الطباعة</summary>
    public long? PrintReport { get; private set; }
    /// <summary>نسبة العمولة</summary>
    public decimal? CommissionPercent { get; private set; }
    /// <summary>رقم السند المرتبط بالدفع</summary>
    public long? PaymentVoucherNumber { get; private set; }
    /// <summary>تاريخ السند المرتبط بالدفع</summary>
    public DateTime? PaymentVoucherDate { get; private set; }
    /// <summary>هل تم نقل الشيك للدفع</summary>
    public bool? IsChequeMovedForPayment { get; private set; }
    /// <summary>هل تم نقل الشيك للتحصيل</summary>
    public bool? IsChequeMovedForCollection { get; private set; }
    /// <summary>رقم نوع السند الفرعي</summary>
    public short? VoucherTypeNumber { get; private set; }
    /// <summary>حالة الترحيل الخارجي</summary>
    public int? ExternalPost { get; private set; }
    /// <summary>هل يوجد مرجع تدقيق</summary>
    public bool? HasAuditReference { get; private set; }
    /// <summary>وصف مرجع التدقيق</summary>
    public string? AuditReferenceDescription { get; private set; }
    /// <summary>رقم مستخدم مرجع التدقيق</summary>
    public int? AuditReferenceUserId { get; private set; }
    /// <summary>تاريخ مرجع التدقيق</summary>
    public DateTime? AuditReferenceDate { get; private set; }
    /// <summary>حقل إضافي 1</summary>
    public string? Field1 { get; private set; }
    /// <summary>حقل إضافي 2</summary>
    public string? Field2 { get; private set; }
    /// <summary>حقل إضافي 3</summary>
    public string? Field3 { get; private set; }
    /// <summary>حقل إضافي 4</summary>
    public string? Field4 { get; private set; }
    /// <summary>حقل إضافي 5</summary>
    public string? Field5 { get; private set; }
    /// <summary>حقل إضافي 6</summary>
    public string? Field6 { get; private set; }
    /// <summary>حقل إضافي 7</summary>
    public string? Field7 { get; private set; }
    /// <summary>حقل إضافي 8</summary>
    public string? Field8 { get; private set; }
    /// <summary>حقل إضافي 9</summary>
    public string? Field9 { get; private set; }
    /// <summary>حقل إضافي 10</summary>
    public string? Field10 { get; private set; }
    /// <summary>رقم المستخدم الذي رحل السند</summary>
    public int? PostedByUserId { get; private set; }
    /// <summary>تاريخ الترحيل</summary>
    public DateTime? PostDate { get; private set; }
    /// <summary>رقم المستخدم الذي ألغى الترحيل</summary>
    public int? UnpostedByUserId { get; private set; }
    /// <summary>تاريخ إلغاء الترحيل</summary>
    public DateTime? UnpostDate { get; private set; }
    /// <summary>تسلسل المستند</summary>
    public long? DocumentSequence { get; private set; }
    /// <summary>رقم فرع المستند</summary>
    public short? DocumentBranchNumber { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل على السجل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>رقم الشركة</summary>
    public short? CompanyNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public short? BranchNumber { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminalName { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminalName { get; private set; }
}