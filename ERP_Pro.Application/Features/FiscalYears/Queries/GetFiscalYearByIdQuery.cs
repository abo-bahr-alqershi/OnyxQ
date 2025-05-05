using System;
using ERP_Pro.Application.Features.FiscalYears.Dtos;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Queries
{
    /// <summary>
    /// استعلام للحصول على سنة مالية بالرقم التعريفي
    /// </summary>
    public class GetFiscalYearByIdQuery : IRequest<FiscalYearDto>
    {
        /// <summary>
        /// رقم التعريف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// تضمين الفترات المحاسبية
        /// </summary>
        public bool IncludePeriods { get; set; }
    }
} 