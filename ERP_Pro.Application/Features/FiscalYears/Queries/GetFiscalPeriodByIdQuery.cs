using System;
using ERP_Pro.Application.Features.FiscalYears.Dtos;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Queries
{
    /// <summary>
    /// استعلام للحصول على فترة محاسبية بالرقم التعريفي
    /// </summary>
    public class GetFiscalPeriodByIdQuery : IRequest<FiscalPeriodDto>
    {
        /// <summary>
        /// رقم التعريف
        /// </summary>
        public Guid Id { get; set; }
    }
} 