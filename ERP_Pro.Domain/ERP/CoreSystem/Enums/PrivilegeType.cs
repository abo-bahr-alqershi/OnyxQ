namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد نوع الصلاحية في النظام
/// Represents the privilege type in the system
/// </summary>
public enum PrivilegeType
{
    /// <summary>
    /// إدارة كاملة
    /// Full Management
    /// </summary>
    FullManagement = 1,

    /// <summary>
    /// إدارة المستخدمين
    /// User Management
    /// </summary>
    UserManagement = 2,

    /// <summary>
    /// إدارة المبيعات
    /// Sales Management
    /// </summary>
    SalesManagement = 3,

    /// <summary>
    /// إدارة المشتريات
    /// Purchase Management
    /// </summary>
    PurchaseManagement = 4,

    /// <summary>
    /// إدارة المخزون
    /// Inventory Management
    /// </summary>
    InventoryManagement = 5,

    /// <summary>
    /// إدارة المالية
    /// Financial Management
    /// </summary>
    FinancialManagement = 6,

    /// <summary>
    /// إدارة التقارير
    /// Report Management
    /// </summary>
    ReportManagement = 7,

    /// <summary>
    /// إدارة الإعدادات
    /// Settings Management
    /// </summary>
    SettingsManagement = 8,

    /// <summary>
    /// عرض فقط
    /// View Only
    /// </summary>
    ViewOnly = 9,

    /// <summary>
    /// صلاحيات مخصصة
    /// Custom Privileges
    /// </summary>
    Custom = 10
} 