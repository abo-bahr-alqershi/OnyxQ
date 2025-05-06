using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث إنشاء قاعدة تقريب جديدة للعملة
    /// </summary>
    public class RoundingRuleCreatedEvent : DomainEvent
    {
        /// <summary>
        /// قاعدة التقريب التي تم إنشاؤها
        /// </summary>
        public CurrencyRoundingRule RoundingRule { get; }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public RoundingRuleCreatedEvent(CurrencyRoundingRule roundingRule)
        {
            if (roundingRule == null)
                throw new ArgumentNullException(nameof(roundingRule));
                
            RoundingRule = roundingRule;
            CurrencyId = roundingRule.CurrencyId;
        }
    }
} 