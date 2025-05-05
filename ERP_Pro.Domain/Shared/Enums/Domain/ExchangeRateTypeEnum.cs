using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// أنواع سعر الصرف
    /// </summary>
    public enum ExchangeRateTypeEnum
    {
        /// <summary>
        /// أساسي
        /// </summary>
        Base = 1,
        
        /// <summary>
        /// سعر البيع
        /// </summary>
        Sell = 2,
        
        /// <summary>
        /// سعر الشراء
        /// </summary>
        Buy = 3
    }
} 