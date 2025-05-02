public class ScreenStyle
{
    /// <summary>رقم النظام</summary>
    public int? SystemNumber { get; private set; }
    /// <summary>رقم الشاشة</summary>
    public int? ScreenNumber { get; private set; }
    /// <summary>رقم التسمية</summary>
    public long? LabelNumber { get; private set; }
    /// <summary>رقم الشاشة الأب</summary>
    public int? ParentScreenNumber { get; private set; }
    /// <summary>هل غير نشط</summary>
    public bool? Inactive { get; private set; }
    /// <summary>هل افتراضي</summary>
    public bool? IsDefault { get; private set; }
    /// <summary>رقم الترتيب</summary>
    public int? OrderNumber { get; private set; }
    /// <summary>نوع الشاشة</summary>
    public short? ScreenType { get; private set; }
    /// <summary>اسم الملف</summary>
    public string? FileName { get; private set; }
    /// <summary>أيقونة الشاشة</summary>
    public string? ScreenIcon { get; private set; }
    /// <summary>لون الشاشة</summary>
    public string? ScreenColor { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminalName { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminalName { get; private set; }
}