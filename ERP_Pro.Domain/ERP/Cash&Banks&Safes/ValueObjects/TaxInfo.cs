using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting.Entities;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class TaxInfo : ValueObject
    {
        public string? AccountCode { get; private set; }
        public int? TaxNumber { get; private set; }
        public int AgencyNumber { get; private set; }
        public decimal TaxPercent { get; private set; }
        public decimal? TaxAmount { get; private set; }
        public decimal? TaxableAmount { get; private set; }
        public bool IsExempt { get; private set; }
        public string? ExemptionReason { get; private set; }
        
        // Navigation property - will be populated by EF Core
        public TaxAccount? TaxAccount { get; private set; }
        
        private TaxInfo() { }
        
        public static TaxInfo Create(
            string? accountCode = null,
            int? taxNumber = null,
            int agencyNumber = 0,
            decimal taxPercent = 0,
            decimal? taxAmount = null,
            decimal? taxableAmount = null,
            bool isExempt = false,
            string? exemptionReason = null)
        {
            var info = new TaxInfo
            {
                AccountCode = accountCode,
                TaxNumber = taxNumber,
                AgencyNumber = agencyNumber,
                TaxPercent = taxPercent,
                TaxAmount = taxAmount,
                TaxableAmount = taxableAmount,
                IsExempt = isExempt,
                ExemptionReason = exemptionReason
            };
            
            info.ValidateState();
            return info;
        }
        
        public decimal CalculateTaxAmount(decimal amount)
        {
            if (IsExempt || TaxPercent <= 0)
                return 0;
                
            return amount * (TaxPercent / 100);
        }
        
        public TaxInfo WithTaxAmount(decimal amount)
        {
            return Create(
                AccountCode,
                TaxNumber,
                AgencyNumber,
                TaxPercent,
                CalculateTaxAmount(amount),
                amount,
                IsExempt,
                ExemptionReason);
        }
        
        public TaxInfo WithExemption(string reason)
        {
            return Create(
                AccountCode,
                TaxNumber,
                AgencyNumber,
                TaxPercent,
                0,
                TaxableAmount,
                true,
                reason);
        }
        
        public TaxInfo WithoutExemption()
        {
            var taxAmount = TaxableAmount.HasValue ? CalculateTaxAmount(TaxableAmount.Value) : 0;
            
            return Create(
                AccountCode,
                TaxNumber,
                AgencyNumber,
                TaxPercent,
                taxAmount,
                TaxableAmount,
                false,
                null);
        }
        
        private void ValidateState()
        {
            if (TaxPercent < 0 || TaxPercent > 100)
                throw new DomainException("نسبة الضريبة يجب أن تكون بين 0 و 100");
                
            if (IsExempt && string.IsNullOrWhiteSpace(ExemptionReason))
                throw new DomainException("سبب الإعفاء الضريبي مطلوب");
                
            if (!IsExempt && TaxableAmount.HasValue && TaxAmount.HasValue)
            {
                decimal calculatedTax = CalculateTaxAmount(TaxableAmount.Value);
                if (Math.Abs(TaxAmount.Value - calculatedTax) > 0.01m)
                    throw new DomainException("قيمة الضريبة غير متوافقة مع النسبة والمبلغ الخاضع للضريبة");
            }
        }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AccountCode ?? string.Empty;
            yield return TaxNumber ?? 0;
            yield return AgencyNumber;
            yield return TaxPercent;
            yield return TaxAmount ?? 0;
            yield return TaxableAmount ?? 0;
            yield return IsExempt;
            yield return ExemptionReason ?? string.Empty;
        }
    }
} 