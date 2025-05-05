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
    /// معالج أمر إنشاء فترة محاسبية جديدة
    /// </summary>
    public class CreateFiscalPeriodCommandHandler : IRequestHandler<CreateFiscalPeriodCommand, Guid>
    {
        private readonly IFiscalYearRepository _fiscalYearRepository;
        private readonly IFiscalPeriodRepository _fiscalPeriodRepository;
        private readonly ICurrentUserService _currentUserService;

        public CreateFiscalPeriodCommandHandler(
            IFiscalYearRepository fiscalYearRepository,
            IFiscalPeriodRepository fiscalPeriodRepository,
            ICurrentUserService currentUserService)
        {
            _fiscalYearRepository = fiscalYearRepository;
            _fiscalPeriodRepository = fiscalPeriodRepository;
            _currentUserService = currentUserService;
        }

        public async Task<Guid> Handle(CreateFiscalPeriodCommand request, CancellationToken cancellationToken)
        {
            // الحصول على السنة المالية
            var fiscalYearId = FiscalYearId.Create(request.FiscalYearId);
            var fiscalYear = await _fiscalYearRepository.GetByIdAsync(fiscalYearId);
            if (fiscalYear == null)
            {
                throw new Exception($"السنة المالية غير موجودة");
            }

            // التحقق من حالة السنة المالية
            if (fiscalYear.Status != ERP_Pro.Shared.Enums.Domain.FiscalYearStatusEnum.InPreparation &&
                fiscalYear.Status != ERP_Pro.Shared.Enums.Domain.FiscalYearStatusEnum.Open)
            {
                throw new Exception("لا يمكن إضافة فترات محاسبية لسنة مالية مغلقة");
            }

            // التحقق من فريد رمز الفترة المحاسبية
            var isCodeExists = await _fiscalPeriodRepository.IsCodeExistsAsync(request.Code);
            if (isCodeExists)
            {
                throw new Exception($"رمز الفترة المحاسبية '{request.Code}' موجود بالفعل");
            }

            // التحقق من تداخل تواريخ الفترة المحاسبية مع فترات أخرى في نفس السنة المالية
            var isDateOverlap = await _fiscalPeriodRepository.IsDateRangeOverlapAsync(
                fiscalYearId,
                request.StartDate,
                request.EndDate);

            if (isDateOverlap)
            {
                throw new Exception("تواريخ الفترة المحاسبية تتداخل مع فترة أخرى");
            }

            // التحقق من أن الفترة تقع ضمن نطاق السنة المالية
            if (request.StartDate < fiscalYear.StartDate || request.EndDate > fiscalYear.EndDate)
            {
                throw new Exception("يجب أن تقع الفترة المحاسبية ضمن نطاق السنة المالية");
            }

            // التحقق من منطقية التواريخ
            if (request.EndDate <= request.StartDate)
            {
                throw new Exception("تاريخ النهاية يجب أن يكون بعد تاريخ البداية");
            }

            // إنشاء كيان الفترة المحاسبية
            var fiscalPeriodId = FiscalPeriodId.CreateNew();
            var fiscalPeriod = new FiscalPeriod(
                fiscalPeriodId,
                fiscalYearId,
                request.PeriodNumber,
                request.Code,
                request.NameAr,
                request.NameEn,
                request.StartDate,
                request.EndDate,
                request.PeriodType);

            // تحديث البيانات الإضافية
            fiscalPeriod.Update(
                request.NameAr,
                request.NameEn,
                request.StartDate,
                request.EndDate,
                request.PeriodType,
                request.CalendarReference,
                request.Notes,
                _currentUserService.UserId);

            // إضافة الفترة المحاسبية للسنة المالية
            fiscalYear.AddFiscalPeriod(fiscalPeriod);

            // حفظ التغييرات
            await _fiscalYearRepository.UpdateAsync(fiscalYear);
            await _fiscalYearRepository.SaveChangesAsync();

            return fiscalPeriodId.Value;
        }
    }
} 