/**
 * @class ScreenPrivilege
 * @description كلاس صلاحيات الشاشات للمستخدمين في النظام
 * @author OnyxQ Team
 */
public class ScreenPrivilege
{
    /// <summary>
    /// رقم الشاشة
    /// </summary>
    public int? ScreenNumber { get; private set; }
    
    /// <summary>
    /// معرف المستخدم
    /// </summary>
    public int? UserId { get; private set; }
    
    /// <summary>
    /// مؤشر التضمين
    /// </summary>
    public bool? IncludeFlag { get; private set; }
    
    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime? AddDate { get; private set; }
    
    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AddUserId { get; private set; }
    
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
}