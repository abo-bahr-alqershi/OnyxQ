namespace ERP_Pro.Domain.SettingsParameters.Enums;

/// <summary>
/// حالات تخصيص الأرقام
/// </summary>
public enum NumberAllocationStatusEnum
{
    /// <summary>
    /// محجوز
    /// </summary>
    Reserved = 1,
    
    /// <summary>
    /// مستخدم
    /// </summary>
    Used = 2,
    
    /// <summary>
    /// محرر
    /// </summary>
    Released = 3,
    
    /// <summary>
    /// ملغى
    /// </summary>
    Canceled = 4
} 