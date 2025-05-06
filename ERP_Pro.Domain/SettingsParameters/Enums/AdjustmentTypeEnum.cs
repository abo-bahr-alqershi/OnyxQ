using System;

namespace ERP_Pro.Domain.SettingsParameters.Enums
{
    /// <summary>
    /// تعداد أنواع التسويات
    /// </summary>
    public enum AdjustmentTypeEnum
    {
        /// <summary>
        /// تسوية عادية
        /// </summary>
        Normal = 1,

        /// <summary>
        /// تسوية نهاية الفترة
        /// </summary>
        EndOfPeriod = 2,

        /// <summary>
        /// تسوية محاسبية
        /// </summary>
        Accounting = 3,

        /// <summary>
        /// تسوية ضريبية
        /// </summary>
        Tax = 4,

        /// <summary>
        /// تسوية فروقات العملات
        /// </summary>
        CurrencyExchange = 5,

        /// <summary>
        /// تسوية المخصصات
        /// </summary>
        Provisions = 6,

        /// <summary>
        /// تسوية الإيرادات المؤجلة
        /// </summary>
        DeferredRevenue = 7,

        /// <summary>
        /// تسوية المصاريف المدفوعة مقدماً
        /// </summary>
        PrepaidExpenses = 8,

        /// <summary>
        /// تسوية الإقفال
        /// </summary>
        Closing = 9
    }
} 