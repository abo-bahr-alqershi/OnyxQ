using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// مصدر سعر الصرف
    /// </summary>
    public enum ExchangeRateSourceEnum
    {
        /// <summary>
        /// إدخال يدوي
        /// </summary>
        Manual = 0,

        /// <summary>
        /// واجهة برمجة التطبيقات (API)
        /// </summary>
        API = 1,

        /// <summary>
        /// البنك المركزي
        /// </summary>
        CentralBank = 2,

        /// <summary>
        /// ملف مستورد
        /// </summary>
        ImportedFile = 3
    }
} 