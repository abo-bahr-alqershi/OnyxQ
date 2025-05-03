/**
 * @class QuestionnaireDetail
 * @description كلاس تفاصيل الاستبيانات المستخدم في إدارة وتخزين بيانات استبيانات العملاء والموظفين
 * @author OnyxQ Team
 */
public class QuestionnaireDetail
{
    /// <summary>
    /// رقم الوثيقة
    /// </summary>
    public long DocumentNumber { get; private set; }
    
    /// <summary>
    /// رقم الوثيقة المتسلسل
    /// </summary>
    public long DocumentSerial { get; private set; }
    
    /// <summary>
    /// رقم السجل
    /// </summary>
    public long RecordNumber { get; private set; }
    
    /// <summary>
    /// رمز العنصر
    /// </summary>
    public string ItemCode { get; private set; }
    
    /// <summary>
    /// رقم الاستبيان
    /// </summary>
    public long QuestionnaireNumber { get; private set; }
    
    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime? AddDate { get; private set; }
    
    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AddUserId { get; private set; }
    
    /// <summary>
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdateDate { get; private set; }
    
    /// <summary>
    /// معرف مستخدم التحديث
    /// </summary>
    public int? UpdateUserId { get; private set; }
    
    /// <summary>
    /// رقم التقرير
    /// </summary>
    public long? PrintReport { get; private set; }
    
    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpdateCounter { get; private set; }
    
    /// <summary>
    /// رقم الشركة
    /// </summary>
    public short CompanyNumber { get; private set; }
    
    /// <summary>
    /// رقم الفرع
    /// </summary>
    public int? BranchNumber { get; private set; }
    
    /// <summary>
    /// سنة الفرع
    /// </summary>
    public short BranchYear { get; private set; }
    
    /// <summary>
    /// رقم مستخدم الفرع
    /// </summary>
    public short BranchUser { get; private set; }
    
    /// <summary>
    /// اسم طرفية الإضافة
    /// </summary>
    public string? AddTerminalName { get; private set; }
    
    /// <summary>
    /// اسم طرفية التحديث
    /// </summary>
    public string? UpdateTerminalName { get; private set; }
    
    /// <summary>
    /// تاريخ الوثيقة
    /// </summary>
    public DateTime DocumentDate { get; private set; }
    
    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string? ReferenceNumber { get; private set; }
    
    /// <summary>
    /// رمز المندوب
    /// </summary>
    public string? RepresentativeCode { get; private set; }
    
    /// <summary>
    /// وصف الوثيقة
    /// </summary>
    public string? DocumentDescription { get; private set; }
    
    /// <summary>
    /// رمز العميل
    /// </summary>
    public string? CustomerCode { get; private set; }
    
    /// <summary>
    /// منشور خارجي
    /// </summary>
    public int? ExternalPost { get; private set; }
    
    /// <summary>
    /// اسم العميل
    /// </summary>
    public string? CustomerName { get; private set; }
    
    /// <summary>
    /// رقم مرجع الوثيقة
    /// </summary>
    public long? ReferenceDocumentNumber { get; private set; }
    
    /// <summary>
    /// رقم الوثيقة المتسلسل الخارجي
    /// </summary>
    public string? ExternalDocumentSerial { get; private set; }
    
    /// <summary>
    /// حقل 1
    /// </summary>
    public string? Field1 { get; private set; }
    
    /// <summary>
    /// حقل 2
    /// </summary>
    public string? Field2 { get; private set; }
    
    /// <summary>
    /// حقل 3
    /// </summary>
    public string? Field3 { get; private set; }
    
    /// <summary>
    /// حقل 4
    /// </summary>
    public string? Field4 { get; private set; }
    
    /// <summary>
    /// حقل 5
    /// </summary>
    public string? Field5 { get; private set; }
    
    /// <summary>
    /// حقل 6
    /// </summary>
    public string? Field6 { get; private set; }
    
    /// <summary>
    /// حقل 7
    /// </summary>
    public string? Field7 { get; private set; }
    
    /// <summary>
    /// حقل 8
    /// </summary>
    public string? Field8 { get; private set; }
    
    /// <summary>
    /// حقل 9
    /// </summary>
    public string? Field9 { get; private set; }
    
    /// <summary>
    /// حقل 10
    /// </summary>
    public string? Field10 { get; private set; }
    
    /// <summary>
    /// رقم السؤال
    /// </summary>
    public long QuestionNumber { get; private set; }
    
    /// <summary>
    /// رقم النموذج
    /// </summary>
    public int? ModelNumber { get; private set; }
    
    /// <summary>
    /// رقم الإجابة
    /// </summary>
    public long? AnswerNumber { get; private set; }
    
    /// <summary>
    /// الاسم المحلي للسؤال
    /// </summary>
    public string QuestionLocalName { get; private set; }
    
    /// <summary>
    /// الاسم الأجنبي للسؤال
    /// </summary>
    public string? QuestionForeignName { get; private set; }
    
    /// <summary>
    /// رقم الترتيب
    /// </summary>
    public long? OrderNumber { get; private set; }
    
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
    public long? InactiveUserId { get; private set; }
}