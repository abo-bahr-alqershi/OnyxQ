namespace ERP_Pro.Domain.SettingsParameters.Enums;

/// <summary>
/// أنواع تدقيق التسلسل
/// </summary>
public enum SequenceAuditTypeEnum
{
    /// <summary>
    /// إنشاء
    /// </summary>
    Created = 1,
    
    /// <summary>
    /// تعديل
    /// </summary>
    Updated = 2,
    
    /// <summary>
    /// تغيير الحالة
    /// </summary>
    StatusChanged = 3,
    
    /// <summary>
    /// إعادة ضبط العداد
    /// </summary>
    CounterReset = 4,
    
    /// <summary>
    /// حجز رقم
    /// </summary>
    NumberReserved = 5,
    
    /// <summary>
    /// تحرير رقم محجوز
    /// </summary>
    NumberReleased = 6,
    
    /// <summary>
    /// إلغاء رقم
    /// </summary>
    NumberCanceled = 7,
    
    /// <summary>
    /// استخدام رقم
    /// </summary>
    NumberUsed = 8
} 