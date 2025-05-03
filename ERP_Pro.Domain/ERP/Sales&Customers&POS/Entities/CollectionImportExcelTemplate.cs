/**
 * @class CollectionImportExcelTemplate
 * @description كلاس قالب استيراد ملفات Excel للتحصيل المستخدم في تنظيم وإدارة عملية استيراد بيانات التحصيل من ملفات Excel
 * @author OnyxQ Team
 */
public class CollectionImportExcelTemplate
{
    /// <summary>
    /// رقم النموذج
    /// </summary>
    public int FormNumber { get; private set; }

    /// <summary>
    /// رقم العمود
    /// </summary>
    public int ColumnNumber { get; private set; }

    /// <summary>
    /// اسم العمود
    /// </summary>
    public string ColumnName { get; private set; }

    /// <summary>
    /// نوع البيانات
    /// </summary>
    public string DataType { get; private set; }

    /// <summary>
    /// إلزامي
    /// </summary>
    public bool IsRequired { get; private set; }

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
}