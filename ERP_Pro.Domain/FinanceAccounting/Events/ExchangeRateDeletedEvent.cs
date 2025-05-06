using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث حذف سعر صرف
    /// </summary>
    public class ExchangeRateDeletedEvent : DomainEvent
    {
        /// <summary>
        /// معرف سعر الصرف
        /// </summary>
        public Guid ExchangeRateId { get; }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public ExchangeRateDeletedEvent(Guid exchangeRateId, Guid currencyId)
        {
            if (exchangeRateId == Guid.Empty)
                throw new ArgumentException("معرف سعر الصرف مطلوب", nameof(exchangeRateId));
                
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));
                
            ExchangeRateId = exchangeRateId;
            CurrencyId = currencyId;
        }
    }
} 