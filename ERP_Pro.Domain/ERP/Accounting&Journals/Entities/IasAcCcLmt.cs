public class IasAcCcLmt
{
    /// <summary>رمز الحساب الرئيسي</summary>
    public string? AccountCode { get; private set; }
    /// <summary>رمز العملة</summary>
    public string? CurrencyCode { get; private set; }
    /// <summary>رمز مركز التكلفة</summary>
    public string? CostCenterCode { get; private set; }
    /// <summary>رقم المشروع</summary>
    public string? ProjectNumber { get; private set; }
    /// <summary>رقم النشاط</summary>
    public string? ActivityNumber { get; private set; }
    /// <summary>الحد الأدنى للمبلغ</summary>
    public int? MinAmount { get; private set; }
    /// <summary>الحد الأعلى للمبلغ</summary>
    public int? MaxAmount { get; private set; }
    /// <summary>الحد الأدنى لمبلغ الحركة</summary>
    public int? MinTransactionAmount { get; private set; }
    /// <summary>الحد الأعلى لمبلغ الحركة</summary>
    public int? MaxTransactionAmount { get; private set; }
    /// <summary>نسبة الحد الأعلى</summary>
    public int? MaxLimitPercent { get; private set; }
    /// <summary>الحد الأعلى الممكن</summary>
    public int? MaxLimitPossible { get; private set; }
    /// <summary>رقم الفرع</summary>
    public int? BranchNumber { get; private set; }
    /// <summary>هل يسمح بتجاوز الحد</summary>
    public bool? ExceedLimit { get; private set; }
    /// <summary>نوع الحساب (مدين/دائن)</summary>
    public bool? DebitOrCredit { get; private set; }
    /// <summary>وصف الحد</summary>
    public string? LimitDescription { get; private set; }
    /// <summary>رمز الحساب التفصيلي</summary>
    public string? AccountDetailCode { get; private set; }
    /// <summary>نوع الحساب التفصيلي</summary>
    public int? AccountDetailType { get; private set; }
    /// <summary>مبلغ التسهيلات</summary>
    public int? FacilityAmount { get; private set; }
    /// <summary>حالة التسهيلات</summary>
    public bool? FacilityStatus { get; private set; }
    /// <summary>هل الحساب غير نشط</summary>
    public bool? Inactive { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ إضافة السجل</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>رقم تقرير الطباعة</summary>
    public long? PrintReport { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminalName { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminalName { get; private set; }
    /// <summary>المبلغ اليومي</summary>
    public int? DailyAmount { get; private set; }
    /// <summary>المبلغ الشهري</summary>
    public int? MonthlyAmount { get; private set; }
    /// <summary>المبلغ السنوي</summary>
    public int? AnnualAmount { get; private set; }
    /// <summary>رمز الحساب التفصيلي الفرعي</summary>
    public string? AccountDetailSubCode { get; private set; }
    /// <summary>حالة الترحيل الخارجي</summary>
    public int? ExternalPost { get; private set; }
}