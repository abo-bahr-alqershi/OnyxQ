using ERP_Pro.Domain.Common.Primitives;
using System;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects
{
    public sealed class FiscalYearSettingId : ValueObject
    {
        /// <summary>
        /// القيمة الداخلية للمعرف
        /// </summary>
        public Guid Value { get; private set; }

        private FiscalYearSettingId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// إنشاء معرف جديد
        /// </summary>
        public static FiscalYearSettingId CreateNew() => new FiscalYearSettingId(Guid.NewGuid());

        /// <summary>
        /// إنشاء معرف من قيمة موجودة
        /// </summary>
        public static FiscalYearSettingId Create(Guid value) => new FiscalYearSettingId(value);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
} 