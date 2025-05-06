using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث تغيير حالة الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodStatusChangedEvent : DomainEvent
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
        /// رقم الفترة التسلسلي
        /// </summary>
        public int PeriodNumber { get; }

        /// <summary>
        /// رمز الفترة
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// الحالة السابقة
        /// </summary>
        public FiscalPeriodStatusEnum OldStatus { get; }

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
            int periodNumber,
            string code,
            FiscalPeriodStatusEnum oldStatus,
            FiscalPeriodStatusEnum newStatus)
        {
            FiscalPeriodId = fiscalPeriodId;
            FiscalYearId = fiscalYearId;
            PeriodNumber = periodNumber;
            Code = code;
            OldStatus = oldStatus;
            NewStatus = newStatus;
            Timestamp = DateTime.UtcNow;
        }
    }
} 