using System;

namespace ERP_Pro.Domain.SettingsParameters.Enums
{
    /// <summary>
    /// تعداد حالات الفترة المحاسبية
    /// </summary>
    public enum FiscalPeriodStatusEnum
    {
        /// <summary>
        /// قيد الإعداد
        /// </summary>
        InPreparation = 1,

        /// <summary>
        /// مفتوحة
        /// </summary>
        Open = 2,

        /// <summary>
        /// مغلقة مؤقتاً
        /// </summary>
        TemporarilyClosed = 3,

        /// <summary>
        /// مغلقة نهائياً
        /// </summary>
        Closed = 4,

        /// <summary>
        /// مؤمنة
        /// </summary>
        Locked = 5
    }
} 