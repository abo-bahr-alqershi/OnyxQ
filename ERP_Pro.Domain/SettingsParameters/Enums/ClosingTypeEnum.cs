using System;

namespace ERP_Pro.Domain.SettingsParameters.Enums
{
    /// <summary>
    /// تعداد أنواع الإقفال
    /// </summary>
    public enum ClosingTypeEnum
    {
        /// <summary>
        /// إقفال عادي
        /// </summary>
        Normal = 1,

        /// <summary>
        /// إقفال جزئي
        /// </summary>
        Partial = 2,

        /// <summary>
        /// إقفال نهائي مع ترحيل أرصدة
        /// </summary>
        FinalWithCarryOver = 3,

        /// <summary>
        /// إقفال نهائي بدون ترحيل أرصدة
        /// </summary>
        FinalWithoutCarryOver = 4,

        /// <summary>
        /// إقفال خاص
        /// </summary>
        Special = 5
    }
} 