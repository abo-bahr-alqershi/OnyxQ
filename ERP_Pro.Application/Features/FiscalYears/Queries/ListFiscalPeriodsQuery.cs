using System;
using System.Collections.Generic;
using ERP_Pro.Application.Features.FiscalYears.Dtos;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Queries
{
    /// <summary>
    /// استعلام لعرض قائمة الفترات المحاسبية
    /// </summary>
    public class ListFiscalPeriodsQuery : IRequest<List<FiscalPeriodDto>>
    {
        /// <summary>
        /// رقم السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; set; }

        /// <summary>
        /// حالة الفترة
        /// </summary>
        public FiscalPeriodStatusEnum? Status { get; set; }

        /// <summary>
        /// نوع الفترة
        /// </summary>
        public FiscalPeriodTypeEnum? PeriodType { get; set; }

        /// <summary>
        /// ترتيب النتائج حسب
        /// </summary>
        public string OrderBy { get; set; } = "PeriodNumber";

        /// <summary>
        /// اتجاه الترتيب
        /// </summary>
        public string OrderDirection { get; set; } = "ASC";
    }
} 