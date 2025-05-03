using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// Represents a period detail in the ERP system
    /// يمثل تفاصيل الفترة في نظام تخطيط موارد المؤسسات
    /// Table name: S_PRD_DTL
    /// </summary>
    public class PeriodDetail : Entity
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
        /// Gets the period type
        /// نوع الفترة
        /// </summary>
        public short PeriodType { get; private set; }

        /// <summary>
        /// Gets the period name
        /// اسم الفترة
        /// </summary>
        public string PeriodName { get; private set; }

        /// <summary>
        /// Gets the period description
        /// وصف الفترة
        /// </summary>
        public string? PeriodDescription { get; private set; }

        /// <summary>
        /// Gets the from date
        /// من تاريخ
        /// </summary>
        public DateTime FromDate { get; private set; }

        /// <summary>
        /// Gets the to date
        /// إلى تاريخ
        /// </summary>
        public DateTime ToDate { get; private set; }

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
        /// Gets a value indicating whether the period is closed
        /// هل الفترة مغلقة
        /// </summary>
        public bool IsClosed { get; private set; }

        /// <summary>
        /// Gets the company information
        /// معلومات الشركة
        /// </summary>
        public CompanyInfo CompanyInfo { get; private set; }

        /// <summary>
        /// Gets the audit information
        /// معلومات التدقيق
        /// </summary>
        public AuditInfo AuditInfo { get; private set; }

        /// <summary>
        /// Gets the period master reference
        /// مرجع رئيسي الفترة
        /// </summary>
        public virtual PeriodMaster PeriodMaster { get; private set; }

        #endregion

        #region Constructors

        private PeriodDetail() { } // For EF Core

        #endregion

        #region Factory Methods

        public static PeriodDetail Create(
            short periodNumber,
            short periodType,
            string periodName,
            string? periodDescription,
            DateTime fromDate,
            DateTime toDate,
            short yearNumber,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var periodDetail = new PeriodDetail
            {
                Id = Guid.NewGuid(),
                PeriodNumber = periodNumber,
                PeriodType = periodType,
                PeriodName = periodName,
                PeriodDescription = periodDescription,
                FromDate = fromDate,
                ToDate = toDate,
                YearNumber = yearNumber,
                IsInactive = false,
                IsClosed = false,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            periodDetail.ValidateState();
            periodDetail.AddDomainEvent(new PeriodDetailCreatedEvent(periodDetail));
            return periodDetail;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Deactivates the period detail
        /// تعطيل تفاصيل الفترة
        /// </summary>
        public void Deactivate(int userId, string terminal)
        {
            if (IsInactive)
                throw new DomainException("Period detail is already inactive");

            var oldState = IsInactive;
            IsInactive = true;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodDetailDeactivatedEvent(this, oldState));
        }

        /// <summary>
        /// Activates the period detail
        /// تنشيط تفاصيل الفترة
        /// </summary>
        public void Activate(int userId, string terminal)
        {
            if (!IsInactive)
                throw new DomainException("Period detail is already active");

            var oldState = IsInactive;
            IsInactive = false;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodDetailActivatedEvent(this, oldState));
        }

        /// <summary>
        /// Closes the period detail
        /// إغلاق تفاصيل الفترة
        /// </summary>
        public void Close(int userId, string terminal)
        {
            if (IsClosed)
                throw new DomainException("Period detail is already closed");

            var oldState = IsClosed;
            IsClosed = true;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodDetailClosedEvent(this, oldState));
        }

        /// <summary>
        /// Reopens the period detail
        /// إعادة فتح تفاصيل الفترة
        /// </summary>
        public void Reopen(int userId, string terminal)
        {
            if (!IsClosed)
                throw new DomainException("Period detail is not closed");

            var oldState = IsClosed;
            IsClosed = false;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodDetailReopenedEvent(this, oldState));
        }

        /// <summary>
        /// Updates the period detail information
        /// تحديث معلومات تفاصيل الفترة
        /// </summary>
        public void UpdateInformation(
            string periodName,
            string? periodDescription,
            DateTime fromDate,
            DateTime toDate,
            int userId,
            string terminal)
        {
            var oldState = (PeriodName, PeriodDescription, FromDate, ToDate);

            PeriodName = periodName;
            PeriodDescription = periodDescription;
            FromDate = fromDate;
            ToDate = toDate;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            ValidateState();
            AddDomainEvent(new PeriodDetailInformationUpdatedEvent(
                this,
                oldState.PeriodName,
                oldState.PeriodDescription,
                oldState.FromDate,
                oldState.ToDate));
        }

        #endregion

        #region Private Methods

        private void ValidateState()
        {
            if (PeriodNumber <= 0)
                throw new DomainException("Period number must be greater than zero");

            if (PeriodType <= 0)
                throw new DomainException("Period type must be greater than zero");

            if (string.IsNullOrWhiteSpace(PeriodName))
                throw new DomainException("Period name is required");

            if (FromDate == default)
                throw new DomainException("From date is required");

            if (ToDate == default)
                throw new DomainException("To date is required");

            if (ToDate <= FromDate)
                throw new DomainException("To date must be greater than from date");

            if (YearNumber <= 0)
                throw new DomainException("Year number must be greater than zero");

            if (CompanyInfo == null)
                throw new DomainException("Company information is required");
        }

        #endregion
    }
} 