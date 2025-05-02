public class TaxAccount
{
    /// <summary>رمز الحساب الرئيسي المرتبط بالضريبة</summary>
    public string AccountCode { get; private set; }
    /// <summary>رقم الضريبة</summary>
    public int? TaxNumber { get; private set; }
    /// <summary>رقم الوكالة</summary>
    public int AgencyNumber { get; private set; }
    /// <summary>نسبة الضريبة</summary>
    public int TaxPercent { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminalName { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل على السجل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>رقم تقرير الطباعة</summary>
    public int? PrintReport { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminalName { get; private set; }
    /// <summary>نوع السند</summary>
    public bool VoucherType { get; private set; }
    /// <summary>نوع الدفع للسند</summary>
    public bool VoucherPaymentType { get; private set; }
    /// <summary>رقم السند النقدي</summary>
    public long CashNumber { get; private set; }
    /// <summary>رقم المستند</summary>
    public long DocumentNumber { get; private set; }
    /// <summary>الرقم التسلسلي للمستند</summary>
    public long? DocumentSerial { get; private set; }
    /// <summary>رمز الحساب الرئيسي</summary>
    public string MainAccountCode { get; private set; }
    /// <summary>رمز الحساب التفصيلي</summary>
    public string? AccountDetailCode { get; private set; }
    /// <summary>رمز الحساب التفصيلي الفرعي</summary>
    public string? AccountDetailSubCode { get; private set; }
    /// <summary>نوع الحساب التفصيلي</summary>
    public bool AccountDetailType { get; private set; }
    /// <summary>رمز العملة</summary>
    public string CurrencyCode { get; private set; }
    /// <summary>سعر العملة</summary>
    public int? CurrencyRate { get; private set; }
    /// <summary>المبلغ بالعملة المحلية</summary>
    public int? AmountLocal { get; private set; }
    /// <summary>المبلغ بالعملة الأجنبية</summary>
    public int? AmountForeign { get; private set; }
    /// <summary>وصف المستند</summary>
    public string? DocumentDescription { get; private set; }
    /// <summary>رمز مركز التكلفة</summary>
    public string? CostCenterCode { get; private set; }
    /// <summary>رقم المشروع</summary>
    public string? ProjectNumber { get; private set; }
    /// <summary>رقم النشاط</summary>
    public string? ActivityNumber { get; private set; }
    /// <summary>رمز التقرير</summary>
    public string? ReportCode { get; private set; }
    /// <summary>رقم التحصيل</summary>
    public long? CollectionNumber { get; private set; }
    /// <summary>تسلسل المستند</summary>
    public long? DocumentSequence { get; private set; }
    /// <summary>رقم فرع المستند</summary>
    public int? DocumentBranchNumber { get; private set; }
    /// <summary>رقم الشركة</summary>
    public short CompanyNumber { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int? BranchNumber { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    public Account Account { get; private set; } // Navigation
}