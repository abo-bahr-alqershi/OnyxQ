using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// Represents a period day in the ERP system
    /// يمثل يوم الفترة في نظام تخطيط موارد المؤسسات
    /// Table name: S_PRD_DAY
    /// </summary>
    public class PeriodDay : Entity
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
        /// Gets the day number
        /// رقم اليوم
        /// </summary>
        public short DayNumber { get; private set; }

        /// <summary>
        /// Gets the day date
        /// تاريخ اليوم
        /// </summary>
        public DateTime DayDate { get; private set; }

        /// <summary>
        /// Gets the year number
        /// رقم السنة
        /// </summary>
        public short YearNumber { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the day is inactive
        /// هل اليوم غير نشط
        /// </summary>
        public bool IsInactive { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the day is a holiday
        /// هل اليوم عطلة
        /// </summary>
        public bool IsHoliday { get; private set; }

        /// <summary>
        /// Gets the holiday reason
        /// سبب العطلة
        /// </summary>
        public string? HolidayReason { get; private set; }

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

        private PeriodDay() { } // For EF Core

        #endregion

        #region Factory Methods

        public static PeriodDay Create(
            short periodNumber,
            short dayNumber,
            DateTime dayDate,
            short yearNumber,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var periodDay = new PeriodDay
            {
                Id = Guid.NewGuid(),
                PeriodNumber = periodNumber,
                DayNumber = dayNumber,
                DayDate = dayDate,
                YearNumber = yearNumber,
                IsInactive = false,
                IsHoliday = false,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            periodDay.ValidateState();
            periodDay.AddDomainEvent(new PeriodDayCreatedEvent(periodDay));
            return periodDay;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Deactivates the period day
        /// تعطيل يوم الفترة
        /// </summary>
        public void Deactivate(int userId, string terminal)
        {
            if (IsInactive)
                throw new DomainException("Period day is already inactive");

            var oldState = IsInactive;
            IsInactive = true;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodDayDeactivatedEvent(this, oldState));
        }

        /// <summary>
        /// Activates the period day
        /// تنشيط يوم الفترة
        /// </summary>
        public void Activate(int userId, string terminal)
        {
            if (!IsInactive)
                throw new DomainException("Period day is already active");

            var oldState = IsInactive;
            IsInactive = false;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodDayActivatedEvent(this, oldState));
        }

        /// <summary>
        /// Sets the day as a holiday
        /// تعيين اليوم كعطلة
        /// </summary>
        public void SetHoliday(string reason, int userId, string terminal)
        {
            if (IsHoliday)
                throw new DomainException("Period day is already marked as holiday");

            if (string.IsNullOrWhiteSpace(reason))
                throw new DomainException("Holiday reason is required");

            var oldState = (IsHoliday, HolidayReason);
            IsHoliday = true;
            HolidayReason = reason;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodDayHolidaySetEvent(this, oldState.IsHoliday, oldState.HolidayReason));
        }

        /// <summary>
        /// Unsets the day as a holiday
        /// إلغاء تعيين اليوم كعطلة
        /// </summary>
        public void UnsetHoliday(int userId, string terminal)
        {
            if (!IsHoliday)
                throw new DomainException("Period day is not marked as holiday");

            var oldState = (IsHoliday, HolidayReason);
            IsHoliday = false;
            HolidayReason = null;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new PeriodDayHolidayUnsetEvent(this, oldState.IsHoliday, oldState.HolidayReason));
        }

        #endregion

        #region Private Methods

        private void ValidateState()
        {
            if (PeriodNumber <= 0)
                throw new DomainException("Period number must be greater than zero");

            if (DayNumber <= 0)
                throw new DomainException("Day number must be greater than zero");

            if (DayDate == default)
                throw new DomainException("Day date is required");

            if (YearNumber <= 0)
                throw new DomainException("Year number must be greater than zero");

            if (CompanyInfo == null)
                throw new DomainException("Company information is required");

            if (IsHoliday && string.IsNullOrWhiteSpace(HolidayReason))
                throw new DomainException("Holiday reason is required when day is marked as holiday");
        }

        #endregion
    }
} 