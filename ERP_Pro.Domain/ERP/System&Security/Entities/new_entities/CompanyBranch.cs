/**
 * @class CompanyBranch
 * @description كلاس فروع الشركات المستخدم في تعريف وتصنيف فروع الشركة والوصول إليها من خلال التطبيق
 * @author OnyxQ Team
 */
public class CompanyBranch
{
    /// <summary>
    /// مؤشر لمجموعة الشركة
    /// </summary>
    public bool? CompanyGroup { get; private set; }
    
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
    /// الاسم المحلي للفرع
    /// </summary>
    public string? BranchLocalName { get; private set; }
    
    /// <summary>
    /// الاسم الأجنبي للفرع
    /// </summary>
    public string? BranchForeignName { get; private set; }
    
    /// <summary>
    /// معرف المستخدم
    /// </summary>
    public int? UserId { get; private set; }
    
    /// <summary>
    /// رقم الترتيب
    /// </summary>
    public long? OrderNumber { get; private set; }
    
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
    /// رقم التسمية
    /// </summary>
    public long? LabelNumber { get; private set; }
    
    /// <summary>
    /// رقم الشاشة الأب
    /// </summary>
    public int? ScreenParentNumber { get; private set; }
    
    /// <summary>
    /// مؤشر الإيقاف
    /// </summary>
    public bool? IsInactive { get; private set; }
}