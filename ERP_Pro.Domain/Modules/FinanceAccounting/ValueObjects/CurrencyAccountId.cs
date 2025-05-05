using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    /// <summary>
    /// تمثل معرف حساب العملة
    /// </summary>
    public sealed class CurrencyAccountId : ValueObject
    {
        /// <summary>
        /// القيمة
        /// </summary>
        public Guid Value { get; }

        private CurrencyAccountId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف حساب عملة جديد
        /// </summary>
        public static CurrencyAccountId CreateUnique()
        {
            return new CurrencyAccountId(Guid.NewGuid());
        }

        /// <summary>
        /// إنشاء معرف حساب عملة من قيمة معرف موجودة
        /// </summary>
        public static CurrencyAccountId Create(Guid value)
        {
            return new CurrencyAccountId(value);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
} 