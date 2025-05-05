using ERP_Pro.Application.Features.FiscalYears.Dtos;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Queries
{
    /// <summary>
    /// استعلام للحصول على سنة مالية بالرمز
    /// </summary>
    public class GetFiscalYearByCodeQuery : IRequest<FiscalYearDto>
    {
        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// تضمين الفترات المحاسبية
        /// </summary>
        public bool IncludePeriods { get; set; }
    }
} 