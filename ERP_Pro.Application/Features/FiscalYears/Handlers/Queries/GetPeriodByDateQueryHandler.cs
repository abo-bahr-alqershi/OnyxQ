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
    /// معالج استعلام الحصول على فترة محاسبية بالتاريخ
    /// </summary>
    public class GetPeriodByDateQueryHandler : IRequestHandler<GetPeriodByDateQuery, FiscalPeriodDto>
    {
        private readonly IFiscalPeriodRepository _fiscalPeriodRepository;

        public GetPeriodByDateQueryHandler(IFiscalPeriodRepository fiscalPeriodRepository)
        {
            _fiscalPeriodRepository = fiscalPeriodRepository;
        }

        public async Task<FiscalPeriodDto> Handle(GetPeriodByDateQuery request, CancellationToken cancellationToken)
        {
            FiscalYearId fiscalYearId = null;
            if (request.FiscalYearId.HasValue)
            {
                fiscalYearId = FiscalYearId.Create(request.FiscalYearId.Value);
            }

            var fiscalPeriod = await _fiscalPeriodRepository.GetByDateAsync(
                request.Date, 
                fiscalYearId);

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