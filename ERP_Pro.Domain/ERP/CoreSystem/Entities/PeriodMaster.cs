using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// Represents a period master in the ERP system
    /// يمثل رئيسي الفترة في نظام تخطيط موارد المؤسسات
    /// Table name: S_PRD_MST
    /// </summary>
    public class PeriodMaster : Entity
    {
        private readonly List<PeriodDetail> _periodDetails = new();
        private readonly List<PeriodDay> _periodDays = new();
        private readonly List<PeriodBranchClose> _periodBranchCloses = new();
        private readonly List<PeriodBranchCurrentClose> _periodBranchCurrentCloses = new();

        #region Properties

        /// <summary>
        /// Gets the unique identifier
        /// المعرف الفريد
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the period number (Primary Key)
        /// رقم الفترة (مفتاح رئيسي)
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
        /// Gets the period details collection
        /// مجموعة تفاصيل الفترة
        /// </summary>
        public IReadOnlyCollection<PeriodDetail> PeriodDetails => _periodDetails.AsReadOnly();

        /// <summary>
        /// Gets the period days collection
        /// مجموعة أيام الفترة
        /// </summary>
        public IReadOnlyCollection<PeriodDay> PeriodDays => _periodDays.AsReadOnly();

        /// <summary>
        /// Gets the period branch closes collection
        /// مجموعة إغلاقات فروع الفترة
        /// </summary>
        public IReadOnlyCollection<PeriodBranchClose> PeriodBranchCloses => _periodBranchCloses.AsReadOnly();

        /// <summary>
        /// Gets the period branch current closes collection
        /// مجموعة إغلاقات فروع الفترة الحالية
        /// </summary>
        public IReadOnlyCollection<PeriodBranchCurrentClose> PeriodBranchCurrentCloses => _periodBranchCurrentCloses.AsReadOnly();

        #endregion

        #region Constructors

        private PeriodMaster() { } // For EF Core

        #endregion

        #region Factory Methods

        public static PeriodMaster Create(
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
            var periodMaster = new PeriodMaster
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

            periodMaster.ValidateState();
            periodMaster.AddDomainEvent(new PeriodMasterCreatedEvent(periodMaster));
            return periodMaster;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Deactivates the period master
        /// تعطيل رئيسي الفترة
        /// </summary>
        public void Deactivate(int userId, string terminal)
        {
            if (IsInactive)
                throw new DomainException("Period master is already inactive");

            var oldState = IsInactive;
            IsInactive = true;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodMasterDeactivatedEvent(this, oldState));
        }

        /// <summary>
        /// Activates the period master
        /// تنشيط رئيسي الفترة
        /// </summary>
        public void Activate(int userId, string terminal)
        {
            if (!IsInactive)
                throw new DomainException("Period master is already active");

            var oldState = IsInactive;
            IsInactive = false;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodMasterActivatedEvent(this, oldState));
        }

        /// <summary>
        /// Closes the period master
        /// إغلاق رئيسي الفترة
        /// </summary>
        public void Close(int userId, string terminal)
        {
            if (IsClosed)
                throw new DomainException("Period master is already closed");

            var oldState = IsClosed;
            IsClosed = true;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodMasterClosedEvent(this, oldState));
        }

        /// <summary>
        /// Reopens the period master
        /// إعادة فتح رئيسي الفترة
        /// </summary>
        public void Reopen(int userId, string terminal)
        {
            if (!IsClosed)
                throw new DomainException("Period master is not closed");

            var oldState = IsClosed;
            IsClosed = false;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodMasterReopenedEvent(this, oldState));
        }

        /// <summary>
        /// Updates the period master information
        /// تحديث معلومات رئيسي الفترة
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
            AddDomainEvent(new PeriodMasterInformationUpdatedEvent(
                this,
                oldState.PeriodName,
                oldState.PeriodDescription,
                oldState.FromDate,
                oldState.ToDate));
        }

        /// <summary>
        /// Adds a period detail
        /// إضافة تفاصيل فترة
        /// </summary>
        public void AddPeriodDetail(PeriodDetail periodDetail)
        {
            _periodDetails.Add(periodDetail);
            AddDomainEvent(new PeriodDetailAddedEvent(this, periodDetail));
        }

        /// <summary>
        /// Adds a period day
        /// إضافة يوم فترة
        /// </summary>
        public void AddPeriodDay(PeriodDay periodDay)
        {
            _periodDays.Add(periodDay);
            AddDomainEvent(new PeriodDayAddedEvent(this, periodDay));
        }

        /// <summary>
        /// Adds a period branch close
        /// إضافة إغلاق فرع فترة
        /// </summary>
        public void AddPeriodBranchClose(PeriodBranchClose periodBranchClose)
        {
            _periodBranchCloses.Add(periodBranchClose);
            AddDomainEvent(new PeriodBranchCloseAddedEvent(this, periodBranchClose));
        }

        /// <summary>
        /// Adds a period branch current close
        /// إضافة إغلاق فرع فترة حالي
        /// </summary>
        public void AddPeriodBranchCurrentClose(PeriodBranchCurrentClose periodBranchCurrentClose)
        {
            _periodBranchCurrentCloses.Add(periodBranchCurrentClose);
            AddDomainEvent(new PeriodBranchCurrentCloseAddedEvent(this, periodBranchCurrentClose));
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