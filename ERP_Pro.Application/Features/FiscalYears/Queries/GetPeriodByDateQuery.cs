using System;
using ERP_Pro.Application.Features.FiscalYears.Dtos;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Queries
{
    /// <summary>
    /// استعلام للحصول على فترة محاسبية بالتاريخ
    /// </summary>
    public class GetPeriodByDateQuery : IRequest<FiscalPeriodDto>
    {
        /// <summary>
        /// التاريخ
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// رقم السنة المالية (اختياري)
        /// </summary>
        public Guid? FiscalYearId { get; set; }
    }
} 