using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تحديث قاعدة تقريب للعملة
    /// </summary>
    public class RoundingRuleUpdatedEvent : DomainEvent
    {
        /// <summary>
        /// قاعدة التقريب التي تم تحديثها
        /// </summary>
        public CurrencyRoundingRule RoundingRule { get; }

        /// <summary>
        /// معرف قاعدة التقريب
        /// </summary>
        public Guid RoundingRuleId { get; }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public RoundingRuleUpdatedEvent(CurrencyRoundingRule roundingRule)
        {
            if (roundingRule == null)
                throw new ArgumentNullException(nameof(roundingRule));
                
            RoundingRule = roundingRule;
            RoundingRuleId = roundingRule.Id;
            CurrencyId = roundingRule.CurrencyId;
        }
    }
} 