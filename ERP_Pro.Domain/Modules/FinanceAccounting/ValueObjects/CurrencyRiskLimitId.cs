using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    /// <summary>
    /// تمثل معرف حد مخاطر العملة
    /// </summary>
    public sealed class CurrencyRiskLimitId : ValueObject
    {
        /// <summary>
        /// القيمة
        /// </summary>
        public Guid Value { get; }

        private CurrencyRiskLimitId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف حد مخاطر عملة جديد
        /// </summary>
        public static CurrencyRiskLimitId CreateUnique()
        {
            return new CurrencyRiskLimitId(Guid.NewGuid());
        }

        /// <summary>
        /// إنشاء معرف حد مخاطر عملة من قيمة معرف موجودة
        /// </summary>
        public static CurrencyRiskLimitId Create(Guid value)
        {
            return new CurrencyRiskLimitId(value);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
} 