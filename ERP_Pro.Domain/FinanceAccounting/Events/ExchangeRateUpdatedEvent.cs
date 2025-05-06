using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تحديث سعر صرف
    /// </summary>
    public class ExchangeRateUpdatedEvent : DomainEvent
    {
        /// <summary>
        /// سعر الصرف الذي تم تحديثه
        /// </summary>
        public CurrencyExchangeRate ExchangeRate { get; }

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
        public ExchangeRateUpdatedEvent(CurrencyExchangeRate exchangeRate)
        {
            if (exchangeRate == null)
                throw new ArgumentNullException(nameof(exchangeRate));
                
            ExchangeRate = exchangeRate;
            ExchangeRateId = exchangeRate.Id;
            CurrencyId = exchangeRate.CurrencyId;
        }
    }
} 