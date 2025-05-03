namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد نوع العلامة في النظام
/// Represents the flag type in the system
/// </summary>
public enum FlagType
{
    /// <summary>
    /// نظام
    /// System
    /// </summary>
    System = 1,

    /// <summary>
    /// مستخدم
    /// User
    /// </summary>
    User = 2,

    /// <summary>
    /// مبيعات
    /// Sales
    /// </summary>
    Sales = 3,

    /// <summary>
    /// مشتريات
    /// Purchases
    /// </summary>
    Purchases = 4,

    /// <summary>
    /// مخزون
    /// Inventory
    /// </summary>
    Inventory = 5,

    /// <summary>
    /// مالية
    /// Financial
    /// </summary>
    Financial = 6,

    /// <summary>
    /// تقارير
    /// Reports
    /// </summary>
    Reports = 7,

    /// <summary>
    /// إعدادات
    /// Settings
    /// </summary>
    Settings = 8,

    /// <summary>
    /// مخصص
    /// Custom
    /// </summary>
    Custom = 9
} 