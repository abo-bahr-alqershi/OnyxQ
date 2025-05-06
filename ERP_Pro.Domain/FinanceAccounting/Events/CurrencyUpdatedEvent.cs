using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تحديث بيانات العملة
    /// </summary>
    public class CurrencyUpdatedEvent : DomainEvent
    {
        /// <summary>
        /// معرف العملة التي تم تحديثها
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// العملة التي تم تحديثها
        /// </summary>
        public Currency Currency { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public CurrencyUpdatedEvent(Currency currency)
        {
            if (currency == null)
                throw new ArgumentNullException(nameof(currency));
                
            CurrencyId = currency.Id;
            Currency = currency;
        }
    }
} 