namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد مستوى الصلاحية في النظام
/// Represents the privilege level in the system
/// </summary>
public enum PrivilegeLevel
{
    /// <summary>
    /// مدير النظام
    /// System Administrator
    /// </summary>
    SystemAdmin = 1,

    /// <summary>
    /// مدير الفرع
    /// Branch Manager
    /// </summary>
    BranchManager = 2,

    /// <summary>
    /// مشرف
    /// Supervisor
    /// </summary>
    Supervisor = 3,

    /// <summary>
    /// موظف
    /// Employee
    /// </summary>
    Employee = 4,

    /// <summary>
    /// متدرب
    /// Trainee
    /// </summary>
    Trainee = 5,

    /// <summary>
    /// مستوى مخصص
    /// Custom Level
    /// </summary>
    Custom = 6
} 