using System;
using ERP_Pro.Application.Features.FiscalYears.Dtos;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Queries
{
    /// <summary>
    /// استعلام للحصول على الفترة المحاسبية الحالية
    /// </summary>
    public class GetCurrentFiscalPeriodQuery : IRequest<FiscalPeriodDto>
    {
        /// <summary>
        /// رقم السنة المالية (اختياري)
        /// </summary>
        public Guid? FiscalYearId { get; set; }
    }
} 