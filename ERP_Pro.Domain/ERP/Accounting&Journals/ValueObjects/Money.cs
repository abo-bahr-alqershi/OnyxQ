using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class Money : ValueObject
    {
        public decimal Amount { get; private set; }
        public string CurrencyCode { get; private set; }

        private Money() { }

        public static Money Create(decimal amount, string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
                throw new DomainException("Currency code is required");

            var money = new Money
            {
                Amount = amount,
                CurrencyCode = currencyCode.ToUpperInvariant()
            };

            money.ValidateState();
            return money;
        }

        public Money Add(Money other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            if (CurrencyCode != other.CurrencyCode)
                throw new DomainException("Cannot add money with different currencies");

            return Create(Amount + other.Amount, CurrencyCode);
        }

        public Money Subtract(Money other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            if (CurrencyCode != other.CurrencyCode)
                throw new DomainException("Cannot subtract money with different currencies");

            return Create(Amount - other.Amount, CurrencyCode);
        }

        public Money Multiply(decimal factor)
        {
            return Create(Amount * factor, CurrencyCode);
        }

        public Money Divide(decimal divisor)
        {
            if (divisor == 0)
                throw new DomainException("Cannot divide by zero");

            return Create(Amount / divisor, CurrencyCode);
        }

        public Money Negate()
        {
            return Create(-Amount, CurrencyCode);
        }

        public Money Round(int decimals = 2)
        {
            return Create(Math.Round(Amount, decimals), CurrencyCode);
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(CurrencyCode))
                throw new DomainException("Currency code is required");

            if (CurrencyCode.Length != 3)
                throw new DomainException("Currency code must be 3 characters");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return CurrencyCode;
        }

        public override string ToString()
        {
            return $"{Amount:N2} {CurrencyCode}";
        }
    }
} 