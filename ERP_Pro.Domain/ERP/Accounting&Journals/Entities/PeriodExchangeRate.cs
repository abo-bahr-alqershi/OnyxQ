using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class PeriodExchangeRate : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رقم الفترة </summary>
        public short PeriodNo { get; private set; }
        /// <summary> رمز العملة </summary>
        public string CurrencyCode { get; private set; }
        /// <summary> سعر الصرف </summary>
        public ExchangeRate ExchangeRate { get; private set; }
        /// <summary> تاريخ التطبيق </summary>
        public DateTime EffectiveDate { get; private set; }
        /// <summary> تاريخ بداية الفترة </summary>
        public DateTime StartDate { get; private set; }
        /// <summary> تاريخ نهاية الفترة </summary>
        public DateTime EndDate { get; private set; }
        /// <summary> حالة الفترة </summary>
        public bool IsActive { get; private set; }
        /// <summary> ملاحظات </summary>
        public string? Notes { get; private set; }
        /// <summary> نوع سعر الصرف </summary>
        public short ExchangeRateType { get; private set; }
        /// <summary> سعر الصرف للشراء </summary>
        public decimal BuyRate { get; private set; }
        /// <summary> سعر الصرف للبيع </summary>
        public decimal SellRate { get; private set; }
        /// <summary> سعر الصرف الوسطي </summary>
        public decimal MidRate { get; private set; }
        /// <summary> سعر الصرف المحاسبي </summary>
        public decimal AccountingRate { get; private set; }
        /// <summary> سعر الصرف التاريخي </summary>
        public decimal HistoricalRate { get; private set; }
        /// <summary> سعر الصرف المعياري </summary>
        public decimal StandardRate { get; private set; }
        /// <summary> سعر الصرف المرجعي </summary>
        public decimal ReferenceRate { get; private set; }
        /// <summary> علم التحديث التلقائي </summary>
        public bool AutoUpdate { get; private set; }
        /// <summary> مصدر سعر الصرف </summary>
        public string? RateSource { get; private set; }
        /// <summary> رقم المرجع </summary>
        public string? ReferenceNo { get; private set; }
        /// <summary> رقم الموافقة </summary>
        public string? ApprovalNo { get; private set; }
        /// <summary> حالة الموافقة </summary>
        public bool IsApproved { get; private set; }
        /// <summary> تاريخ الموافقة </summary>
        public DateTime? ApprovalDate { get; private set; }
        /// <summary> رقم مستخدم الموافقة </summary>
        public int? ApprovedByUserId { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        public BranchInfo BranchInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual Currency Currency { get; private set; }
        public virtual IReadOnlyCollection<AccountCurrency> AccountCurrencies => _accountCurrencies.AsReadOnly();
        #endregion

        #region Private Collections
        private readonly List<AccountCurrency> _accountCurrencies = new();
        #endregion

        private PeriodExchangeRate() { } // For EF Core

        public static PeriodExchangeRate Create(
            short periodNo,
            string currencyCode,
            ExchangeRate exchangeRate,
            DateTime effectiveDate,
            DateTime startDate,
            DateTime endDate,
            short exchangeRateType,
            decimal buyRate,
            decimal sellRate,
            decimal midRate,
            decimal accountingRate,
            decimal historicalRate,
            decimal standardRate,
            decimal referenceRate,
            bool autoUpdate,
            string? rateSource,
            string? referenceNo,
            string? notes,
            CompanyInfo companyInfo,
            BranchInfo branchInfo,
            int userId,
            string terminal)
        {
            var rate = new PeriodExchangeRate
            {
                Id = Guid.NewGuid(),
                PeriodNo = periodNo,
                CurrencyCode = currencyCode,
                ExchangeRate = exchangeRate,
                EffectiveDate = effectiveDate,
                StartDate = startDate,
                EndDate = endDate,
                ExchangeRateType = exchangeRateType,
                BuyRate = buyRate,
                SellRate = sellRate,
                MidRate = midRate,
                AccountingRate = accountingRate,
                HistoricalRate = historicalRate,
                StandardRate = standardRate,
                ReferenceRate = referenceRate,
                AutoUpdate = autoUpdate,
                RateSource = rateSource,
                ReferenceNo = referenceNo,
                IsActive = true,
                IsApproved = false,
                Notes = notes,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            rate.ValidateState();
            rate.AddDomainEvent(new PeriodExchangeRateCreatedEvent(rate));
            return rate;
        }

        public void UpdateExchangeRate(
            ExchangeRate exchangeRate,
            DateTime effectiveDate,
            short exchangeRateType,
            decimal buyRate,
            decimal sellRate,
            decimal midRate,
            decimal accountingRate,
            decimal historicalRate,
            decimal standardRate,
            decimal referenceRate,
            bool autoUpdate,
            string? rateSource,
            string? referenceNo,
            string? notes,
            int userId,
            string terminal)
        {
            var oldState = new 
            { 
                ExchangeRate, 
                EffectiveDate,
                ExchangeRateType,
                BuyRate,
                SellRate,
                MidRate,
                AccountingRate,
                HistoricalRate,
                StandardRate,
                ReferenceRate,
                AutoUpdate,
                RateSource,
                ReferenceNo,
                Notes 
            };

            ExchangeRate = exchangeRate;
            EffectiveDate = effectiveDate;
            ExchangeRateType = exchangeRateType;
            BuyRate = buyRate;
            SellRate = sellRate;
            MidRate = midRate;
            AccountingRate = accountingRate;
            HistoricalRate = historicalRate;
            StandardRate = standardRate;
            ReferenceRate = referenceRate;
            AutoUpdate = autoUpdate;
            RateSource = rateSource;
            ReferenceNo = referenceNo;
            Notes = notes;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            ValidateState();
            AddDomainEvent(new PeriodExchangeRateUpdatedEvent(this, oldState));
        }

        public void UpdatePeriodDates(
            DateTime startDate,
            DateTime endDate,
            int userId,
            string terminal)
        {
            var oldState = new { StartDate, EndDate };

            StartDate = startDate;
            EndDate = endDate;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            ValidateState();
            AddDomainEvent(new PeriodExchangeRateDatesUpdatedEvent(this, oldState));
        }

        public void Approve(
            string approvalNo,
            int userId,
            string terminal)
        {
            if (IsApproved)
                throw new DomainException("Period exchange rate is already approved");

            var oldState = new { IsApproved, ApprovalNo, ApprovalDate, ApprovedByUserId };

            IsApproved = true;
            ApprovalNo = approvalNo;
            ApprovalDate = DateTime.UtcNow;
            ApprovedByUserId = userId;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodExchangeRateApprovedEvent(this, oldState));
        }

        public void Activate()
        {
            if (IsActive)
                throw new DomainException("Period exchange rate is already active");

            IsActive = true;
            AddDomainEvent(new PeriodExchangeRateActivatedEvent(this));
        }

        public void Deactivate()
        {
            if (!IsActive)
                throw new DomainException("Period exchange rate is already inactive");

            IsActive = false;
            AddDomainEvent(new PeriodExchangeRateDeactivatedEvent(this));
        }

        private void ValidateState()
        {
            if (PeriodNo <= 0)
                throw new DomainException("Period number must be greater than zero");

            if (string.IsNullOrWhiteSpace(CurrencyCode))
                throw new DomainException("Currency code is required");

            if (ExchangeRate == null)
                throw new DomainException("Exchange rate is required");

            if (EffectiveDate == default)
                throw new DomainException("Effective date is required");

            if (StartDate == default)
                throw new DomainException("Start date is required");

            if (EndDate == default)
                throw new DomainException("End date is required");

            if (EndDate <= StartDate)
                throw new DomainException("End date must be after start date");

            if (BuyRate <= 0)
                throw new DomainException("Buy rate must be greater than zero");

            if (SellRate <= 0)
                throw new DomainException("Sell rate must be greater than zero");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (BranchInfo == null)
                throw new DomainException("Branch info is required");
        }
    }
}