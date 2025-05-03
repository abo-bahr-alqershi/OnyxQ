/**
 * @class CreditLimitTemporary
 * @description كلاس حد الائتمان المؤقت المستخدم في تخزين وإدارة حدود الائتمان المؤقتة للعملاء
 * @author OnyxQ Team
 */
public class CreditLimitTemporary
{
    /// <summary>
    /// رمز العميل
    /// </summary>
    public string CustomerCode { get; private set; }

    /// <summary>
    /// رمز العملة
    /// </summary>
    public string? CurrencyCode { get; private set; }

    /// <summary>
    /// رقم الوثيقة
    /// </summary>
    public long? DocumentNumber { get; private set; }

    /// <summary>
    /// نوع الوثيقة
    /// </summary>
    public int? DocumentType { get; private set; }

    /// <summary>
    /// نوع قيد الوثيقة
    /// </summary>
    public long? DocumentJournalType { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للوثيقة
    /// </summary>
    public long? DocumentSerial { get; private set; }

    /// <summary>
    /// تاريخ الوثيقة
    /// </summary>
    public DateTime? DocumentDate { get; private set; }

    /// <summary>
    /// مبلغ المدين
    /// </summary>
    public int? DebitAmount { get; private set; }

    /// <summary>
    /// مبلغ المدين بالعملة الأجنبية
    /// </summary>
    public int? ForeignDebitAmount { get; private set; }

    /// <summary>
    /// وصف الوثيقة
    /// </summary>
    public string? DocumentDescription { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string? ReferenceNumber { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public long? RecordNumber { get; private set; }

    /// <summary>
    /// رمز مركز التكلفة
    /// </summary>
    public string? CostCenterCode { get; private set; }

    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string? ProjectNumber { get; private set; }

    /// <summary>
    /// رقم النشاط
    /// </summary>
    public string? ActivityNumber { get; private set; }

    /// <summary>
    /// تم تقييم الشيك
    /// </summary>
    public bool? ChequeValued { get; private set; }

    /// <summary>
    /// رقم الفترة
    /// </summary>
    public int? PeriodNumber { get; private set; }

    /// <summary>
    /// اسم الطرفية
    /// </summary>
    public string? TerminalName { get; private set; }

    /// <summary>
    /// تاريخ استحقاق الوثيقة
    /// </summary>
    public DateTime? DocumentDueDate { get; private set; }

    /// <summary>
    /// نوع الوثيقة المرجعية
    /// </summary>
    public int? ReferenceDocumentType { get; private set; }

    /// <summary>
    /// تاريخ الدفع
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// رمز المندوب
    /// </summary>
    public string? RepresentativeCode { get; private set; }

    /// <summary>
    /// مبلغ العمولة
    /// </summary>
    public int? CommissionAmount { get; private set; }

    /// <summary>
    /// رقم التحصيل
    /// </summary>
    public long? CollectionNumber { get; private set; }

    /// <summary>
    /// رقم الوثيقة المرجعية
    /// </summary>
    public long? ReferenceDocumentNumber { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للوثيقة المرجعية
    /// </summary>
    public long? ReferenceDocumentSerial { get; private set; }

    /// <summary>
    /// رقم الشركة
    /// </summary>
    public short? CompanyNumber { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public int? BranchNumber { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public short? BranchYear { get; private set; }

    /// <summary>
    /// رقم مستخدم الفرع
    /// </summary>
    public short? BranchUser { get; private set; }
} 