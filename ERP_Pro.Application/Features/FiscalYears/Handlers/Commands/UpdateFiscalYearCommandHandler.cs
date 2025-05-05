using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.FiscalYears.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Handlers.Commands
{
    /// <summary>
    /// معالج أمر تحديث سنة مالية
    /// </summary>
    public class UpdateFiscalYearCommandHandler : IRequestHandler<UpdateFiscalYearCommand, bool>
    {
        private readonly IFiscalYearRepository _fiscalYearRepository;
        private readonly ICurrentUserService _currentUserService;

        public UpdateFiscalYearCommandHandler(
            IFiscalYearRepository fiscalYearRepository,
            ICurrentUserService currentUserService)
        {
            _fiscalYearRepository = fiscalYearRepository;
            _currentUserService = currentUserService;
        }

        public async Task<bool> Handle(UpdateFiscalYearCommand request, CancellationToken cancellationToken)
        {
            // الحصول على السنة المالية
            var fiscalYearId = FiscalYearId.Create(request.Id);
            var fiscalYear = await _fiscalYearRepository.GetByIdAsync(fiscalYearId);
            if (fiscalYear == null)
            {
                throw new Exception("السنة المالية غير موجودة");
            }

            // التحقق من تداخل تواريخ السنة المالية مع سنوات أخرى
            var isDateOverlap = await _fiscalYearRepository.IsDateRangeOverlapAsync(
                request.StartDate, 
                request.EndDate, 
                fiscalYearId);

            if (isDateOverlap)
            {
                throw new Exception("تواريخ السنة المالية تتداخل مع سنة مالية أخرى");
            }

            // التحقق من منطقية التواريخ
            if (request.EndDate <= request.StartDate)
            {
                throw new Exception("تاريخ النهاية يجب أن يكون بعد تاريخ البداية");
            }

            // تحديث بيانات السنة المالية
            fiscalYear.Update(
                request.NameAr,
                request.NameEn,
                request.StartDate,
                request.EndDate,
                request.CalendarType,
                request.PeriodNumberingPattern,
                request.RetainedEarningsAccountId,
                request.IncomeStatementAccountId,
                request.Notes,
                _currentUserService.UserId);

            // حفظ التغييرات
            await _fiscalYearRepository.UpdateAsync(fiscalYear);
            var result = await _fiscalYearRepository.SaveChangesAsync();

            return result > 0;
        }
    }
} 