using ERP_Pro.Domain.Common.Primitives;
using System;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    public sealed class FiscalPeriodId : ValueObject
    {
        /// <summary>
        /// القيمة الداخلية للمعرف
        /// </summary>
        public Guid Value { get; private set; }

        private FiscalPeriodId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف جديد
        /// </summary>
        public static FiscalPeriodId CreateNew() => new FiscalPeriodId(Guid.NewGuid());

        /// <summary>
        /// إنشاء معرف من قيمة موجودة
        /// </summary>
        public static FiscalPeriodId Create(Guid value) => new FiscalPeriodId(value);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
} 