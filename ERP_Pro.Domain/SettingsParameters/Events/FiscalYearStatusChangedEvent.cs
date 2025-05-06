using System;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث تغيير حالة سنة مالية
    /// </summary>
    public class FiscalYearStatusChangedEvent : IDomainEvent
    {
        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; }

        /// <summary>
        /// معرف الشركة
        /// </summary>
        public Guid CompanyInfoId { get; }

        /// <summary>
        /// الحالة السابقة
        /// </summary>
        public FiscalYearStatusEnum PreviousStatus { get; }

        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public FiscalYearStatusEnum NewStatus { get; }

        /// <summary>
        /// توقيت الحدث
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalYearStatusChangedEvent(
            Guid fiscalYearId,
            Guid companyInfoId,
            FiscalYearStatusEnum previousStatus,
            FiscalYearStatusEnum newStatus)
        {
            FiscalYearId = fiscalYearId;
            CompanyInfoId = companyInfoId;
            PreviousStatus = previousStatus;
            NewStatus = newStatus;
            Timestamp = DateTime.UtcNow;
        }
    }
} 