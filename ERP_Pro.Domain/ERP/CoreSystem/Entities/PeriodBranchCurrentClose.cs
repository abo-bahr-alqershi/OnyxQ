using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// Represents the current closing status of a period for a specific branch and currency
    /// يمثل حالة الإقفال الحالية للفترة لفرع وعملة محددين
    /// </summary>
    public class PeriodBranchCurrentClose : Entity
    {
        #region Properties

        /// <summary>
        /// Gets the unique identifier
        /// المعرف الفريد
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the period number
        /// رقم الفترة
        /// </summary>
        public short PeriodNumber { get; private set; }

        /// <summary>
        /// Gets the branch number
        /// رقم الفرع
        /// </summary>
        public int BranchNumber { get; private set; }

        /// <summary>
        /// Gets the currency code
        /// رمز العملة
        /// </summary>
        public string CurrencyCode { get; private set; }

        /// <summary>
        /// Gets the currency exchange rate
        /// سعر صرف العملة
        /// </summary>
        public ExchangeRate ExchangeRate { get; private set; }

        /// <summary>
        /// Gets the period date
        /// تاريخ الفترة
        /// </summary>
        public DateTime PeriodDate { get; private set; }

        /// <summary>
        /// Gets the year number
        /// رقم السنة
        /// </summary>
        public short YearNumber { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the period is inactive
        /// هل الفترة غير نشطة
        /// </summary>
        public bool IsInactive { get; private set; }

        /// <summary>
        /// Gets the company information
        /// معلومات الشركة
        /// </summary>
        public CompanyInfo CompanyInfo { get; private set; }

        /// <summary>
        /// Gets the branch information
        /// معلومات الفرع
        /// </summary>
        public BranchInfo BranchInfo { get; private set; }

        /// <summary>
        /// Gets the audit information
        /// معلومات التدقيق
        /// </summary>
        public AuditInfo AuditInfo { get; private set; }

        #endregion

        #region Constructors

        private PeriodBranchCurrentClose() { } // For EF Core

        #endregion

        #region Factory Methods

        public static PeriodBranchCurrentClose Create(
            short periodNumber,
            int branchNumber,
            string currencyCode,
            ExchangeRate exchangeRate,
            DateTime periodDate,
            short yearNumber,
            CompanyInfo companyInfo,
            BranchInfo branchInfo,
            int userId,
            string terminal)
        {
            var close = new PeriodBranchCurrentClose
            {
                Id = Guid.NewGuid(),
                PeriodNumber = periodNumber,
                BranchNumber = branchNumber,
                CurrencyCode = currencyCode,
                ExchangeRate = exchangeRate,
                PeriodDate = periodDate,
                YearNumber = yearNumber,
                IsInactive = false,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            close.ValidateState();
            close.AddDomainEvent(new PeriodBranchCurrentCloseCreatedEvent(close));
            return close;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Deactivates the period branch current close
        /// تعطيل إقفال الفترة الحالي للفرع
        /// </summary>
        public void Deactivate(int userId, string terminal)
        {
            if (IsInactive)
                throw new DomainException("Period branch current close is already inactive");

            var oldState = IsInactive;
            IsInactive = true;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodBranchCurrentCloseDeactivatedEvent(this, oldState));
        }

        /// <summary>
        /// Activates the period branch current close
        /// تنشيط إقفال الفترة الحالي للفرع
        /// </summary>
        public void Activate(int userId, string terminal)
        {
            if (!IsInactive)
                throw new DomainException("Period branch current close is already active");

            var oldState = IsInactive;
            IsInactive = false;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodBranchCurrentCloseActivatedEvent(this, oldState));
        }

        /// <summary>
        /// Updates the exchange rate
        /// تحديث سعر الصرف
        /// </summary>
        public void UpdateExchangeRate(
            ExchangeRate newExchangeRate,
            int userId,
            string terminal)
        {
            var oldRate = ExchangeRate;
            ExchangeRate = newExchangeRate;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodBranchCurrentCloseExchangeRateUpdatedEvent(this, oldRate));
        }

        #endregion

        #region Private Methods

        private void ValidateState()
        {
            if (PeriodNumber <= 0)
                throw new DomainException("Period number must be greater than zero");

            if (BranchNumber <= 0)
                throw new DomainException("Branch number must be greater than zero");

            if (string.IsNullOrWhiteSpace(CurrencyCode))
                throw new DomainException("Currency code is required");

            if (ExchangeRate == null)
                throw new DomainException("Exchange rate is required");

            if (PeriodDate == default)
                throw new DomainException("Period date is required");

            if (YearNumber <= 0)
                throw new DomainException("Year number must be greater than zero");

            if (CompanyInfo == null)
                throw new DomainException("Company information is required");

            if (BranchInfo == null)
                throw new DomainException("Branch information is required");
        }

        #endregion
    }
} 