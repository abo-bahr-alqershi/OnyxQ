using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث إنشاء حد مخاطر جديد للعملة
    /// </summary>
    public class RiskLimitCreatedEvent : DomainEvent
    {
        /// <summary>
        /// حد المخاطر الذي تم إنشاؤه
        /// </summary>
        public CurrencyRiskLimit RiskLimit { get; }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public RiskLimitCreatedEvent(CurrencyRiskLimit riskLimit)
        {
            if (riskLimit == null)
                throw new ArgumentNullException(nameof(riskLimit));
                
            RiskLimit = riskLimit;
            CurrencyId = riskLimit.CurrencyId;
        }
    }
} 