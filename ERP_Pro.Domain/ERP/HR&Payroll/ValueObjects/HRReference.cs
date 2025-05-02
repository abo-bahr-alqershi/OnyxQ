using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.HR&Payroll.ValueObjects
{
    public class HRReference : ValueObject
    {
        public int? HrsDocTypeRef { get; private set; }
        public int? HrsDocSerRef { get; private set; }
        public int? HrsDocNoRef { get; private set; }

        private HRReference() { }

        public static HRReference Create(
            int? hrsDocTypeRef = null,
            int? hrsDocSerRef = null,
            int? hrsDocNoRef = null)
        {
            return new HRReference
            {
                HrsDocTypeRef = hrsDocTypeRef,
                HrsDocSerRef = hrsDocSerRef,
                HrsDocNoRef = hrsDocNoRef
            };
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return HrsDocTypeRef ?? 0;
            yield return HrsDocSerRef ?? 0;
            yield return HrsDocNoRef ?? 0;
        }
    }
} 