using System.Collections.Generic;
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
    /// معالج استعلام قائمة الفترات المحاسبية
    /// </summary>
    public class ListFiscalPeriodsQueryHandler : IRequestHandler<ListFiscalPeriodsQuery, List<FiscalPeriodDto>>
    {
        private readonly IFiscalPeriodRepository _fiscalPeriodRepository;

        public ListFiscalPeriodsQueryHandler(IFiscalPeriodRepository fiscalPeriodRepository)
        {
            _fiscalPeriodRepository = fiscalPeriodRepository;
        }

        public async Task<List<FiscalPeriodDto>> Handle(ListFiscalPeriodsQuery request, CancellationToken cancellationToken)
        {
            var fiscalYearId = FiscalYearId.Create(request.FiscalYearId);
            var fiscalPeriods = await _fiscalPeriodRepository.GetAllAsync(
                fiscalYearId,
                request.Status,
                request.PeriodType,
                request.OrderBy,
                request.OrderDirection);

            // تحويل النتائج إلى DTOs
            var fiscalPeriodDtos = new List<FiscalPeriodDto>();
            foreach (var fiscalPeriod in fiscalPeriods)
            {
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

                fiscalPeriodDtos.Add(fiscalPeriodDto);
            }

            return fiscalPeriodDtos;
        }
    }
} 