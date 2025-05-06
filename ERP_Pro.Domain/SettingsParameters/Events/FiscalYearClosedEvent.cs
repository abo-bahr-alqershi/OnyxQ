using System;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث إقفال سنة مالية
    /// </summary>
    public class FiscalYearClosedEvent : IDomainEvent
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
        /// معرف عملية الإقفال
        /// </summary>
        public Guid ClosingId { get; }

        /// <summary>
        /// نوع الإقفال
        /// </summary>
        public ClosingTypeEnum ClosingType { get; }

        /// <summary>
        /// توقيت الحدث
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalYearClosedEvent(
            Guid fiscalYearId,
            Guid companyInfoId,
            Guid closingId,
            ClosingTypeEnum closingType)
        {
            FiscalYearId = fiscalYearId;
            CompanyInfoId = companyInfoId;
            ClosingId = closingId;
            ClosingType = closingType;
            Timestamp = DateTime.UtcNow;
        }
    }
} 