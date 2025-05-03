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
    public int? FormNumber { get; private set; }

    /// <summary>
    /// رقم العمود
    /// </summary>
    public int? ColumnNumber { get; private set; }

    /// <summary>
    /// اسم العمود
    /// </summary>
    public string? ColumnName { get; private set; }

    /// <summary>
    /// رمز العملة
    /// </summary>
    public string? CurrencyCode { get; private set; }

    /// <summary>
    /// نوع الوثيقة
    /// </summary>
    public int? DocumentType { get; private set; }

    /// <summary>
    /// تاريخ الوثيقة
    /// </summary>
    public DateTime? DocumentDate { get; private set; }

    /// <summary>
    /// مبلغ الدائن
    /// </summary>
    public int? CreditAmount { get; private set; }

    /// <summary>
    /// مبلغ الدائن بالعملة الأجنبية
    /// </summary>
    public int? ForeignCreditAmount { get; private set; }

    /// <summary>
    /// رمز المندوب
    /// </summary>
    public string? RepresentativeCode { get; private set; }

    /// <summary>
    /// اسم الطرفية
    /// </summary>
    public string? TerminalName { get; private set; }

    /// <summary>
    /// رقم الشركة
    /// </summary>
    public short? CompanyNumber { get; private set; }

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
} 