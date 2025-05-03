/**
 * @class CityDistance
 * @description كلاس المسافات بين المدن المستخدم في تخزين وإدارة المسافات والفترات الزمنية بين المدن
 * @author OnyxQ Team
 */
public class CityDistance
{
    /// <summary>
    /// رقم المدينة المصدر
    /// </summary>
    public long? FromCityNumber { get; private set; }

    /// <summary>
    /// رقم المدينة الوجهة
    /// </summary>
    public long? ToCityNumber { get; private set; }

    /// <summary>
    /// عدد أيام المسافة
    /// </summary>
    public long? DistanceDays { get; private set; }

    /// <summary>
    /// رقم التسمية
    /// </summary>
    public int? LabelNumber { get; private set; }

    /// <summary>
    /// حرف العمود
    /// </summary>
    public string? ColumnCharacter { get; private set; }

    /// <summary>
    /// رمز العمود
    /// </summary>
    public string? ColumnCode { get; private set; }

    /// <summary>
    /// اسم العمود
    /// </summary>
    public string? ColumnName { get; private set; }

    /// <summary>
    /// تاريخ النهاية
    /// </summary>
    public DateTime? ToDate { get; private set; }

    /// <summary>
    /// رقم الفترة
    /// </summary>
    public short? PeriodNumber { get; private set; }

    /// <summary>
    /// رقم السنة
    /// </summary>
    public short? YearNumber { get; private set; }

    /// <summary>
    /// الحالة
    /// </summary>
    public bool? Status { get; private set; }

    /// <summary>
    /// معرف مستخدم إغلاق الفترة
    /// </summary>
    public int? PeriodCloseUserId { get; private set; }

    /// <summary>
    /// تاريخ إغلاق الفترة
    /// </summary>
    public DateTime? PeriodCloseDate { get; private set; }

    /// <summary>
    /// معرف مستخدم إلغاء إغلاق الفترة
    /// </summary>
    public int? PeriodUncloseUserId { get; private set; }

    /// <summary>
    /// تاريخ إلغاء إغلاق الفترة
    /// </summary>
    public DateTime? PeriodUncloseDate { get; private set; }

    /// <summary>
    /// عداد إغلاق الفترة
    /// </summary>
    public long? PeriodCloseCounter { get; private set; }

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
    /// رقم الشركة
    /// </summary>
    public short CompanyNumber { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public int BranchNumber { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public short? BranchYear { get; private set; }

    /// <summary>
    /// رقم مستخدم الفرع
    /// </summary>
    public short? BranchUser { get; private set; }

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