using ERP_Pro.Application.Features.FiscalYears.Dtos;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Queries
{
    /// <summary>
    /// استعلام للحصول على السنة المالية الافتراضية
    /// </summary>
    public class GetDefaultFiscalYearQuery : IRequest<FiscalYearDto>
    {
        /// <summary>
        /// تضمين الفترات المحاسبية
        /// </summary>
        public bool IncludePeriods { get; set; }
    }
} 