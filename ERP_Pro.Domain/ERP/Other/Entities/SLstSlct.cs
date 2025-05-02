public class SelectionList
{
    /// <summary>اسم القائمة</summary>
    public string? ListName { get; private set; }
    /// <summary>جملة الاستعلام</summary>
    public string ListSql { get; private set; }
    /// <summary>شرط الاستعلام</summary>
    public string? ListWhere { get; private set; }
    /// <summary>ترتيب النتائج</summary>
    public string? ListOrderBy { get; private set; }
    /// <summary>جملة الاستعلام الخاصة</summary>
    public string? ListSqlPrivate { get; private set; }
    /// <summary>رقم الشاشة</summary>
    public long? ScreenNumber { get; private set; }
    /// <summary>رقم الشاشة الأب</summary>
    public long? ScreenParentNumber { get; private set; }
    /// <summary>هل القائمة غير نشطة</summary>
    public bool? Inactive { get; private set; }
    /// <summary>رقم الترتيب</summary>
    public int? OrderNumber { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminal { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminal { get; private set; }
}