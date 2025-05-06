using System;
using ERP_Pro.Shared.Events.Domain;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تغيير حالة العملة (تفعيل/تعطيل)
    /// </summary>
    public class CurrencyStatusChangedEvent : DomainEvent
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }
        
        /// <summary>
        /// الحالة الجديدة للعملة
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