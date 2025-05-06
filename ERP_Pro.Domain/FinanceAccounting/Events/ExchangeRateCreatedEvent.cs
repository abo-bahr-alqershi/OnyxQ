using System;
using ERP_Pro.Shared.Events.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث إنشاء سعر صرف جديد
    /// </summary>
    public class ExchangeRateCreatedEvent : DomainEvent
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
        /// سعر الصرف
        /// </summary>
        public decimal Rate { get; }
        
        /// <summary>
        /// تاريخ سعر الصرف
        /// </summary>
        public DateTime RateDate { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public ExchangeRateCreatedEvent(Guid exchangeRateId, Guid currencyId, decimal rate, DateTime rateDate)
        {
            ExchangeRateId = exchangeRateId;
            CurrencyId = currencyId;
            Rate = rate;
            RateDate = rateDate;
        }
    }
}
