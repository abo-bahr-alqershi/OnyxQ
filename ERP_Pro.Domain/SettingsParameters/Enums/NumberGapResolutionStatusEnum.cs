namespace ERP_Pro.Domain.SettingsParameters.Enums;

/// <summary>
/// حالات حل الفجوات في التسلسل العددي
/// </summary>
public enum NumberGapResolutionStatusEnum
{
    /// <summary>
    /// غير محلول
    /// </summary>
    Unresolved = 1,
    
    /// <summary>
    /// تم الحل عن طريق استخدام الرقم
    /// </summary>
    ResolvedByUse = 2,
    
    /// <summary>
    /// تم الحل عن طريق إلغاء الرقم
    /// </summary>
    ResolvedByCancellation = 3,
    
    /// <summary>
    /// تم الحل يدوياً
    /// </summary>
    ResolvedManually = 4,
    
    /// <summary>
    /// قيد المعالجة
    /// </summary>
    InProgress = 5,
    
    /// <summary>
    /// تم تجاهلها
    /// </summary>
    Ignored = 6
} 