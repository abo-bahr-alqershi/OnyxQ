using ERP_Pro.Domain.Common.Primitives;
using System;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    public sealed class FiscalPeriodLockId : ValueObject
    {
        /// <summary>
        /// القيمة الداخلية للمعرف
        /// </summary>
        public Guid Value { get; private set; }

        private FiscalPeriodLockId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف جديد
        /// </summary>
        public static FiscalPeriodLockId CreateNew() => new FiscalPeriodLockId(Guid.NewGuid());

        /// <summary>
        /// إنشاء معرف من قيمة موجودة
        /// </summary>
        public static FiscalPeriodLockId Create(Guid value) => new FiscalPeriodLockId(value);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
} 