using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث تحديث السنة المالية
    /// </summary>
    public class FiscalYearUpdatedEvent : DomainEvent
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
        /// حالة السنة المالية
        /// </summary>
        public FiscalYearStatusEnum Status { get; }

        /// <summary>
        /// الحقول التي تم تحديثها
        /// </summary>
        public string[] UpdatedFields { get; }

        /// <summary>
        /// توقيت الحدث
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalYearUpdatedEvent(
            Guid fiscalYearId,
            string code,
            string name,
            DateTime startDate,
            DateTime endDate,
            FiscalYearStatusEnum status,
            string[] updatedFields)
        {
            FiscalYearId = fiscalYearId;
            Code = code;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            UpdatedFields = updatedFields;
            Timestamp = DateTime.UtcNow;
        }
    }
}
