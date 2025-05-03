/**
 * @class CheckDocumentInOutQuantityDetail
 * @description كلاس تفاصيل فحص كميات المستندات الواردة والصادرة المستخدم في تتبع وإدارة حركة المخزون
 * @author OnyxQ Team
 */
public class CheckDocumentInOutQuantityDetail
{
    /// <summary>
    /// رقم الوثيقة
    /// </summary>
    public long DocumentNumber { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للوثيقة
    /// </summary>
    public long DocumentSerial { get; private set; }

    /// <summary>
    /// رمز العنصر
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// وحدة العنصر
    /// </summary>
    public string? ItemUnit { get; private set; }

    /// <summary>
    /// حجم العبوة
    /// </summary>
    public long PackageSize { get; private set; }

    /// <summary>
    /// كمية العبوة
    /// </summary>
    public int? PackageQuantity { get; private set; }

    /// <summary>
    /// رمز المستودع
    /// </summary>
    public long? WarehouseCode { get; private set; }

    /// <summary>
    /// تاريخ الانتهاء
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// رقم الدفعة
    /// </summary>
    public string? BatchNumber { get; private set; }

    /// <summary>
    /// كمية العنصر
    /// </summary>
    public int? ItemQuantity { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public long? RecordNumber { get; private set; }

    /// <summary>
    /// الباركود
    /// </summary>
    public string? Barcode { get; private set; }

    /// <summary>
    /// نوع الوثيقة المرجعية
    /// </summary>
    public int? ReferenceDocumentType { get; private set; }

    /// <summary>
    /// نوع قيد الوثيقة المرجعية
    /// </summary>
    public int? ReferenceDocumentJournalType { get; private set; }

    /// <summary>
    /// رقم الوثيقة المرجعية
    /// </summary>
    public long? ReferenceDocumentNumber { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للوثيقة المرجعية
    /// </summary>
    public long? ReferenceDocumentSerial { get; private set; }

    /// <summary>
    /// الترحيل الخارجي
    /// </summary>
    public int? ExternalPost { get; private set; }

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
    /// رقم السجل المرجعي
    /// </summary>
    public long? ReferenceRecordNumber { get; private set; }

    /// <summary>
    /// تسلسل الوثيقة
    /// </summary>
    public int? DocumentSequence { get; private set; }

    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpdateCounter { get; private set; }

    /// <summary>
    /// رقم العنصر في المجموعة
    /// </summary>
    public string? KitItemNumber { get; private set; }

    /// <summary>
    /// عنصر المجموعة
    /// </summary>
    public int? KitItem { get; private set; }

    /// <summary>
    /// مؤشر التلف
    /// </summary>
    public bool? DamageFlag { get; private set; }

    /// <summary>
    /// رمز الفرع
    /// </summary>
    public string? BranchCode { get; private set; }

    /// <summary>
    /// وارد/صادر
    /// </summary>
    public bool? InOut { get; private set; }

    /// <summary>
    /// نوع الطباعة
    /// </summary>
    public short? PrintType { get; private set; }

    /// <summary>
    /// رقم النوع
    /// </summary>
    public short? TypeNumber { get; private set; }

    /// <summary>
    /// وحدة عنصر المجموعة
    /// </summary>
    public string? KitItemUnit { get; private set; }

    /// <summary>
    /// حجم عبوة المجموعة
    /// </summary>
    public long? KitPackageSize { get; private set; }

    /// <summary>
    /// رقم وثيقة التحضير المرجعية
    /// </summary>
    public long? ReferencePrepareDocumentNumber { get; private set; }

    /// <summary>
    /// الرقم المتسلسل لوثيقة التحضير المرجعية
    /// </summary>
    public long? ReferencePrepareDocumentSerial { get; private set; }
} 