using System;
using ERP_Pro.Domain.Common.Base;

namespace ERP_Pro.Domain.FinanceAccounting.ValueObjects
{
    /// <summary>
    /// معرف حد مخاطر العملة (كائن قيمة)
    /// </summary>
    public class CurrencyRiskLimitId : ValueObject
    {
        /// <summary>
        /// قيمة المعرف
        /// </summary>
        public Guid Value { get; }

        private CurrencyRiskLimitId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف حد مخاطر عملة جديد
        /// </summary>
        public static CurrencyRiskLimitId Create(Guid value)
        {
            if (value == Guid.Empty)
                throw new ArgumentException("معرف حد المخاطر لا يمكن أن يكون فارغاً", nameof(value));

            return new CurrencyRiskLimitId(value);
        }

        /// <summary>
        /// إنشاء معرف حد مخاطر عملة جديد
        /// </summary>
        public static CurrencyRiskLimitId CreateNew()
        {
            return new CurrencyRiskLimitId(Guid.NewGuid());
        }

        protected override System.Collections.Generic.IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        /// <summary>
        /// تحويل ضمني لـ Guid
        /// </summary>
        public static implicit operator Guid(CurrencyRiskLimitId id)
        {
            return id.Value;
        }

        /// <summary>
        /// تحويل ضمني من Guid
        /// </summary>
        public static implicit operator CurrencyRiskLimitId(Guid id)
        {
            return Create(id);
        }

        /// <summary>
        /// تمثيل المعرف كنص
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
} 