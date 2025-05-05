using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// مصادر سعر الصرف
    /// </summary>
    public enum ExchangeRateSourceEnum
    {
        /// <summary>
        /// يدوي
        /// </summary>
        Manual = 1,
        
        /// <summary>
        /// واجهة برمجة التطبيقات
        /// </summary>
        API = 2,
        
        /// <summary>
        /// بنك مركزي
        /// </summary>
        CentralBank = 3,
        
        /// <summary>
        /// مستورد من ملف
        /// </summary>
        ImportedFile = 4
    }
} 