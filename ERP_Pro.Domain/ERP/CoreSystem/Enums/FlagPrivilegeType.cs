namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// أنواع صلاحيات العلامات
/// Flag privilege types
/// </summary>
public enum FlagPrivilegeType
{
    /// <summary>
    /// قراءة فقط
    /// Read only
    /// </summary>
    ReadOnly = 1,

    /// <summary>
    /// قراءة وكتابة
    /// Read and write
    /// </summary>
    ReadWrite = 2,

    /// <summary>
    /// إدارة كاملة
    /// Full management
    /// </summary>
    FullControl = 3,

    /// <summary>
    /// تعديل الحالة
    /// Status Modification
    /// </summary>
    StatusModification = 4,

    /// <summary>
    /// إدارة الصلاحيات
    /// Privilege Management
    /// </summary>
    PrivilegeManagement = 5,

    /// <summary>
    /// مخصص
    /// Custom
    /// </summary>
    Custom = 6
} 