using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث تغيير حالة السنة المالية
    /// </summary>
    public class FiscalYearStatusChangedEvent : DomainEvent
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
        /// الحالة السابقة
        /// </summary>
        public FiscalYearStatusEnum OldStatus { get; }

        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public FiscalYearStatusEnum NewStatus { get; }

        /// <summary>
        /// سبب تغيير الحالة
        /// </summary>
        public string Reason { get; }

        /// <summary>
        /// توقيت الحدث
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalYearStatusChangedEvent(
            Guid fiscalYearId,
            string code,
            string name,
            FiscalYearStatusEnum oldStatus,
            FiscalYearStatusEnum newStatus,
            string reason)
        {
            FiscalYearId = fiscalYearId;
            Code = code;
            Name = name;
            OldStatus = oldStatus;
            NewStatus = newStatus;
            Reason = reason;
            Timestamp = DateTime.UtcNow;
        }
    }
} 