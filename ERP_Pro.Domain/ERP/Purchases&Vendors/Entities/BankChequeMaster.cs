public class BankChequeMaster
{
    /// <summary> رقم البنك </summary>
    public long? BankNumber { get; private set; }
    /// <summary> رقم دفتر الشيكات </summary>
    public long BookNumber { get; private set; }
    /// <summary> أول رقم شيك في الدفتر </summary>
    public long? FirstChequeNumber { get; private set; }
    /// <summary> آخر رقم شيك في الدفتر </summary>
    public long? LastChequeNumber { get; private set; }
    /// <summary> رقم مرجعي إضافي </summary>
    public string? ReferenceNumber { get; private set; }
    /// <summary> رمز العملة </summary>
    public string? CurrencyCode { get; private set; }
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
    public long? DocumentNumber { get; private set; }
    public long DocumentSerial { get; private set; }
    public long? DocumentMasterSequence { get; private set; }
    public long? DocumentDetailSequence { get; private set; }
    public long? RecordNumber { get; private set; }
    public string? AccountCode { get; private set; }
    public string? AccountCodeDetail { get; private set; }
    public short? AccountDetailType { get; private set; }
    /// <summary> رمز العملة </summary>
    public string? CurrencyCode { get; private set; }
    public long? ChequeNumber { get; private set; }
    public DateTime? ChequeDate { get; private set; }
    public int? DebitAmount { get; private set; }
    public int? CreditAmount { get; private set; }
    public string? NoteBankNumber { get; private set; }
    /// <summary> رقم مرجعي إضافي </summary>
    public string? ReferenceNumber { get; private set; }
    public string? DocumentDetailDescription { get; private set; }
    public bool? IdentifyFlag { get; private set; }
    public bool? IdentifyManualFlag { get; private set; }
    /// <summary> المستخدم الذي أضاف السطر </summary>
    public int AddedUserId { get; private set; }
    /// <summary> تاريخ الإضافة </summary>
    public DateTime AddedDate { get; private set; }
    /// <summary> اسم الجهاز عند الإضافة </summary>
    public string? AddedTerminal { get; private set; }
    /// <summary> المستخدم الذي عدل السطر </summary>
    public int? UpdatedUserId { get; private set; }
    /// <summary> تاريخ آخر تعديل </summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary> اسم الجهاز عند التعديل </summary>
    public string? UpdatedTerminal { get; private set; }
    /// <summary> عدد مرات التحديث </summary>
    public long? UpdateCount { get; private set; }
    public int BranchNumber { get; private set; }
    public short BranchYear { get; private set; }
    public short? BranchUser { get; private set; }
    public string? CostCenterCode { get; private set; }
    public string? ProjectNumber { get; private set; }
    public string? ActivityNumber { get; private set; }
    public int? DocumentTypeReference { get; private set; }
    public long? DocumentNumberReference { get; private set; }
    public long? DocumentSerialReference { get; private set; }
    public long? DocumentDetailSequenceReference { get; private set; }
    public ICollection<BankChequeDetail> BankChequeDetails { get; private set; } // Inverse Navigation
}