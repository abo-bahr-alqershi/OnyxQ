using System;

namespace ERP_Pro.Domain.SettingsParameters.Enums
{
    /// <summary>
    /// تعداد أنواع التقويم
    /// </summary>
    public enum CalendarTypeEnum
    {
        /// <summary>
        /// ميلادي (شمسي)
        /// </summary>
        Gregorian = 1,

        /// <summary>
        /// هجري (قمري)
        /// </summary>
        Hijri = 2,

        /// <summary>
        /// مالي مخصص
        /// </summary>
        CustomFiscal = 3
    }
} 