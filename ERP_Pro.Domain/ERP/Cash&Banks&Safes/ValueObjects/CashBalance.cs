using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class CashBalance : ValueObject
    {
        public string AccountCode { get; private set; }
        public string? CurrencyCode { get; private set; }
        public decimal OpeningBalanceLocal { get; private set; }
        public decimal OpeningBalanceForeign { get; private set; }
        public decimal CurrentBalanceLocal { get; private set; }
        public decimal CurrentBalanceForeign { get; private set; }
        public bool IsInactive { get; private set; }
        public DateTime? InactiveDate { get; private set; }
        public decimal? MinimumLimit { get; private set; }
        public decimal? MaximumLimit { get; private set; }
        public decimal? MaximumTransactionLimit { get; private set; }
        public decimal? MinimumTransactionLimit { get; private set; }
        public bool PassLimit { get; private set; }

        private CashBalance() { }

        public static CashBalance Create(
            string accountCode,
            string? currencyCode = null,
            decimal openingBalanceLocal = 0,
            decimal openingBalanceForeign = 0,
            decimal currentBalanceLocal = 0,
            decimal currentBalanceForeign = 0,
            bool isInactive = false,
            DateTime? inactiveDate = null,
            decimal? minimumLimit = null,
            decimal? maximumLimit = null,
            decimal? maximumTransactionLimit = null,
            decimal? minimumTransactionLimit = null,
            bool passLimit = false)
        {
            var balance = new CashBalance
            {
                AccountCode = accountCode,
                CurrencyCode = currencyCode,
                OpeningBalanceLocal = openingBalanceLocal,
                OpeningBalanceForeign = openingBalanceForeign,
                CurrentBalanceLocal = currentBalanceLocal,
                CurrentBalanceForeign = currentBalanceForeign,
                IsInactive = isInactive,
                InactiveDate = inactiveDate,
                MinimumLimit = minimumLimit,
                MaximumLimit = maximumLimit,
                MaximumTransactionLimit = maximumTransactionLimit,
                MinimumTransactionLimit = minimumTransactionLimit,
                PassLimit = passLimit
            };

            balance.ValidateState();
            return balance;
        }

        public CashBalance UpdateBalances(
            decimal openingBalanceLocal,
            decimal openingBalanceForeign,
            decimal currentBalanceLocal,
            decimal currentBalanceForeign)
        {
            return Create(
                AccountCode,
                CurrencyCode,
                openingBalanceLocal,
                openingBalanceForeign,
                currentBalanceLocal,
                currentBalanceForeign,
                IsInactive,
                InactiveDate,
                MinimumLimit,
                MaximumLimit,
                MaximumTransactionLimit,
                MinimumTransactionLimit,
                PassLimit);
        }

        public CashBalance UpdateLimits(
            decimal? minimumLimit,
            decimal? maximumLimit,
            decimal? minimumTransactionLimit,
            decimal? maximumTransactionLimit,
            bool passLimit)
        {
            return Create(
                AccountCode,
                CurrencyCode,
                OpeningBalanceLocal,
                OpeningBalanceForeign,
                CurrentBalanceLocal,
                CurrentBalanceForeign,
                IsInactive,
                InactiveDate,
                minimumLimit,
                maximumLimit,
                maximumTransactionLimit,
                minimumTransactionLimit,
                passLimit);
        }

        public CashBalance Deactivate()
        {
            return Create(
                AccountCode,
                CurrencyCode,
                OpeningBalanceLocal,
                OpeningBalanceForeign,
                CurrentBalanceLocal,
                CurrentBalanceForeign,
                true,
                DateTime.UtcNow,
                MinimumLimit,
                MaximumLimit,
                MaximumTransactionLimit,
                MinimumTransactionLimit,
                PassLimit);
        }

        public CashBalance Activate()
        {
            return Create(
                AccountCode,
                CurrencyCode,
                OpeningBalanceLocal,
                OpeningBalanceForeign,
                CurrentBalanceLocal,
                CurrentBalanceForeign,
                false,
                null,
                MinimumLimit,
                MaximumLimit,
                MaximumTransactionLimit,
                MinimumTransactionLimit,
                PassLimit);
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(AccountCode))
                throw new DomainException("رمز الحساب مطلوب");

            if (IsInactive && !InactiveDate.HasValue)
                throw new DomainException("تاريخ التعطيل مطلوب عند تعطيل الرصيد");

            if (MinimumLimit.HasValue && MaximumLimit.HasValue && MinimumLimit > MaximumLimit)
                throw new DomainException("الحد الأدنى يجب أن يكون أقل من الحد الأعلى");

            if (MinimumTransactionLimit.HasValue && MaximumTransactionLimit.HasValue && 
                MinimumTransactionLimit > MaximumTransactionLimit)
                throw new DomainException("الحد الأدنى للحركة يجب أن يكون أقل من الحد الأعلى");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AccountCode;
            yield return CurrencyCode ?? string.Empty;
            yield return OpeningBalanceLocal;
            yield return OpeningBalanceForeign;
            yield return CurrentBalanceLocal;
            yield return CurrentBalanceForeign;
            yield return IsInactive;
            yield return InactiveDate ?? DateTime.MinValue;
            yield return MinimumLimit ?? 0;
            yield return MaximumLimit ?? 0;
            yield return MaximumTransactionLimit ?? 0;
            yield return MinimumTransactionLimit ?? 0;
            yield return PassLimit;
        }
    }
} 