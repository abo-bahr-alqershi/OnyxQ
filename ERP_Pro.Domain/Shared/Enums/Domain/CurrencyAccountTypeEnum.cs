using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// أنواع حسابات العملة
    /// </summary>
    public enum CurrencyAccountTypeEnum
    {
        /// <summary>
        /// أرباح فروق العملة
        /// </summary>
        ExchangeRateGains = 1,
        
        /// <summary>
        /// خسائر فروق العملة
        /// </summary>
        ExchangeRateLosses = 2,
        
        /// <summary>
        /// إعادة تقييم العملة
        /// </summary>
        CurrencyRevaluation = 3,
        
        /// <summary>
        /// فروق التقريب
        /// </summary>
        RoundingDifferences = 4,
        
        /// <summary>
        /// تسوية العملة
        /// </summary>
        CurrencySettlement = 5
    }
} 