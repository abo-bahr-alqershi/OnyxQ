using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    /// <summary>
    /// تمثل معرف قاعدة عرض العملة
    /// </summary>
    public sealed class CurrencyDisplayRuleId : ValueObject
    {
        /// <summary>
        /// القيمة
        /// </summary>
        public Guid Value { get; }

        private CurrencyDisplayRuleId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف قاعدة عرض عملة جديد
        /// </summary>
        public static CurrencyDisplayRuleId CreateUnique()
        {
            return new CurrencyDisplayRuleId(Guid.NewGuid());
        }

        /// <summary>
        /// إنشاء معرف قاعدة عرض عملة من قيمة معرف موجودة
        /// </summary>
        public static CurrencyDisplayRuleId Create(Guid value)
        {
            return new CurrencyDisplayRuleId(value);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
} 