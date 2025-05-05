using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// نوع حساب العملة
    /// </summary>
    public enum CurrencyAccountTypeEnum
    {
        /// <summary>
        /// أرباح فروق العملة
        /// </summary>
        ExchangeRateGains = 0,

        /// <summary>
        /// خسائر فروق العملة
        /// </summary>
        ExchangeRateLosses = 1,

        /// <summary>
        /// إعادة تقييم العملة
        /// </summary>
        CurrencyRevaluation = 2,

        /// <summary>
        /// فروق التقريب
        /// </summary>
        RoundingDifferences = 3,

        /// <summary>
        /// تسوية العملة
        /// </summary>
        CurrencySettlement = 4
    }
}