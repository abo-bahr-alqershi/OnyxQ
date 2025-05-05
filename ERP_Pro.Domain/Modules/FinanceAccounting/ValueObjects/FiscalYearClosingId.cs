using ERP_Pro.Domain.Common.Primitives;
using System;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    public sealed class FiscalYearClosingId : ValueObject
    {
        /// <summary>
        /// القيمة الداخلية للمعرف
        /// </summary>
        public Guid Value { get; private set; }

        private FiscalYearClosingId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف جديد
        /// </summary>
        public static FiscalYearClosingId CreateNew() => new FiscalYearClosingId(Guid.NewGuid());

        /// <summary>
        /// إنشاء معرف من قيمة موجودة
        /// </summary>
        public static FiscalYearClosingId Create(Guid value) => new FiscalYearClosingId(value);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
} 