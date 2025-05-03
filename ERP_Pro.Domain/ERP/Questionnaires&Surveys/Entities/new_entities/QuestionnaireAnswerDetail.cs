/**
 * @class QuestionnaireAnswerDetail
 * @description كلاس تفاصيل إجابات الاستبيانات المستخدم في تخزين ومعالجة إجابات المستخدمين على الاستبيانات في النظام
 * @author OnyxQ Team
 */
public class QuestionnaireAnswerDetail
{
    /// <summary>
    /// رقم السجل
    /// </summary>
    public int? RecordNumber { get; private set; }
    
    /// <summary>
    /// رقم النموذج
    /// </summary>
    public int ModelNumber { get; private set; }
    
    /// <summary>
    /// رقم الإجابة
    /// </summary>
    public long AnswerNumber { get; private set; }
    
    /// <summary>
    /// الاسم المحلي للإجابة
    /// </summary>
    public string AnswerLocalName { get; private set; }
    
    /// <summary>
    /// الاسم الأجنبي للإجابة
    /// </summary>
    public string? AnswerForeignName { get; private set; }
    
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
    
    /// <summary>
    /// الاسم المحلي للنموذج
    /// </summary>
    public string? ModelLocalName { get; private set; }
    
    /// <summary>
    /// الاسم الأجنبي للنموذج
    /// </summary>
    public string? ModelForeignName { get; private set; }
    
    /// <summary>
    /// رقم الوثيقة المتسلسل
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
    /// كمية العنصر
    /// </summary>
    public int? ItemQuantity { get; private set; }
    
    /// <summary>
    /// رمز العميل
    /// </summary>
    public string? CustomerCode { get; private set; }
    
    /// <summary>
    /// رقم مرجع الوثيقة المتسلسل
    /// </summary>
    public long? ReferenceDocumentSerial { get; private set; }
    
    /// <summary>
    /// مؤشر المعالجة
    /// </summary>
    public int? ProcessFlag { get; private set; }
    
    /// <summary>
    /// تاريخ الوثيقة
    /// </summary>
    public DateTime? DocumentDate { get; private set; }
    
    /// <summary>
    /// رقم مرجع الوثيقة
    /// </summary>
    public long? ReferenceDocumentNumber { get; private set; }
    
    /// <summary>
    /// رقم المعاملة
    /// </summary>
    public int TransactionNumber { get; private set; }
    
    /// <summary>
    /// رقم الوثيقة
    /// </summary>
    public int DocumentNumber { get; private set; }
    
    /// <summary>
    /// رقم الوثيقة المتسلسل الداخلي
    /// </summary>
    public int DocumentSerial { get; private set; }
    
    /// <summary>
    /// نوع التأكيد
    /// </summary>
    public bool? ConfirmationType { get; private set; }
    
    /// <summary>
    /// معرف مستخدم التأكيد
    /// </summary>
    public int? ConfirmationUserId { get; private set; }
    
    /// <summary>
    /// تاريخ التأكيد
    /// </summary>
    public DateTime? ConfirmationDate { get; private set; }
    
    /// <summary>
    /// وصف التأكيد
    /// </summary>
    public string? ConfirmationDescription { get; private set; }
    
    /// <summary>
    /// رقم الترتيب
    /// </summary>
    public int? OrderNumber { get; private set; }
    
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
    
    /// <summary>
    /// رقم السائق
    /// </summary>
    public long? DriverNumber { get; private set; }
    
    /// <summary>
    /// تاريخ استلام الفاتورة
    /// </summary>
    public DateTime? ReceiveInvoiceDate { get; private set; }
    
    /// <summary>
    /// رقم الكود
    /// </summary>
    public int? CodeNumber { get; private set; }
    
    /// <summary>
    /// الاسم المحلي للكود
    /// </summary>
    public string CodeLocalName { get; private set; }
    
    /// <summary>
    /// الاسم الأجنبي للكود
    /// </summary>
    public string? CodeForeignName { get; private set; }
    
    /// <summary>
    /// ملاحظات
    /// </summary>
    public string? Notes { get; private set; }
    
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
    /// الاسم المحلي للنوع
    /// </summary>
    public string TypeLocalName { get; private set; }
    
    /// <summary>
    /// الاسم الأجنبي للنوع
    /// </summary>
    public string TypeForeignName { get; private set; }
}