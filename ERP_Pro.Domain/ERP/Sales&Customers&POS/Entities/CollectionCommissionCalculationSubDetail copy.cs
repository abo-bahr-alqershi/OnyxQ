/**
 * @class CollectionCommissionCalculationSubDetail
 * @description كلاس تفاصيل حساب عمولات التحصيل الفرعية المستخدم في تخزين وإدارة تفاصيل حساب العمولات للمحصلين
 * @author OnyxQ Team
 */
public class CollectionCommissionCalculationSubDetail
{
    /// <summary>
    /// نوع العمولة
    /// </summary>
    public int? CommissionType { get; private set; }

    /// <summary>
    /// رقم التحصيل
    /// </summary>
    public long? CollectionNumber { get; private set; }

    /// <summary>
    /// تاريخ البداية
    /// </summary>
    public DateTime? FromDate { get; private set; }

    /// <summary>
    /// تاريخ النهاية
    /// </summary>
    public DateTime? ToDate { get; private set; }

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
    /// رمز العميل
    /// </summary>
    public string? CustomerCode { get; private set; }

    /// <summary>
    /// رقم الفاتورة
    /// </summary>
    public long? BillNumber { get; private set; }

    /// <summary>
    /// رقم الفاتورة المتسلسل
    /// </summary>
    public int? BillSerial { get; private set; }

    /// <summary>
    /// تاريخ الفاتورة
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public long? VoucherNumber { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للسند
    /// </summary>
    public int? VoucherSerial { get; private set; }

    /// <summary>
    /// تاريخ السند
    /// </summary>
    public DateTime? VoucherDate { get; private set; }

    /// <summary>
    /// رقم النقدية
    /// </summary>
    public long? CashNumber { get; private set; }

    /// <summary>
    /// مبلغ التحصيل
    /// </summary>
    public int? CollectionAmount { get; private set; }

    /// <summary>
    /// النسبة من
    /// </summary>
    public int? FromPercentage { get; private set; }

    /// <summary>
    /// النسبة إلى
    /// </summary>
    public int? ToPercentage { get; private set; }

    /// <summary>
    /// النسبة
    /// </summary>
    public int? Percentage { get; private set; }

    /// <summary>
    /// نوع مبلغ العمولة
    /// </summary>
    public short? CommissionAmountType { get; private set; }

    /// <summary>
    /// نسبة العمولة
    /// </summary>
    public int? CommissionPercentage { get; private set; }

    /// <summary>
    /// مبلغ العمولة
    /// </summary>
    public int? CommissionAmount { get; private set; }

    /// <summary>
    /// تسلسل الوثيقة
    /// </summary>
    public int? DocumentSequence { get; private set; }

    /// <summary>
    /// القيمة من
    /// </summary>
    public int? FromValue { get; private set; }

    /// <summary>
    /// القيمة إلى
    /// </summary>
    public int? ToValue { get; private set; }

    /// <summary>
    /// وصف الشريحة
    /// </summary>
    public string? SliceDescription { get; private set; }

    /// <summary>
    /// رقم شريحة العمولة
    /// </summary>
    public int? CommissionSliceNumber { get; private set; }

    /// <summary>
    /// الاسم المحلي لنوع العمولة
    /// </summary>
    public string? CommissionTypeLocalName { get; private set; }

    /// <summary>
    /// الاسم الأجنبي لنوع العمولة
    /// </summary>
    public string? CommissionTypeForeignName { get; private set; }

    /// <summary>
    /// نوع عمولة العميل
    /// </summary>
    public short? CustomerCommissionType { get; private set; }

    /// <summary>
    /// نوع عمولة التحصيل
    /// </summary>
    public short? CollectionCommissionType { get; private set; }

    /// <summary>
    /// نوع توزيع المدفوعات
    /// </summary>
    public short? PaidDistributionType { get; private set; }

    /// <summary>
    /// نوع شرائح العمولة
    /// </summary>
    public short? CommissionSlicesType { get; private set; }

    /// <summary>
    /// فصل الهدف والهدف الإضافي
    /// </summary>
    public bool? SeparateTargetAdditionalTarget { get; private set; }

    /// <summary>
    /// طريقة حساب عمولة الهدف
    /// </summary>
    public bool? CommissionCalculationTargetMethod { get; private set; }

    /// <summary>
    /// طريقة حساب عمولة الهدف الإضافي
    /// </summary>
    public bool? CommissionCalculationAdditionalTargetMethod { get; private set; }

    /// <summary>
    /// مؤشر الإيقاف
    /// </summary>
    public bool? IsInactive { get; private set; }

    /// <summary>
    /// سبب الإيقاف
    /// </summary>
    public string? InactiveReason { get; private set; }

    /// <summary>
    /// تاريخ الإيقاف
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// معرف مستخدم الإيقاف
    /// </summary>
    public int? InactiveUserId { get; private set; }

    /// <summary>
    /// وصف العمولة
    /// </summary>
    public string? CommissionDescription { get; private set; }

    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AddUserId { get; private set; }

    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime? AddDate { get; private set; }

    /// <summary>
    /// معرف مستخدم التحديث
    /// </summary>
    public int? UpdateUserId { get; private set; }

    /// <summary>
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdateDate { get; private set; }

    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpdateCounter { get; private set; }

    /// <summary>
    /// رقم التقرير
    /// </summary>
    public long? PrintReport { get; private set; }

    /// <summary>
    /// اسم طرفية الإضافة
    /// </summary>
    public string? AddTerminalName { get; private set; }

    /// <summary>
    /// اسم طرفية التحديث
    /// </summary>
    public string? UpdateTerminalName { get; private set; }
} 