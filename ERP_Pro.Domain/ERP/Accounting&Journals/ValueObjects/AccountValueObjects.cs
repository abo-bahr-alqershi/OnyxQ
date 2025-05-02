using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public record AccountCode
    {
        public string Value { get; }

        private AccountCode(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new DomainException("Account code cannot be empty");
            Value = value;
        }

        public static AccountCode Create(string value) => new(value);
    }

    public record AccountName
    {
        public string Value { get; }

        private AccountName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new DomainException("Account name cannot be empty");
            Value = value;
        }

        public static AccountName Create(string value) => new(value);
    }

    public record AccountLevel
    {
        public int Value { get; }

        private AccountLevel(int value)
        {
            if (value <= 0)
                throw new DomainException("Account level must be greater than zero");
            Value = value;
        }

        public static AccountLevel Create(int value) => new(value);
    }

    public record AccountAnalysis
    {
        public int Value { get; }
        public string? Description { get; }

        private AccountAnalysis(int value, string? description)
        {
            if (value < 0)
                throw new DomainException("Account analysis value cannot be negative");
            Value = value;
            Description = description;
        }

        public static AccountAnalysis Create(int value, string? description = null) => new(value, description);
    }

    public record AccountExpenseType
    {
        /// <summary> رمز نوع المصروف </summary>
        public short Code { get; }
        /// <summary> وصف نوع المصروف </summary>
        public string Description { get; }
        public bool UsesExpenseBranch { get; }
        public bool ImportFromExcel { get; }

        private AccountExpenseType(short code, string description, bool usesExpenseBranch, bool importFromExcel)
        {
            if (code <= 0)
                throw new DomainException("Account expense type code must be greater than zero");

            if (string.IsNullOrWhiteSpace(description))
                throw new DomainException("Account expense type description is required");

            Code = code;
            Description = description;
            UsesExpenseBranch = usesExpenseBranch;
            ImportFromExcel = importFromExcel;
        }

        public static AccountExpenseType Create(short code, string description, bool usesExpenseBranch = false, bool importFromExcel = false) =>
            new(code, description, usesExpenseBranch, importFromExcel);

        public static AccountExpenseType Administrative => new(1, "إداري", true, false);
        public static AccountExpenseType Sales => new(2, "بيعي", true, false);
        public static AccountExpenseType Production => new(3, "إنتاجي", true, false);
        public static AccountExpenseType Financial => new(4, "مالي", true, false);
    }

    public record AccountDetailType
    {
        public short Value { get; }
        public bool UsesActivity { get; }

        private AccountDetailType(short value, bool usesActivity)
        {
            if (value < 0)
                throw new DomainException("Account detail type value cannot be negative");
            Value = value;
            UsesActivity = usesActivity;
        }

        public static AccountDetailType Create(short value, bool usesActivity = false) => new(value, usesActivity);
    }

    public record AccountFlags
    {
        public bool IsClosed { get; }
        public bool IsDebit { get; }
        public bool IsFavorite { get; }
        public bool IsFlowType { get; }
        public bool IsConnectedToPeriod { get; }
        public string? InactiveReason { get; }
        public DateTime? InactiveDate { get; }
        public DateTime? LastConfirmationDate { get; }

        private AccountFlags(
            bool isClosed,
            bool isDebit,
            bool isFavorite,
            bool isFlowType,
            bool isConnectedToPeriod,
            string? inactiveReason = null,
            DateTime? inactiveDate = null,
            DateTime? lastConfirmationDate = null)
        {
            IsClosed = isClosed;
            IsDebit = isDebit;
            IsFavorite = isFavorite;
            IsFlowType = isFlowType;
            IsConnectedToPeriod = isConnectedToPeriod;
            InactiveReason = inactiveReason;
            InactiveDate = inactiveDate;
            LastConfirmationDate = lastConfirmationDate;
        }

        public static AccountFlags Create(
            bool isClosed = false,
            bool isDebit = false,
            bool isFavorite = false,
            bool isFlowType = false,
            bool isConnectedToPeriod = false,
            string? inactiveReason = null,
            DateTime? inactiveDate = null,
            DateTime? lastConfirmationDate = null) =>
            new(isClosed, isDebit, isFavorite, isFlowType, isConnectedToPeriod, inactiveReason, inactiveDate, lastConfirmationDate);
    }

    public record AccountSettings
    {
        /// <summary> حساب مجمع </summary>
        public bool IsGroup { get; }
        /// <summary> حساب رئيسي </summary>
        public bool IsMain { get; }
        /// <summary> حساب فعال </summary>
        public bool IsActive { get; }
        /// <summary> يقبل القيود </summary>
        public bool AcceptsEntries { get; }
        /// <summary> يقبل العملات الأجنبية </summary>
        public bool AcceptsForeignCurrency { get; }
        /// <summary> يتطلب مركز تكلفة </summary>
        public bool RequiresCostCenter { get; }
        /// <summary> يتطلب مشروع </summary>
        public bool RequiresProject { get; }
        public bool UsesTDS { get; }
        public bool IsAdvanceExpenseRevenue { get; }

        private AccountSettings(
            bool isGroup,
            bool isMain,
            bool isActive,
            bool acceptsEntries,
            bool acceptsForeignCurrency,
            bool requiresCostCenter,
            bool requiresProject,
            bool usesTDS,
            bool isAdvanceExpenseRevenue)
        {
            IsGroup = isGroup;
            IsMain = isMain;
            IsActive = isActive;
            AcceptsEntries = acceptsEntries;
            AcceptsForeignCurrency = acceptsForeignCurrency;
            RequiresCostCenter = requiresCostCenter;
            RequiresProject = requiresProject;
            UsesTDS = usesTDS;
            IsAdvanceExpenseRevenue = isAdvanceExpenseRevenue;
        }

        public static AccountSettings Create(
            bool isGroup,
            bool isMain,
            bool isActive = true,
            bool acceptsEntries = true,
            bool acceptsForeignCurrency = false,
            bool requiresCostCenter = false,
            bool requiresProject = false,
            bool usesTDS = false,
            bool isAdvanceExpenseRevenue = false) =>
            new(isGroup, isMain, isActive, acceptsEntries, acceptsForeignCurrency, requiresCostCenter, requiresProject, usesTDS, isAdvanceExpenseRevenue);

        public AccountSettings WithActive(bool isActive) =>
            this with { IsActive = isActive };

        public AccountSettings WithEntryAcceptance(bool acceptsEntries) =>
            this with { AcceptsEntries = acceptsEntries };

        public AccountSettings WithForeignCurrencyAcceptance(bool acceptsForeignCurrency) =>
            this with { AcceptsForeignCurrency = acceptsForeignCurrency };
    }

    public record ExchangeRate
    {
        /// <summary> سعر الصرف </summary>
        public decimal Rate { get; }
        /// <summary> تاريخ سعر الصرف </summary>
        public DateTime EffectiveDate { get; }
        /// <summary> نوع سعر الصرف (افتتاحي، حالي، مؤقت) </summary>
        public ExchangeRateType Type { get; }

        private ExchangeRate(decimal rate, DateTime effectiveDate, ExchangeRateType type)
        {
            if (rate <= 0)
                throw new DomainException("Exchange rate must be greater than zero");

            Rate = rate;
            EffectiveDate = effectiveDate;
            Type = type;
        }

        public static ExchangeRate Create(decimal rate, DateTime effectiveDate, ExchangeRateType type = ExchangeRateType.Current) =>
            new(rate, effectiveDate, type);

        public ExchangeRate WithNewRate(decimal newRate) =>
            this with { Rate = newRate };
    }

    public enum ExchangeRateType
    {
        /// <summary> سعر الصرف الافتتاحي </summary>
        Opening = 1,
        /// <summary> سعر الصرف الحالي </summary>
        Current = 2,
        /// <summary> سعر الصرف المؤقت </summary>
        Temporary = 3
    }

    public record CurrencyDifferenceAccount
    {
        /// <summary> رقم الحساب المرتبط بفروق العملة </summary>
        public string? MainAccountCode { get; }
        /// <summary> رقم حساب فروق العملة المدين </summary>
        public string? DebitAccountCode { get; }
        /// <summary> رقم حساب فروق العملة الدائن </summary>
        public string? CreditAccountCode { get; }
        /// <summary> علم يحدد إذا كان يتم استخدام حساب فروق العملة </summary>
        public bool UseCurrencyDiffAccount { get; }
        /// <summary> علم يحدد إذا كان يتم استخدام حسابات فروق العملة المنفصلة </summary>
        public bool UseSeparateDiffAccounts { get; }

        private CurrencyDifferenceAccount(
            string? mainAccountCode,
            string? debitAccountCode,
            string? creditAccountCode,
            bool useCurrencyDiffAccount,
            bool useSeparateDiffAccounts)
        {
            if (useCurrencyDiffAccount && string.IsNullOrWhiteSpace(mainAccountCode))
                throw new DomainException("Main currency difference account code is required when using currency difference account");

            if (useSeparateDiffAccounts)
            {
                if (string.IsNullOrWhiteSpace(debitAccountCode))
                    throw new DomainException("Debit difference account code is required when using separate difference accounts");
                if (string.IsNullOrWhiteSpace(creditAccountCode))
                    throw new DomainException("Credit difference account code is required when using separate difference accounts");
            }

            MainAccountCode = mainAccountCode;
            DebitAccountCode = debitAccountCode;
            CreditAccountCode = creditAccountCode;
            UseCurrencyDiffAccount = useCurrencyDiffAccount;
            UseSeparateDiffAccounts = useSeparateDiffAccounts;
        }

        public static CurrencyDifferenceAccount Create(
            string? mainAccountCode = null,
            string? debitAccountCode = null,
            string? creditAccountCode = null,
            bool useCurrencyDiffAccount = false,
            bool useSeparateDiffAccounts = false) =>
            new(mainAccountCode, debitAccountCode, creditAccountCode, useCurrencyDiffAccount, useSeparateDiffAccounts);

        public CurrencyDifferenceAccount WithMainAccount(string mainAccountCode) =>
            this with { MainAccountCode = mainAccountCode, UseCurrencyDiffAccount = true };

        public CurrencyDifferenceAccount WithSeparateAccounts(string debitAccountCode, string creditAccountCode) =>
            this with
            {
                DebitAccountCode = debitAccountCode,
                CreditAccountCode = creditAccountCode,
                UseSeparateDiffAccounts = true
            };

        public CurrencyDifferenceAccount DisableAll() =>
            this with
            {
                MainAccountCode = null,
                DebitAccountCode = null,
                CreditAccountCode = null,
                UseCurrencyDiffAccount = false,
                UseSeparateDiffAccounts = false
            };
    }
} 