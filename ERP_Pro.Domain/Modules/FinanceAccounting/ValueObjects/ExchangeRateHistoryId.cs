using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    /// <summary>
    /// تمثل معرف تاريخ سعر الصرف
    /// </summary>
    public sealed class ExchangeRateHistoryId : ValueObject
    {
        /// <summary>
        /// القيمة
        /// </summary>
        public Guid Value { get; }

        private ExchangeRateHistoryId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف تاريخ سعر صرف جديد
        /// </summary>
        public static ExchangeRateHistoryId CreateUnique()
        {
            return new ExchangeRateHistoryId(Guid.NewGuid());
        }

        /// <summary>
        /// إنشاء معرف تاريخ سعر صرف من قيمة معرف موجودة
        /// </summary>
        public static ExchangeRateHistoryId Create(Guid value)
        {
            return new ExchangeRateHistoryId(value);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
} 