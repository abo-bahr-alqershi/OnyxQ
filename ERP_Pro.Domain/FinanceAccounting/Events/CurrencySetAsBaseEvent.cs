using System;
using ERP_Pro.Domain.Common.Base;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تعيين العملة كعملة أساسية
    /// </summary>
    public class CurrencySetAsBaseEvent : DomainEvent
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public CurrencySetAsBaseEvent(Guid currencyId)
        {
            CurrencyId = currencyId;
        }
    }
} 