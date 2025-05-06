using System;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث إنشاء سنة مالية
    /// </summary>
    public class FiscalYearCreatedEvent : IDomainEvent
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
        /// رمز السنة المالية
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
        /// حالة السنة المالية
        /// </summary>
        public FiscalYearStatusEnum Status { get; }

        /// <summary>
        /// توقيت الحدث
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalYearCreatedEvent(
            Guid fiscalYearId,
            Guid companyInfoId,
            string code,
            DateTime startDate,
            DateTime endDate,
            FiscalYearStatusEnum status)
        {
            FiscalYearId = fiscalYearId;
            CompanyInfoId = companyInfoId;
            Code = code;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            Timestamp = DateTime.UtcNow;
        }
    }
} 