/**
 * @class CollectionPlan
 * @description كلاس خطة التحصيل المستخدم في تنظيم وإدارة خطط التحصيل وأهدافها
 * @author OnyxQ Team
 */
public class CollectionPlan
{
    /// <summary>
    /// رقم التحصيل
    /// </summary>
    public long CollectionNumber { get; private set; }

    /// <summary>
    /// رمز العميل
    /// </summary>
    public string? CustomerCode { get; private set; }

    /// <summary>
    /// تاريخ التحصيل
    /// </summary>
    public DateTime? CollectionDate { get; private set; }

    /// <summary>
    /// الشهر
    /// </summary>
    public short? Month { get; private set; }

    /// <summary>
    /// مبلغ رصيد العميل
    /// </summary>
    public int? CustomerBalanceAmount { get; private set; }

    /// <summary>
    /// نسبة الهدف
    /// </summary>
    public int? TargetPercentage { get; private set; }

    /// <summary>
    /// مبلغ الهدف
    /// </summary>
    public int? TargetAmount { get; private set; }

    /// <summary>
    /// وصف التحصيل
    /// </summary>
    public string? CollectionDescription { get; private set; }

    /// <summary>
    /// نوع فترة الخطة
    /// </summary>
    public short PlanPeriodType { get; private set; }

    /// <summary>
    /// رقم الخطة
    /// </summary>
    public long PlanNumber { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للخطة
    /// </summary>
    public int PlanSerial { get; private set; }

    /// <summary>
    /// تاريخ البداية
    /// </summary>
    public DateTime? FromDate { get; private set; }

    /// <summary>
    /// تاريخ النهاية
    /// </summary>
    public DateTime? ToDate { get; private set; }

    /// <summary>
    /// رمز العملة
    /// </summary>
    public string? CurrencyCode { get; private set; }

    /// <summary>
    /// رمز العميل
    /// </summary>
    public string? CustomerCode2 { get; private set; }

    /// <summary>
    /// رقم الوثيقة
    /// </summary>
    public long? DocumentNumber { get; private set; }

    /// <summary>
    /// رمز مجموعة العملاء
    /// </summary>
    public long? CustomerGroupCode { get; private set; }

    /// <summary>
    /// فئة العميل
    /// </summary>
    public short? CustomerClass { get; private set; }

    /// <summary>
    /// رمز المندوب
    /// </summary>
    public long? RepresentativeCode { get; private set; }

    /// <summary>
    /// نسبة العمولة
    /// </summary>
    public int? CommissionPercentage { get; private set; }

    /// <summary>
    /// مبلغ العمولة
    /// </summary>
    public int? CommissionAmount { get; private set; }

    /// <summary>
    /// وصف العمولة
    /// </summary>
    public string? CommissionDescription { get; private set; }

    /// <summary>
    /// مبلغ التحصيل
    /// </summary>
    public int? CollectionAmount { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public long? RecordNumber { get; private set; }

    /// <summary>
    /// تاريخ الوثيقة
    /// </summary>
    public DateTime? DocumentDate { get; private set; }

    /// <summary>
    /// نوع العمولة
    /// </summary>
    public int? CommissionType { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string? ReferenceNumber { get; private set; }

    /// <summary>
    /// وصف الوثيقة
    /// </summary>
    public string? DocumentDescription { get; private set; }

    /// <summary>
    /// تسلسل الوثيقة
    /// </summary>
    public int? DocumentSequence { get; private set; }

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
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AddUserId { get; private set; }

    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime? AddDate { get; private set; }

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
    public short CompanyNumber { get; private set; }

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

    /// <summary>
    /// رقم التقرير
    /// </summary>
    public long? PrintReport { get; private set; }
} 