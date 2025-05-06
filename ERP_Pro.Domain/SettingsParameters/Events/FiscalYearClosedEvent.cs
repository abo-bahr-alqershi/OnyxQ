using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث إغلاق السنة المالية
    /// </summary>
    public class FiscalYearClosedEvent : DomainEvent
    {
        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; }

        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// اسم السنة المالية
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// تاريخ البداية
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// تاريخ النهاية
        /// </summary>
        public DateTime EndDate { get; }

        /// <summary>
        /// تاريخ الإغلاق
        /// </summary>
        public DateTime ClosingDate { get; }

        /// <summary>
        /// معرف المستخدم الذي قام بالإغلاق
        /// </summary>
        public string ClosedByUserId { get; }

        /// <summary>
        /// توقيت الحدث
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalYearClosedEvent(
            Guid fiscalYearId,
            string code,
            string name,
            DateTime startDate,
            DateTime endDate,
            DateTime closingDate,
            string closedByUserId)
        {
            FiscalYearId = fiscalYearId;
            Code = code;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            ClosingDate = closingDate;
            ClosedByUserId = closedByUserId;
            Timestamp = DateTime.UtcNow;
        }
    }
} 