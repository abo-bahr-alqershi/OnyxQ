using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    /// <summary>
    /// تمثل معرف العملة
    /// </summary>
    public sealed class CurrencyId : ValueObject
    {
        /// <summary>
        /// القيمة
        /// </summary>
        public Guid Value { get; }

        private CurrencyId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف عملة جديد
        /// </summary>
        public static CurrencyId CreateUnique()
        {
            return new CurrencyId(Guid.NewGuid());
        }

        /// <summary>
        /// إنشاء معرف عملة من قيمة معرف موجودة
        /// </summary>
        public static CurrencyId Create(Guid value)
        {
            return new CurrencyId(value);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
} 