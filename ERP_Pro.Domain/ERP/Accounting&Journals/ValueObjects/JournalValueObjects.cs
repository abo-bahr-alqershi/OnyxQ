using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public record JournalType
    {
        public short Value { get; }

        private JournalType(short value)
        {
            if (value <= 0)
                throw new DomainException("Journal type must be greater than zero");
            Value = value;
        }

        public static JournalType Create(short value) => new(value);
    }

    public record DocumentNumber
    {
        public long Value { get; }

        private DocumentNumber(long value)
        {
            if (value <= 0)
                throw new DomainException("Document number must be greater than zero");
            Value = value;
        }

        public static DocumentNumber Create(long value) => new(value);
    }

    public record PostingInfo
    {
        public int? PostUserId { get; }
        public DateTime? PostDate { get; }
        public int? UnpostUserId { get; }
        public DateTime? UnpostDate { get; }
        public int AddedByUserId { get; }
        public DateTime AddedDate { get; }
        public string AddedTerminal { get; }
        public int? UpdatedByUserId { get; }
        public DateTime? UpdatedDate { get; }
        public string? UpdatedTerminal { get; }
        public long UpdateCount { get; }

        private PostingInfo(
            int? postUserId,
            DateTime? postDate,
            int? unpostUserId,
            DateTime? unpostDate,
            int addedByUserId,
            DateTime addedDate,
            string addedTerminal,
            int? updatedByUserId = null,
            DateTime? updatedDate = null,
            string? updatedTerminal = null,
            long updateCount = 0)
        {
            if (string.IsNullOrWhiteSpace(addedTerminal))
                throw new DomainException("Added terminal cannot be empty");

            PostUserId = postUserId;
            PostDate = postDate;
            UnpostUserId = unpostUserId;
            UnpostDate = unpostDate;
            AddedByUserId = addedByUserId;
            AddedDate = addedDate;
            AddedTerminal = addedTerminal;
            UpdatedByUserId = updatedByUserId;
            UpdatedDate = updatedDate;
            UpdatedTerminal = updatedTerminal;
            UpdateCount = updateCount;
        }

        public static PostingInfo Create(int userId, string terminal) =>
            new(null, null, null, null, userId, DateTime.UtcNow, terminal);

        public PostingInfo Post(int userId)
        {
            return new PostingInfo(
                userId,
                DateTime.UtcNow,
                UnpostUserId,
                UnpostDate,
                AddedByUserId,
                AddedDate,
                AddedTerminal,
                userId,
                DateTime.UtcNow,
                UpdatedTerminal,
                UpdateCount + 1);
        }

        public PostingInfo Unpost(int userId)
        {
            return new PostingInfo(
                PostUserId,
                PostDate,
                userId,
                DateTime.UtcNow,
                AddedByUserId,
                AddedDate,
                AddedTerminal,
                userId,
                DateTime.UtcNow,
                UpdatedTerminal,
                UpdateCount + 1);
        }
    }

    public record Money
    {
        public decimal Amount { get; }
        public string CurrencyCode { get; }

        private Money(decimal amount, string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
                throw new DomainException("Currency code is required");

            Amount = amount;
            CurrencyCode = currencyCode;
        }

        public static Money Create(decimal amount, string currencyCode) => new(amount, currencyCode);

        public Money Add(Money other)
        {
            if (other.CurrencyCode != CurrencyCode)
                throw new DomainException("Cannot add money with different currencies");

            return new Money(Amount + other.Amount, CurrencyCode);
        }

        public Money Subtract(Money other)
        {
            if (other.CurrencyCode != CurrencyCode)
                throw new DomainException("Cannot subtract money with different currencies");

            return new Money(Amount - other.Amount, CurrencyCode);
        }

        public Money Multiply(decimal factor)
        {
            return new Money(Amount * factor, CurrencyCode);
        }
    }

    public record ExchangeRate
    {
        public decimal Rate { get; }
        public string FromCurrency { get; }
        public string ToCurrency { get; }

        private ExchangeRate(decimal rate, string fromCurrency, string toCurrency)
        {
            if (rate <= 0)
                throw new DomainException("Exchange rate must be greater than zero");

            if (string.IsNullOrWhiteSpace(fromCurrency))
                throw new DomainException("From currency is required");

            if (string.IsNullOrWhiteSpace(toCurrency))
                throw new DomainException("To currency is required");

            Rate = rate;
            FromCurrency = fromCurrency;
            ToCurrency = toCurrency;
        }

        public static ExchangeRate Create(decimal rate, string fromCurrency, string toCurrency) =>
            new(rate, fromCurrency, toCurrency);

        public Money Convert(Money money)
        {
            if (money.CurrencyCode != FromCurrency)
                throw new DomainException("Cannot convert money with different currency");

            return Money.Create(money.Amount * Rate, ToCurrency);
        }
    }

    public record AccountBalance
    {
        public decimal Debit { get; }
        public decimal Credit { get; }
        public decimal? TemporaryDebit { get; }
        public decimal? TemporaryCredit { get; }

        private AccountBalance(decimal debit, decimal credit, decimal? temporaryDebit = null, decimal? temporaryCredit = null)
        {
            if (debit < 0)
                throw new DomainException("Debit amount cannot be negative");

            if (credit < 0)
                throw new DomainException("Credit amount cannot be negative");

            Debit = debit;
            Credit = credit;
            TemporaryDebit = temporaryDebit;
            TemporaryCredit = temporaryCredit;
        }

        public static AccountBalance Create(decimal debit, decimal credit, decimal? temporaryDebit = null, decimal? temporaryCredit = null) =>
            new(debit, credit, temporaryDebit, temporaryCredit);
    }

    public record AccountSettings
    {
        public bool IsGroup { get; }
        public bool IsMain { get; }
        public bool IsActive { get; }
        public bool AcceptsEntries { get; }
        public bool AcceptsForeignCurrency { get; }
        public bool RequiresCostCenter { get; }
        public bool RequiresProject { get; }
        public bool UsesTDS { get; }
        public bool IsAdvanceExpenseRevenue { get; }

        private AccountSettings(
            bool isGroup,
            bool isMain,
            bool isActive = true,
            bool acceptsEntries = true,
            bool acceptsForeignCurrency = false,
            bool requiresCostCenter = false,
            bool requiresProject = false,
            bool usesTDS = false,
            bool isAdvanceExpenseRevenue = false)
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
            new(IsGroup, IsMain, isActive, AcceptsEntries, AcceptsForeignCurrency, RequiresCostCenter, RequiresProject, UsesTDS, IsAdvanceExpenseRevenue);
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
            bool isClosed = false,
            bool isDebit = false,
            bool isFavorite = false,
            bool isFlowType = false,
            bool isConnectedToPeriod = false,
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

    public record CompanyInfo
    {
        public int CompanyNo { get; }
        public int BranchNo { get; }
        public int? DepartmentNo { get; }

        private CompanyInfo(int companyNo, int branchNo, int? departmentNo = null)
        {
            if (companyNo <= 0)
                throw new DomainException("Company number must be greater than zero");

            if (branchNo <= 0)
                throw new DomainException("Branch number must be greater than zero");

            CompanyNo = companyNo;
            BranchNo = branchNo;
            DepartmentNo = departmentNo;
        }

        public static CompanyInfo Create(int companyNo, int branchNo, int? departmentNo = null) =>
            new(companyNo, branchNo, departmentNo);
    }

    public record BranchInfo
    {
        public int BranchNo { get; }
        public string BranchCode { get; }
        public string BranchName { get; }

        private BranchInfo(int branchNo, string branchCode, string branchName)
        {
            if (branchNo <= 0)
                throw new DomainException("Branch number must be greater than zero");

            if (string.IsNullOrWhiteSpace(branchCode))
                throw new DomainException("Branch code is required");

            if (string.IsNullOrWhiteSpace(branchName))
                throw new DomainException("Branch name is required");

            BranchNo = branchNo;
            BranchCode = branchCode;
            BranchName = branchName;
        }

        public static BranchInfo Create(int branchNo, string branchCode, string branchName) =>
            new(branchNo, branchCode, branchName);
    }

    public record AuditInfo
    {
        public int CreatedByUserId { get; }
        public DateTime CreatedDate { get; }
        public string CreatedTerminal { get; }
        public int? ModifiedByUserId { get; }
        public DateTime? ModifiedDate { get; }
        public string? ModifiedTerminal { get; }

        private AuditInfo(
            int createdByUserId,
            DateTime createdDate,
            string createdTerminal,
            int? modifiedByUserId = null,
            DateTime? modifiedDate = null,
            string? modifiedTerminal = null)
        {
            if (createdByUserId <= 0)
                throw new DomainException("Created by user ID must be greater than zero");

            if (string.IsNullOrWhiteSpace(createdTerminal))
                throw new DomainException("Created terminal is required");

            CreatedByUserId = createdByUserId;
            CreatedDate = createdDate;
            CreatedTerminal = createdTerminal;
            ModifiedByUserId = modifiedByUserId;
            ModifiedDate = modifiedDate;
            ModifiedTerminal = modifiedTerminal;
        }

        public static AuditInfo Create(int userId, string terminal) =>
            new(userId, DateTime.UtcNow, terminal);

        public AuditInfo WithModification(int userId, string terminal) =>
            new(CreatedByUserId, CreatedDate, CreatedTerminal, userId, DateTime.UtcNow, terminal);
    }
} 