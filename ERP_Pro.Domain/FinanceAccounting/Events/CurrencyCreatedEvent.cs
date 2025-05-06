using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث إنشاء عملة جديدة
    /// </summary>
    public class CurrencyCreatedEvent : DomainEvent
    {
        public Currency Currency { get; }

        public CurrencyCreatedEvent(Currency currency)
        {
            Currency = currency;
        }
    }
} 