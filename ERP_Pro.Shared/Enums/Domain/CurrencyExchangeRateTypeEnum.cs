using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// أنواع أسعار صرف العملة
    /// </summary>
    public enum CurrencyExchangeRateTypeEnum
    {
        /// <summary>
        /// سعر الصرف الأساسي
        /// </summary>
        Base = 1,
        
        /// <summary>
        /// سعر البيع
        /// </summary>
        Selling = 2,
        
        /// <summary>
        /// سعر الشراء
        /// </summary>
        Buying = 3,
        
        /// <summary>
        /// سعر تعاقدي خاص
        /// </summary>
        Contract = 4,
        
        /// <summary>
        /// سعر البنك المركزي
        /// </summary>
        CentralBank = 5
    }
} 