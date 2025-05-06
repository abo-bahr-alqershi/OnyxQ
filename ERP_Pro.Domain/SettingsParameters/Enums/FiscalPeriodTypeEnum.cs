using System;

namespace ERP_Pro.Domain.SettingsParameters.Enums
{
    /// <summary>
    /// تعداد أنواع الفترات المحاسبية
    /// </summary>
    public enum FiscalPeriodTypeEnum
    {
        /// <summary>
        /// شهرية
        /// </summary>
        Monthly = 1,

        /// <summary>
        /// ربع سنوية
        /// </summary>
        Quarterly = 2,

        /// <summary>
        /// نصف سنوية
        /// </summary>
        HalfYearly = 3,

        /// <summary>
        /// سنوية
        /// </summary>
        Yearly = 4,

        /// <summary>
        /// مخصصة
        /// </summary>
        Custom = 5,

        /// <summary>
        /// فترة الإقفال
        /// </summary>
        ClosingPeriod = 6
    }
} 