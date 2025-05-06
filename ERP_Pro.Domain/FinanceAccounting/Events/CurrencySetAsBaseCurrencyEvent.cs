using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تعيين العملة كعملة أساسية
    /// </summary>
    public class CurrencySetAsBaseCurrencyEvent : DomainEvent
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }
        
        /// <summary>
        /// العملة التي تم تعيينها كعملة أساسية
        /// </summary>
        public Currency Currency { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public CurrencySetAsBaseCurrencyEvent(Currency currency)
        {
            if (currency == null)
                throw new ArgumentNullException(nameof(currency));
                
            CurrencyId = currency.Id;
            Currency = currency;
        }
    }
} 