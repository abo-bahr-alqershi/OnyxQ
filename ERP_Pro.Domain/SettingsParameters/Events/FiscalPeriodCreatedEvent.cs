using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث إنشاء فترة محاسبية
    /// </summary>
    public class FiscalPeriodCreatedEvent : DomainEvent
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
        /// تاريخ البداية
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// تاريخ النهاية
        /// </summary>
        public DateTime EndDate { get; }

        /// <summary>
        /// حالة الفترة المحاسبية
        /// </summary>
        public FiscalPeriodStatusEnum Status { get; }

        /// <summary>
        /// توقيت الحدث
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalPeriodCreatedEvent(
            Guid fiscalPeriodId,
            Guid fiscalYearId,
            int periodNumber,
            string code,
            DateTime startDate,
            DateTime endDate,
            FiscalPeriodStatusEnum status)
        {
            FiscalPeriodId = fiscalPeriodId;
            FiscalYearId = fiscalYearId;
            PeriodNumber = periodNumber;
            Code = code;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            Timestamp = DateTime.UtcNow;
        }
    }
} 