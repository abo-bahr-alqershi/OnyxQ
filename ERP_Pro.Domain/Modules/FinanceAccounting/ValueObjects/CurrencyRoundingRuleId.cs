using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    /// <summary>
    /// تمثل معرف قاعدة تقريب العملة
    /// </summary>
    public sealed class CurrencyRoundingRuleId : ValueObject
    {
        /// <summary>
        /// القيمة
        /// </summary>
        public Guid Value { get; }

        private CurrencyRoundingRuleId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف قاعدة تقريب عملة جديد
        /// </summary>
        public static CurrencyRoundingRuleId CreateUnique()
        {
            return new CurrencyRoundingRuleId(Guid.NewGuid());
        }

        /// <summary>
        /// إنشاء معرف قاعدة تقريب عملة من قيمة معرف موجودة
        /// </summary>
        public static CurrencyRoundingRuleId Create(Guid value)
        {
            return new CurrencyRoundingRuleId(value);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
} 