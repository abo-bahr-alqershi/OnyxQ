using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.FiscalYears.Dtos;
using ERP_Pro.Application.Features.FiscalYears.Queries;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Handlers.Queries
{
    /// <summary>
    /// معالج استعلام الحصول على الفترة المحاسبية الحالية
    /// </summary>
    public class GetCurrentFiscalPeriodQueryHandler : IRequestHandler<GetCurrentFiscalPeriodQuery, FiscalPeriodDto>
    {
        private readonly IFiscalPeriodRepository _fiscalPeriodRepository;

        public GetCurrentFiscalPeriodQueryHandler(IFiscalPeriodRepository fiscalPeriodRepository)
        {
            _fiscalPeriodRepository = fiscalPeriodRepository;
        }

        public async Task<FiscalPeriodDto> Handle(GetCurrentFiscalPeriodQuery request, CancellationToken cancellationToken)
        {
            FiscalYearId fiscalYearId = null;
            if (request.FiscalYearId.HasValue)
            {
                fiscalYearId = FiscalYearId.Create(request.FiscalYearId.Value);
            }

            var fiscalPeriod = await _fiscalPeriodRepository.GetCurrentPeriodAsync(fiscalYearId);

            if (fiscalPeriod == null)
            {
                return null;
            }

            var fiscalPeriodDto = new FiscalPeriodDto
            {
                Id = fiscalPeriod.Id.Value,
                FiscalYearId = fiscalPeriod.FiscalYearId.Value,
                PeriodNumber = fiscalPeriod.PeriodNumber,
                Code = fiscalPeriod.Code,
                NameAr = fiscalPeriod.NameAr,
                NameEn = fiscalPeriod.NameEn,
                StartDate = fiscalPeriod.StartDate,
                EndDate = fiscalPeriod.EndDate,
                PeriodType = fiscalPeriod.PeriodType,
                Status = fiscalPeriod.Status,
                IsClosingDefault = fiscalPeriod.IsClosingDefault,
                CalendarReference = fiscalPeriod.CalendarReference,
                LastClosingDate = fiscalPeriod.LastClosingDate,
                LastReopenDate = fiscalPeriod.LastReopenDate,
                Notes = fiscalPeriod.Notes,
                CreatedBy = fiscalPeriod.CreatedBy,
                CreationDate = fiscalPeriod.CreationDate,
                UpdatedBy = fiscalPeriod.UpdatedBy,
                UpdateDate = fiscalPeriod.UpdateDate
            };

            return fiscalPeriodDto;
        }
    }
} 