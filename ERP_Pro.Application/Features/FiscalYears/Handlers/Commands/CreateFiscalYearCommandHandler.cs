using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.FiscalYears.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Handlers.Commands
{
    /// <summary>
    /// معالج أمر إنشاء سنة مالية جديدة
    /// </summary>
    public class CreateFiscalYearCommandHandler : IRequestHandler<CreateFiscalYearCommand, Guid>
    {
        private readonly IFiscalYearRepository _fiscalYearRepository;
        private readonly ICurrentUserService _currentUserService;

        public CreateFiscalYearCommandHandler(
            IFiscalYearRepository fiscalYearRepository,
            ICurrentUserService currentUserService)
        {
            _fiscalYearRepository = fiscalYearRepository;
            _currentUserService = currentUserService;
        }

        public async Task<Guid> Handle(CreateFiscalYearCommand request, CancellationToken cancellationToken)
        {
            // التحقق من فريد رمز السنة المالية
            var isCodeExists = await _fiscalYearRepository.IsCodeExistsAsync(request.Code);
            if (isCodeExists)
            {
                throw new Exception($"رمز السنة المالية '{request.Code}' موجود بالفعل");
            }

            // التحقق من تداخل تواريخ السنة المالية مع سنوات أخرى
            var isDateOverlap = await _fiscalYearRepository.IsDateRangeOverlapAsync(request.StartDate, request.EndDate);
            if (isDateOverlap)
            {
                throw new Exception("تواريخ السنة المالية تتداخل مع سنة مالية أخرى");
            }

            // التحقق من منطقية التواريخ
            if (request.EndDate <= request.StartDate)
            {
                throw new Exception("تاريخ النهاية يجب أن يكون بعد تاريخ البداية");
            }

            // إنشاء كيان السنة المالية
            var fiscalYearId = FiscalYearId.CreateNew();
            var fiscalYear = new FiscalYear(
                fiscalYearId,
                request.Code,
                request.NameAr,
                request.NameEn,
                request.StartDate,
                request.EndDate,
                request.CalendarType);

            // إضافة الإعدادات الإضافية
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

            // تعيين كافتراضي إذا كانت السنة المالية الوحيدة أو طلب المستخدم ذلك
            var isDefault = request.IsDefault;
            if (isDefault)
            {
                var isDefaultExists = await _fiscalYearRepository.IsDefaultExistsAsync();
                if (isDefaultExists)
                {
                    // إذا كانت هناك سنة مالية افتراضية، سيتم تحديثها لاحقاً
                }
                fiscalYear.SetAsDefault(_currentUserService.UserId);
            }
            else
            {
                // إذا لم تكن هناك سنة مالية افتراضية أخرى، نجعل هذه السنة افتراضية
                var isDefaultExists = await _fiscalYearRepository.IsDefaultExistsAsync();
                if (!isDefaultExists)
                {
                    fiscalYear.SetAsDefault(_currentUserService.UserId);
                }
            }

            // حفظ السنة المالية
            await _fiscalYearRepository.AddAsync(fiscalYear);
            await _fiscalYearRepository.SaveChangesAsync();

            return fiscalYearId.Value;
        }
    }
} 