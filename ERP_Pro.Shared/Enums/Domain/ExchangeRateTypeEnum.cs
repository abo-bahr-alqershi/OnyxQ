using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// نوع سعر الصرف
    /// </summary>
    public enum ExchangeRateTypeEnum
    {
        /// <summary>
        /// أساسي
        /// </summary>
        Base = 0,

        /// <summary>
        /// سعر البيع
        /// </summary>
        Sell = 1,

        /// <summary>
        /// سعر الشراء
        /// </summary>
        Buy = 2
    }
} 