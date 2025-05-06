using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تحديث حد المخاطر للعملة
    /// </summary>
    public class RiskLimitUpdatedEvent : DomainEvent
    {
        /// <summary>
        /// حد المخاطر الذي تم تحديثه
        /// </summary>
        public CurrencyRiskLimit RiskLimit { get; }

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
        public RiskLimitUpdatedEvent(CurrencyRiskLimit riskLimit)
        {
            if (riskLimit == null)
                throw new ArgumentNullException(nameof(riskLimit));
                
            RiskLimit = riskLimit;
            RiskLimitId = riskLimit.Id;
            CurrencyId = riskLimit.CurrencyId;
        }
    }
} 