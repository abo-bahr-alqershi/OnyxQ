using System.Linq;
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
    /// معالج استعلام الحصول على سنة مالية بالرقم التعريفي
    /// </summary>
    public class GetFiscalYearByIdQueryHandler : IRequestHandler<GetFiscalYearByIdQuery, FiscalYearDto>
    {
        private readonly IFiscalYearRepository _fiscalYearRepository;

        public GetFiscalYearByIdQueryHandler(IFiscalYearRepository fiscalYearRepository)
        {
            _fiscalYearRepository = fiscalYearRepository;
        }

        public async Task<FiscalYearDto> Handle(GetFiscalYearByIdQuery request, CancellationToken cancellationToken)
        {
            var fiscalYear = await _fiscalYearRepository.GetByIdAsync(
                FiscalYearId.Create(request.Id),
                request.IncludePeriods);

            if (fiscalYear == null)
            {
                return null;
            }

            var fiscalYearDto = new FiscalYearDto
            {
                Id = fiscalYear.Id.Value,
                Code = fiscalYear.Code,
                NameAr = fiscalYear.NameAr,
                NameEn = fiscalYear.NameEn,
                StartDate = fiscalYear.StartDate,
                EndDate = fiscalYear.EndDate,
                Duration = fiscalYear.Duration,
                CalendarType = fiscalYear.CalendarType,
                Status = fiscalYear.Status,
                IsDefault = fiscalYear.IsDefault,
                PeriodNumberingPattern = fiscalYear.PeriodNumberingPattern,
                RetainedEarningsAccountId = fiscalYear.RetainedEarningsAccountId,
                IncomeStatementAccountId = fiscalYear.IncomeStatementAccountId,
                Notes = fiscalYear.Notes,
                CreatedBy = fiscalYear.CreatedBy,
                CreationDate = fiscalYear.CreationDate,
                UpdatedBy = fiscalYear.UpdatedBy,
                UpdateDate = fiscalYear.UpdateDate,
                CarryOverSettings = fiscalYear.CarryOverSettings,
                LockSettings = fiscalYear.LockSettings
            };

            if (request.IncludePeriods && fiscalYear.FiscalPeriods.Any())
            {
                fiscalYearDto.PeriodsCount = fiscalYear.FiscalPeriods.Count;
                foreach (var period in fiscalYear.FiscalPeriods.OrderBy(p => p.PeriodNumber))
                {
                    fiscalYearDto.FiscalPeriods.Add(new FiscalPeriodDto
                    {
                        Id = period.Id.Value,
                        FiscalYearId = period.FiscalYearId.Value,
                        PeriodNumber = period.PeriodNumber,
                        Code = period.Code,
                        NameAr = period.NameAr,
                        NameEn = period.NameEn,
                        StartDate = period.StartDate,
                        EndDate = period.EndDate,
                        PeriodType = period.PeriodType,
                        Status = period.Status,
                        IsClosingDefault = period.IsClosingDefault,
                        CalendarReference = period.CalendarReference,
                        LastClosingDate = period.LastClosingDate,
                        LastReopenDate = period.LastReopenDate,
                        Notes = period.Notes,
                        CreatedBy = period.CreatedBy,
                        CreationDate = period.CreationDate,
                        UpdatedBy = period.UpdatedBy,
                        UpdateDate = period.UpdateDate
                    });
                }
            }
            else
            {
                fiscalYearDto.PeriodsCount = await _fiscalYearRepository
                    .GetCountAsync(null, null, null);
            }

            return fiscalYearDto;
        }
    }
} 