using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class Account : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رمز الحساب </summary>
        public string Code { get; private set; }
        /// <summary> اسم الحساب بالعربي </summary>
        public string NameAr { get; private set; }
        /// <summary> اسم الحساب بالإنجليزي </summary>
        public string? NameEn { get; private set; }
        /// <summary> مستوى الحساب </summary>
        public short Level { get; private set; }
        /// <summary> نوع الحساب </summary>
        public AccountType Type { get; private set; }
        /// <summary> تصنيف الحساب </summary>
        public AccountClassification Classification { get; private set; }
        /// <summary> نوع التقرير </summary>
        public AccountReportType ReportType { get; private set; }
        /// <summary> نوع المصروف </summary>
        public AccountExpenseType? ExpenseType { get; private set; }
        /// <summary> نوع التحليل </summary>
        public AccountAnalysis? Analysis { get; private set; }
        /// <summary> رقم التصنيف </summary>
        public int? ClassNo { get; private set; }
        /// <summary> رقم العملية </summary>
        public long? OperationNo { get; private set; }
        /// <summary> نوع الحساب التفصيلي </summary>
        public AccountDetailType? DetailType { get; private set; }
        #endregion

        #region Parent Account
        /// <summary> رمز الحساب الأب </summary>
        public string? ParentCode { get; private set; }
        public Account? Parent { get; private set; }
        #endregion

        #region Settings
        /// <summary> إعدادات الحساب </summary>
        public AccountSettings Settings { get; private set; }
        /// <summary> أعلام الحساب </summary>
        public AccountFlags Flags { get; private set; }
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

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual AccountGrouping AccountGroupingNavigation { get; private set; }
        public virtual AccountReportType AccountReportTypeNavigation { get; private set; }
        public virtual AccountType AccountTypeNavigation { get; private set; }
        public virtual IReadOnlyCollection<AccountCurrency> AccountCurrencies => _accountCurrencies.AsReadOnly();
        public virtual IReadOnlyCollection<CashAtBank> CashAtBanks => _cashAtBanks.AsReadOnly();
        public virtual IReadOnlyCollection<CashInHand> CashInHands => _cashInHands.AsReadOnly();
        public virtual IReadOnlyCollection<Customer> Customers => _customers.AsReadOnly();
        public virtual IReadOnlyCollection<CustomerGroup> CustomerGroups => _customerGroups.AsReadOnly();
        public virtual IReadOnlyCollection<CustomerRequest> CustomerRequests => _customerRequests.AsReadOnly();
        public virtual IReadOnlyCollection<TaxAccount> TaxAccounts => _taxAccounts.AsReadOnly();
        public virtual IReadOnlyCollection<TaxCodeDetail> TaxCodeDetails => _taxCodeDetails.AsReadOnly();
        public virtual IReadOnlyCollection<BankAdjustMaster> BankAdjustMasters => _bankAdjustMasters.AsReadOnly();
        public virtual IReadOnlyCollection<CurrencyDifferenceTmp> CurrencyDifferenceTmps => _currencyDifferenceTmps.AsReadOnly();
        public virtual IReadOnlyCollection<Supplier> Suppliers => _suppliers.AsReadOnly();
        public virtual IReadOnlyCollection<SalesCharges> SalesCharges => _salesCharges.AsReadOnly();
        public virtual IReadOnlyCollection<SupplierGroup> SupplierGroups => _supplierGroups.AsReadOnly();
        public virtual IReadOnlyCollection<Warehouse> Warehouses => _warehouses.AsReadOnly();
        #endregion

        #region Private Collections
        private readonly List<AccountCurrency> _accountCurrencies = new();
        private readonly List<CashAtBank> _cashAtBanks = new();
        private readonly List<CashInHand> _cashInHands = new();
        private readonly List<Customer> _customers = new();
        private readonly List<CustomerGroup> _customerGroups = new();
        private readonly List<CustomerRequest> _customerRequests = new();
        private readonly List<TaxAccount> _taxAccounts = new();
        private readonly List<TaxCodeDetail> _taxCodeDetails = new();
        private readonly List<BankAdjustMaster> _bankAdjustMasters = new();
        private readonly List<CurrencyDifferenceTmp> _currencyDifferenceTmps = new();
        private readonly List<Supplier> _suppliers = new();
        private readonly List<SalesCharges> _salesCharges = new();
        private readonly List<SupplierGroup> _supplierGroups = new();
        private readonly List<Warehouse> _warehouses = new();
        #endregion

        private Account() { } // For EF Core

        public static Account Create(
            string code,
            string nameAr,
            string? nameEn,
            short level,
            AccountType type,
            AccountClassification classification,
            AccountReportType reportType,
            AccountExpenseType? expenseType,
            AccountAnalysis? analysis,
            int? classNo,
            AccountDetailType? detailType,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var account = new Account
            {
                Id = Guid.NewGuid(),
                Code = code,
                NameAr = nameAr,
                NameEn = nameEn,
                Level = level,
                Type = type,
                Classification = classification,
                ReportType = reportType,
                ExpenseType = expenseType,
                Analysis = analysis,
                ClassNo = classNo,
                DetailType = detailType,
                Settings = AccountSettings.Create(false, false),
                Flags = AccountFlags.Create(),
                OpeningBalance = AccountBalance.Create(0, 0),
                CurrentBalance = AccountBalance.Create(0, 0),
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            account.ValidateState();
            account.AddDomainEvent(new AccountCreatedEvent(account));
            return account;
        }

        public void UpdateNames(string nameAr, string? nameEn)
        {
            var oldNameAr = NameAr;
            var oldNameEn = NameEn;

            NameAr = nameAr;
            NameEn = nameEn;

            ValidateState();
            AddDomainEvent(new AccountNamesUpdatedEvent(this, oldNameAr, oldNameEn));
        }

        public void UpdateSettings(AccountSettings newSettings)
        {
            var oldSettings = Settings;
            Settings = newSettings;

            ValidateState();
            AddDomainEvent(new AccountSettingsUpdatedEvent(this, oldSettings, newSettings));
        }

        public void UpdateFlags(AccountFlags newFlags)
        {
            var oldFlags = Flags;
            Flags = newFlags;

            ValidateState();
            AddDomainEvent(new AccountFlagsUpdatedEvent(this, oldFlags, newFlags));
        }

        public void UpdateBalances(AccountBalance newOpeningBalance, AccountBalance newCurrentBalance)
        {
            var oldOpeningBalance = OpeningBalance;
            var oldCurrentBalance = CurrentBalance;

            OpeningBalance = newOpeningBalance;
            CurrentBalance = newCurrentBalance;

            ValidateState();
            AddDomainEvent(new AccountBalanceUpdatedEvent(this, oldOpeningBalance, newCurrentBalance));
        }

        public void SetParent(Account parent)
        {
            if (parent == null)
                throw new DomainException("Parent account cannot be null");

            if (parent.Id == Id)
                throw new DomainException("Account cannot be its own parent");

            if (parent.Level >= Level)
                throw new DomainException("Parent account level must be less than child account level");

            var oldParent = Parent;
            Parent = parent;
            ParentCode = parent.Code;

            ValidateState();
            AddDomainEvent(new AccountParentChangedEvent(this, oldParent!, parent));
        }

        public void Activate()
        {
            if (Settings.IsActive)
                return;

            var oldSettings = Settings;
            Settings = Settings.Activate();

            ValidateState();
            AddDomainEvent(new AccountActivatedEvent(this));
        }

        public void Deactivate(string reason)
        {
            if (!Settings.IsActive)
                return;

            if (string.IsNullOrWhiteSpace(reason))
                throw new DomainException("Deactivation reason is required");

            var oldSettings = Settings;
            Settings = Settings.Deactivate(reason);

            ValidateState();
            AddDomainEvent(new AccountDeactivatedEvent(this, reason));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(Code))
                throw new DomainException("Account code is required");

            if (string.IsNullOrWhiteSpace(NameAr))
                throw new DomainException("Account Arabic name is required");

            if (Level <= 0)
                throw new DomainException("Account level must be positive");

            if (Settings == null)
                throw new DomainException("Account settings are required");

            if (Flags == null)
                throw new DomainException("Account flags are required");

            if (OpeningBalance == null)
                throw new DomainException("Opening balance is required");

            if (CurrentBalance == null)
                throw new DomainException("Current balance is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");

            if (Level > 1 && string.IsNullOrWhiteSpace(ParentCode))
                throw new DomainException("Parent account is required for non-root accounts");
        }
    }
}