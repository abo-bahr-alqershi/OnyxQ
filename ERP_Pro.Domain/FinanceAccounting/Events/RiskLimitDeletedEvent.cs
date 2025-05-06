using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث حذف حد مخاطر للعملة
    /// </summary>
    public class RiskLimitDeletedEvent : DomainEvent
    {
        /// <summary>
        /// معرف حد المخاطر
        /// </summary>
        public Guid RiskLimitId { get; }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public RiskLimitDeletedEvent(Guid riskLimitId, Guid currencyId)
        {
            if (riskLimitId == Guid.Empty)
                throw new ArgumentException("معرف حد المخاطر مطلوب", nameof(riskLimitId));
                
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));
                
            RiskLimitId = riskLimitId;
            CurrencyId = currencyId;
        }
    }
} 