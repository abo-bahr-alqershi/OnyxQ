using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class AccountCurrency : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
    /// <summary> رمز الحساب الرئيسي المرتبط بهذه العملة </summary>
        public string AccountCode { get; private set; }
        /// <summary> رمز العملة (مثال: SAR, USD) </summary>
        public string CurrencyCode { get; private set; }
    /// <summary> علم يحدد إذا كانت هذه العملة مفعلة أم لا للحساب </summary>
        public bool IsInactive { get; private set; }
    /// <summary> علم يحدد إذا تم استخدام هذه العملة ضمن عمليات الحساب </summary>
        public bool IsUsed { get; private set; }
        #endregion

        #region Balance Info
        /// <summary> معلومات الرصيد الافتتاحي </summary>
        public AccountBalance OpeningBalance { get; private set; }
        /// <summary> معلومات الرصيد الحالي </summary>
        public AccountBalance CurrentBalance { get; private set; }

        // Keep original fields for backward compatibility and data mapping
        /// <summary> الرصيد الافتتاحي مدين </summary>
        public decimal OpeningBalanceDebit => OpeningBalance.Debit;
        /// <summary> الرصيد الافتتاحي دائن </summary>
        public decimal OpeningBalanceCredit => OpeningBalance.Credit;
        /// <summary> الرصيد الحالي مدين </summary>
        public decimal CurrentBalanceDebit => CurrentBalance.Debit;
        /// <summary> الرصيد الحالي دائن </summary>
        public decimal CurrentBalanceCredit => CurrentBalance.Credit;
        /// <summary> الرصيد المؤقت مدين </summary>
        public decimal? TemporaryBalanceDebit => CurrentBalance.TemporaryDebit;
        /// <summary> الرصيد المؤقت دائن </summary>
        public decimal? TemporaryBalanceCredit => CurrentBalance.TemporaryCredit;
        #endregion

        #region Exchange Rate Info
        /// <summary> معلومات أسعار الصرف </summary>
        private readonly List<ExchangeRate> _exchangeRates = new();
        public IReadOnlyCollection<ExchangeRate> ExchangeRates => _exchangeRates.AsReadOnly();

        // Keep original fields for backward compatibility and data mapping
        /// <summary> سعر الصرف الافتتاحي </summary>
        public decimal OpeningExchangeRate => GetExchangeRate(ExchangeRateType.Opening)?.Rate ?? 1m;
        /// <summary> سعر الصرف الحالي </summary>
        public decimal CurrentExchangeRate => GetExchangeRate(ExchangeRateType.Current)?.Rate ?? 1m;
        /// <summary> سعر الصرف المؤقت </summary>
        public decimal? TemporaryExchangeRate => GetExchangeRate(ExchangeRateType.Temporary)?.Rate;
        #endregion

        #region Additional Info
        /// <summary> معلومات حسابات فروق العملة </summary>
        public CurrencyDifferenceAccount DifferenceAccount { get; private set; }

        // Keep original fields for backward compatibility and data mapping
        /// <summary> رقم الحساب المرتبط بفروق العملة </summary>
        public string? CurrencyDiffAccountCode => DifferenceAccount.MainAccountCode;
        /// <summary> رقم حساب فروق العملة المدين </summary>
        public string? DebitDiffAccountCode => DifferenceAccount.DebitAccountCode;
        /// <summary> رقم حساب فروق العملة الدائن </summary>
        public string? CreditDiffAccountCode => DifferenceAccount.CreditAccountCode;
        /// <summary> علم يحدد إذا كان يتم استخدام حساب فروق العملة </summary>
        public bool UseCurrencyDiffAccount => DifferenceAccount.UseCurrencyDiffAccount;
        /// <summary> علم يحدد إذا كان يتم استخدام حسابات فروق العملة المنفصلة </summary>
        public bool UseSeparateDiffAccounts => DifferenceAccount.UseSeparateDiffAccounts;
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual Account Account { get; private set; }
        public virtual Account CurrencyDiffAccount { get; private set; }
        public virtual Account DebitDiffAccount { get; private set; }
        public virtual Account CreditDiffAccount { get; private set; }
        public virtual ICollection<JournalDetail> JournalDetails { get; private set; } = new List<JournalDetail>();
        public virtual ICollection<VoucherDetail> VoucherDetails { get; private set; } = new List<VoucherDetail>();
        #endregion

        private AccountCurrency() { } // For EF Core

        public static AccountCurrency Create(
            string accountCode,
            string currencyCode,
            decimal openingExchangeRate,
            decimal currentExchangeRate,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var accountCurrency = new AccountCurrency
            {
                Id = Guid.NewGuid(),
                AccountCode = accountCode,
                CurrencyCode = currencyCode,
                IsInactive = false,
                IsUsed = false,
                OpeningBalance = AccountBalance.Create(0, 0),
                CurrentBalance = AccountBalance.Create(0, 0),
                DifferenceAccount = CurrencyDifferenceAccount.Create(),
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            accountCurrency._exchangeRates.Add(ExchangeRate.Create(openingExchangeRate, DateTime.UtcNow, ExchangeRateType.Opening));
            accountCurrency._exchangeRates.Add(ExchangeRate.Create(currentExchangeRate, DateTime.UtcNow, ExchangeRateType.Current));

            accountCurrency.AddDomainEvent(new AccountCurrencyCreatedEvent(accountCurrency));
            return accountCurrency;
        }

        public void UpdateBalances(
            decimal openingBalanceDebit,
            decimal openingBalanceCredit,
            decimal currentBalanceDebit,
            decimal currentBalanceCredit,
            decimal? temporaryBalanceDebit = null,
            decimal? temporaryBalanceCredit = null)
        {
            var oldOpeningBalance = OpeningBalance;
            var oldCurrentBalance = CurrentBalance;

            OpeningBalance = AccountBalance.Create(openingBalanceDebit, openingBalanceCredit);
            CurrentBalance = AccountBalance.Create(currentBalanceDebit, currentBalanceCredit, temporaryBalanceDebit, temporaryBalanceCredit);

            AddDomainEvent(new AccountCurrencyBalancesUpdatedEvent(
                this,
                oldOpeningBalance.Debit,
                oldOpeningBalance.Credit,
                oldCurrentBalance.Debit,
                oldCurrentBalance.Credit));
        }

        public void UpdateExchangeRates(
            decimal openingExchangeRate,
            decimal currentExchangeRate,
            decimal? temporaryExchangeRate = null)
        {
            var oldOpeningExchangeRate = OpeningExchangeRate;
            var oldCurrentExchangeRate = CurrentExchangeRate;

            UpdateExchangeRate(ExchangeRateType.Opening, openingExchangeRate);
            UpdateExchangeRate(ExchangeRateType.Current, currentExchangeRate);
            
            if (temporaryExchangeRate.HasValue)
                UpdateExchangeRate(ExchangeRateType.Temporary, temporaryExchangeRate.Value);
            else
                RemoveExchangeRate(ExchangeRateType.Temporary);

            AddDomainEvent(new AccountCurrencyExchangeRatesUpdatedEvent(
                this,
                oldOpeningExchangeRate,
                oldCurrentExchangeRate));
        }

        public void UpdateDifferenceAccounts(
            string? currencyDiffAccountCode,
            string? debitDiffAccountCode = null,
            string? creditDiffAccountCode = null,
            bool useCurrencyDiffAccount = false,
            bool useSeparateDiffAccounts = false)
        {
            var oldDifferenceAccount = DifferenceAccount;

            DifferenceAccount = CurrencyDifferenceAccount.Create(
                currencyDiffAccountCode,
                debitDiffAccountCode,
                creditDiffAccountCode,
                useCurrencyDiffAccount,
                useSeparateDiffAccounts);

            AddDomainEvent(new AccountCurrencyDifferenceAccountsUpdatedEvent(
                this,
                oldDifferenceAccount.MainAccountCode,
                oldDifferenceAccount.DebitAccountCode,
                oldDifferenceAccount.CreditAccountCode));
        }

        public void Activate()
        {
            if (!IsInactive)
                throw new DomainException("Account currency is already active");

            IsInactive = false;
            AddDomainEvent(new AccountCurrencyActivatedEvent(this));
        }

        public void Deactivate()
        {
            if (IsInactive)
                throw new DomainException("Account currency is already inactive");

            IsInactive = true;
            AddDomainEvent(new AccountCurrencyDeactivatedEvent(this));
        }

        private ExchangeRate? GetExchangeRate(ExchangeRateType type) =>
            _exchangeRates.FirstOrDefault(r => r.Type == type);

        private void UpdateExchangeRate(ExchangeRateType type, decimal rate)
        {
            var existingRate = GetExchangeRate(type);
            if (existingRate != null)
                _exchangeRates.Remove(existingRate);

            _exchangeRates.Add(ExchangeRate.Create(rate, DateTime.UtcNow, type));
        }

        private void RemoveExchangeRate(ExchangeRateType type)
        {
            var existingRate = GetExchangeRate(type);
            if (existingRate != null)
                _exchangeRates.Remove(existingRate);
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(AccountCode))
                throw new DomainException("Account code is required");

            if (string.IsNullOrWhiteSpace(CurrencyCode))
                throw new DomainException("Currency code is required");

            if (!_exchangeRates.Any(r => r.Type == ExchangeRateType.Opening))
                throw new DomainException("Opening exchange rate is required");

            if (!_exchangeRates.Any(r => r.Type == ExchangeRateType.Current))
                throw new DomainException("Current exchange rate is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (DifferenceAccount.UseSeparateDiffAccounts)
            {
                if (string.IsNullOrWhiteSpace(DifferenceAccount.DebitAccountCode))
                    throw new DomainException("Debit difference account code is required when using separate difference accounts");

                if (string.IsNullOrWhiteSpace(DifferenceAccount.CreditAccountCode))
                    throw new DomainException("Credit difference account code is required when using separate difference accounts");
            }
            else if (DifferenceAccount.UseCurrencyDiffAccount && string.IsNullOrWhiteSpace(DifferenceAccount.MainAccountCode))
            {
                throw new DomainException("Currency difference account code is required when using currency difference account");
            }
        }
    }
}