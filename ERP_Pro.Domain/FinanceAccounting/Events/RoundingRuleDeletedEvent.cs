using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث حذف قاعدة تقريب للعملة
    /// </summary>
    public class RoundingRuleDeletedEvent : DomainEvent
    {
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
        public RoundingRuleDeletedEvent(Guid roundingRuleId, Guid currencyId)
        {
            if (roundingRuleId == Guid.Empty)
                throw new ArgumentException("معرف قاعدة التقريب مطلوب", nameof(roundingRuleId));
                
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));
                
            RoundingRuleId = roundingRuleId;
            CurrencyId = currencyId;
        }
    }
} 