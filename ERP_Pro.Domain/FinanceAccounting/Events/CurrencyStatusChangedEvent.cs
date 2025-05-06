using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تغيير حالة العملة
    /// </summary>
    public class CurrencyStatusChangedEvent : DomainEvent
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public CurrencyStatusEnum NewStatus { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public CurrencyStatusChangedEvent(Guid currencyId, CurrencyStatusEnum newStatus)
        {
            CurrencyId = currencyId;
            NewStatus = newStatus;
        }
    }
}