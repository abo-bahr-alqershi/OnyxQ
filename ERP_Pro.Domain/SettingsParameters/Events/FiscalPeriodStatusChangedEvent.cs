using System;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث تغيير حالة فترة محاسبية
    /// </summary>
    public class FiscalPeriodStatusChangedEvent : IDomainEvent
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; }

        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; }

        /// <summary>
        /// الحالة السابقة
        /// </summary>
        public FiscalPeriodStatusEnum PreviousStatus { get; }

        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public FiscalPeriodStatusEnum NewStatus { get; }

        /// <summary>
        /// توقيت الحدث
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalPeriodStatusChangedEvent(
            Guid fiscalPeriodId,
            Guid fiscalYearId,
            FiscalPeriodStatusEnum previousStatus,
            FiscalPeriodStatusEnum newStatus)
        {
            FiscalPeriodId = fiscalPeriodId;
            FiscalYearId = fiscalYearId;
            PreviousStatus = previousStatus;
            NewStatus = newStatus;
            Timestamp = DateTime.UtcNow;
        }
    }
} 