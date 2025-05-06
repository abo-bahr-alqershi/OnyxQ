using System;
using ERP_Pro.Domain.Common.Base;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث إلغاء تعيين العملة كعملة أساسية
    /// </summary>
    public class CurrencyUnsetAsBaseEvent : DomainEvent
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public CurrencyUnsetAsBaseEvent(Guid currencyId)
        {
            CurrencyId = currencyId;
        }
    }
} 