public class GroupDetails
{
    /// <summary>رمز المجموعة</summary>
    public string? GroupCode { get; private set; }
    /// <summary>اسم المجموعة بالعربية</summary>
    public string GroupArabicName { get; private set; }
    /// <summary>اسم المجموعة بالإنجليزية</summary>
    public string? GroupEnglishName { get; private set; }
    /// <summary>رمز المجموعة الداخلية</summary>
    public string? GroupInternalCode { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السطر</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ الإضافة</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدل السطر</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التحديث</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>رقم التقرير المرتبط</summary>
    public long? ReportNumber { get; private set; }
    /// <summary>سنة الفرع</summary>
    public short? BranchYear { get; private set; }
    /// <summary>مستخدم الفرع</summary>
    public short? BranchUser { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminal { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminal { get; private set; }
    /// <summary>نسبة الضريبة الافتراضية</summary>
    public int? DefaultTaxPercent { get; private set; }
    /// <summary>هل تتم المزامنة مع الويب</summary>
    public bool? SyncToWebFlag { get; private set; }
    /// <summary>هل يستخدم سعر البيع كسعر شراء</summary>
    public bool? UseSalePriceAsPurchasePrice { get; private set; }
    /// <summary>حد الكمية الدوارة</summary>
    public int? RollLimitQuantity { get; private set; }
}