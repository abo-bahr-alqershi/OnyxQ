using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Taxation.ValueObjects
{
    public class TaxInfo : ValueObject
    {
        public TaxReference Reference { get; private set; }
        public decimal TaxPercent { get; private set; }
        public decimal? TaxAmount { get; private set; }
        public decimal? TaxableAmount { get; private set; }
        public bool IsExempt { get; private set; }
        public string? ExemptionReason { get; private set; }

        private TaxInfo() { }

        public static TaxInfo Create(
            TaxReference reference,
            decimal taxPercent,
            decimal? taxAmount = null,
            decimal? taxableAmount = null,
            bool isExempt = false,
            string? exemptionReason = null)
        {
            return new TaxInfo
            {
                Reference = reference,
                TaxPercent = taxPercent,
                TaxAmount = taxAmount,
                TaxableAmount = taxableAmount,
                IsExempt = isExempt,
                ExemptionReason = exemptionReason
            };
        }

        public decimal? CalculateTaxAmount(decimal baseAmount)
        {
            if (TaxPercent == 0) return null;
            return baseAmount * (TaxPercent / 100);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Reference;
            yield return TaxPercent;
            yield return TaxAmount ?? 0;
            yield return TaxableAmount ?? 0;
            yield return IsExempt;
            yield return ExemptionReason;
        }
    }
} 