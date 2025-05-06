using System;
using ERP_Pro.Domain.Common.Base;

namespace ERP_Pro.Domain.FinanceAccounting.ValueObjects
{
    /// <summary>
    /// معرف العملة (كائن قيمة)
    /// </summary>
    public class CurrencyId : ValueObject
    {
        /// <summary>
        /// قيمة المعرف
        /// </summary>
        public Guid Value { get; }

        private CurrencyId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف عملة جديد
        /// </summary>
        public static CurrencyId Create(Guid value)
        {
            if (value == Guid.Empty)
                throw new ArgumentException("معرف العملة لا يمكن أن يكون فارغاً", nameof(value));

            return new CurrencyId(value);
        }

        /// <summary>
        /// إنشاء معرف عملة جديد
        /// </summary>
        public static CurrencyId CreateNew()
        {
            return new CurrencyId(Guid.NewGuid());
        }

        protected override System.Collections.Generic.IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        /// <summary>
        /// تحويل ضمني لـ Guid
        /// </summary>
        public static implicit operator Guid(CurrencyId id)
        {
            return id.Value;
        }

        /// <summary>
        /// تحويل ضمني من Guid
        /// </summary>
        public static implicit operator CurrencyId(Guid id)
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