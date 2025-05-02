using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class CurrencyInfo : ValueObject
    {
        public string? CurrencyCode { get; private set; }
        public decimal ExchangeRate { get; private set; }
        public string? CurrencyName { get; private set; }
        public string? CurrencyNameEn { get; private set; }
        public int? CurrencyFractionDigits { get; private set; }
        
        private CurrencyInfo() { }
        
        public static CurrencyInfo Create(
            string? currencyCode = null,
            decimal exchangeRate = 1m,
            string? currencyName = null,
            string? currencyNameEn = null,
            int? currencyFractionDigits = null)
        {
            var info = new CurrencyInfo
            {
                CurrencyCode = currencyCode,
                ExchangeRate = exchangeRate,
                CurrencyName = currencyName,
                CurrencyNameEn = currencyNameEn,
                CurrencyFractionDigits = currencyFractionDigits
            };
            
            info.ValidateState();
            return info;
        }
        
        public decimal ConvertToLocal(decimal amount) => amount * ExchangeRate;
        
        public decimal ConvertFromLocal(decimal localAmount) => ExchangeRate > 0 ? localAmount / ExchangeRate : 0;
        
        private void ValidateState()
        {
            if (ExchangeRate <= 0)
                throw new DomainException("سعر الصرف يجب أن يكون أكبر من صفر");
                
            if (CurrencyFractionDigits.HasValue && (CurrencyFractionDigits < 0 || CurrencyFractionDigits > 6))
                throw new DomainException("عدد الكسور العشرية غير صحيح");
        }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CurrencyCode ?? string.Empty;
            yield return ExchangeRate;
            yield return CurrencyName ?? string.Empty;
            yield return CurrencyNameEn ?? string.Empty;
            yield return CurrencyFractionDigits ?? 0;
        }
    }
} 