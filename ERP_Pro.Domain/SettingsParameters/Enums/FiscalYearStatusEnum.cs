using System;

namespace ERP_Pro.Domain.SettingsParameters.Enums
{
    /// <summary>
    /// تعداد حالات السنة المالية
    /// </summary>
    public enum FiscalYearStatusEnum
    {
        /// <summary>
        /// قيد الإعداد
        /// </summary>
        InPreparation = 1,

        /// <summary>
        /// نشطة
        /// </summary>
        Active = 2,

        /// <summary>
        /// غير نشطة
        /// </summary>
        Inactive = 3,

        /// <summary>
        /// مغلقة مؤقتاً
        /// </summary>
        TemporarilyClosed = 4,

        /// <summary>
        /// مغلقة نهائياً
        /// </summary>
        Closed = 5
    }
}