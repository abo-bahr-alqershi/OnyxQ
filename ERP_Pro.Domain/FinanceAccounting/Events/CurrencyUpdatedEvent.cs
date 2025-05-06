using System;
using ERP_Pro.Domain.Common.Base;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تحديث بيانات العملة
    /// </summary>
    public class CurrencyUpdatedEvent : DomainEvent
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public CurrencyUpdatedEvent(Guid currencyId)
        {
            CurrencyId = currencyId;
        }
    }
} 