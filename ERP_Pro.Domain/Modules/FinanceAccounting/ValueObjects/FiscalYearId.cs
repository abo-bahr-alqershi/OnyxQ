using ERP_Pro.Domain.Common.Primitives;
using System;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    public sealed class FiscalYearId : ValueObject
    {
        /// <summary>
        /// القيمة الداخلية للمعرف
        /// </summary>
        public Guid Value { get; private set; }

        private FiscalYearId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف جديد
        /// </summary>
        public static FiscalYearId CreateNew() => new FiscalYearId(Guid.NewGuid());

        /// <summary>
        /// إنشاء معرف من قيمة موجودة
        /// </summary>
        public static FiscalYearId Create(Guid value) => new FiscalYearId(value);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
} 