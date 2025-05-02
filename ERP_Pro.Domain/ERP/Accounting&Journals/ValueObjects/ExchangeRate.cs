using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class ExchangeRate : ValueObject
    {
        public string FromCurrency { get; private set; }
        public string ToCurrency { get; private set; }
        public decimal Rate { get; private set; }
        public DateTime EffectiveDate { get; private set; }

        private ExchangeRate() { }

        public static ExchangeRate Create(
            string fromCurrency,
            string toCurrency,
            decimal rate,
            DateTime effectiveDate)
        {
            if (string.IsNullOrWhiteSpace(fromCurrency))
                throw new DomainException("From currency is required");

            if (string.IsNullOrWhiteSpace(toCurrency))
                throw new DomainException("To currency is required");

            var exchangeRate = new ExchangeRate
            {
                FromCurrency = fromCurrency.ToUpperInvariant(),
                ToCurrency = toCurrency.ToUpperInvariant(),
                Rate = rate,
                EffectiveDate = effectiveDate
            };

            exchangeRate.ValidateState();
            return exchangeRate;
        }

        public Money Convert(Money money)
        {
            if (money == null)
                throw new ArgumentNullException(nameof(money));

            if (money.CurrencyCode != FromCurrency)
                throw new DomainException($"Cannot convert from {money.CurrencyCode} using rate for {FromCurrency}");

            return Money.Create(money.Amount * Rate, ToCurrency);
        }

        public ExchangeRate Inverse()
        {
            return Create(
                ToCurrency,
                FromCurrency,
                1 / Rate,
                EffectiveDate);
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(FromCurrency))
                throw new DomainException("From currency is required");

            if (string.IsNullOrWhiteSpace(ToCurrency))
                throw new DomainException("To currency is required");

            if (FromCurrency.Length != 3)
                throw new DomainException("From currency code must be 3 characters");

            if (ToCurrency.Length != 3)
                throw new DomainException("To currency code must be 3 characters");

            if (FromCurrency == ToCurrency)
                throw new DomainException("From and To currencies must be different");

            if (Rate <= 0)
                throw new DomainException("Exchange rate must be positive");

            if (EffectiveDate == default)
                throw new DomainException("Effective date is required");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FromCurrency;
            yield return ToCurrency;
            yield return Rate;
            yield return EffectiveDate;
        }

        public override string ToString()
        {
            return $"1 {FromCurrency} = {Rate:N4} {ToCurrency} ({EffectiveDate:d})";
        }
    }
} 