public class PeriodMaster
{
    /// <summary>عدد الفترات</summary>
    public short PeriodCount { get; private set; }

    /// <summary>نوع الفترة</summary>
    public bool? PeriodType { get; private set; }

    /// <summary>رقم أول فترة</summary>
    public short FirstPeriodNumber { get; private set; }

    /// <summary>رقم آخر فترة</summary>
    public short? LastPeriodNumber { get; private set; }

    /// <summary>رقم أول سنة</summary>
    public short FirstYearNumber { get; private set; }

    /// <summary>رقم آخر سنة</summary>
    public short LastYearNumber { get; private set; }

    /// <summary>إغلاق الأرباح والخسائر</summary>
    public bool? ProfitLossClosed { get; private set; }

    /// <summary>رقم المستخدم الذي أغلق الأرباح والخسائر</summary>
    public int? ProfitLossClosedUserId { get; private set; }

    /// <summary>تاريخ إغلاق الأرباح والخسائر</summary>
    public DateTime? ProfitLossClosedDate { get; private set; }

    /// <summary>إغلاق المخزون</summary>
    public bool? InventoryClosed { get; private set; }

    /// <summary>رقم المستخدم الذي أغلق المخزون</summary>
    public int? InventoryClosedUserId { get; private set; }

    /// <summary>تاريخ إغلاق المخزون</summary>
    public DateTime? InventoryClosedDate { get; private set; }

    /// <summary>إغلاق السنة</summary>
    public bool? YearClosed { get; private set; }

    /// <summary>رقم المستخدم الذي أغلق السنة</summary>
    public int? YearClosedUserId { get; private set; }

    /// <summary>تاريخ إغلاق السنة</summary>
    public DateTime? YearClosedDate { get; private set; }

    /// <summary>إغلاق الأصول الثابتة</summary>
    public bool? FixedAssetsClosed { get; private set; }

    /// <summary>رقم المستخدم الذي أغلق الأصول الثابتة</summary>
    public int? FixedAssetsClosedUserId { get; private set; }

    /// <summary>تاريخ إغلاق الأصول الثابتة</summary>
    public DateTime? FixedAssetsClosedDate { get; private set; }

    /// <summary>فتح سنة جديدة</summary>
    public bool? OpenNewYear { get; private set; }

    /// <summary>رقم المستخدم الذي فتح السنة الجديدة</summary>
    public int? OpenNewYearUserId { get; private set; }

    /// <summary>تاريخ فتح السنة الجديدة</summary>
    public DateTime? OpenNewYearDate { get; private set; }

    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }

    /// <summary>تاريخ الإضافة</summary>
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

    /// <summary>بدء العمل في المخزون</summary>
    public bool? InventoryStartWork { get; private set; }

    /// <summary>رقم المستخدم الذي بدأ العمل في المخزون</summary>
    public int? InventoryStartWorkUserId { get; private set; }

    /// <summary>تاريخ بدء العمل في المخزون</summary>
    public DateTime? InventoryStartWorkDate { get; private set; }

    /// <summary>طريقة إغلاق المخزون</summary>
    public bool? InventoryCloseMethod { get; private set; }
}