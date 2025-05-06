using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodManually
{
    /// <summary>
    /// معالج أمر إنشاء فترة محاسبية يدوياً
    /// </summary>
    public class CreatePeriodManuallyCommandHandler : IRequestHandler<CreatePeriodManuallyCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        /// <summary>
        /// المنشئ
        /// </summary>
        public CreatePeriodManuallyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// معالجة الأمر
        /// </summary>
        public async Task<Guid> Handle(CreatePeriodManuallyCommand request, CancellationToken cancellationToken)
        {
            // جلب السنة المالية
            var fiscalYear = await _context.FiscalYears
                .FirstOrDefaultAsync(fy => fy.Id == request.FiscalYearId, cancellationToken);

            if (fiscalYear == null)
            {
                throw new NotFoundException(nameof(FiscalYear), request.FiscalYearId);
            }

            // التحقق من أن السنة المالية ليست مغلقة نهائياً
            if (fiscalYear.Status == FiscalYearStatusEnum.Closed)
            {
                throw new InvalidOperationException("لا يمكن إنشاء فترة محاسبية لسنة مالية مغلقة نهائياً");
            }

            // التحقق من عدم وجود فترة أخرى بنفس الرقم التسلسلي
            var existingPeriodWithSameNumber = await _context.FiscalPeriods
                .AnyAsync(p => p.FiscalYearId == request.FiscalYearId && p.PeriodNumber == request.PeriodNumber, cancellationToken);

            if (existingPeriodWithSameNumber)
            {
                throw new ValidationException($"توجد فترة محاسبية أخرى بنفس الرقم التسلسلي {request.PeriodNumber} في هذه السنة المالية.");
            }

            // التحقق من عدم وجود فترة أخرى بنفس الرمز
            var existingPeriodWithSameCode = await _context.FiscalPeriods
                .AnyAsync(p => p.FiscalYearId == request.FiscalYearId && p.Code == request.Code, cancellationToken);

            if (existingPeriodWithSameCode)
            {
                throw new ValidationException($"توجد فترة محاسبية أخرى بنفس الرمز {request.Code} في هذه السنة المالية.");
            }

            // التحقق من أن تاريخ البداية لا يتجاوز تاريخ النهاية
            if (request.StartDate > request.EndDate)
            {
                throw new ValidationException("يجب أن يكون تاريخ بداية الفترة أقل من أو يساوي تاريخ نهايتها.");
            }

            // التحقق من أن التواريخ ضمن نطاق السنة المالية
            if (request.StartDate < fiscalYear.StartDate || request.EndDate > fiscalYear.EndDate)
            {
                throw new ValidationException("يجب أن تكون تواريخ الفترة المحاسبية ضمن نطاق السنة المالية.");
            }

            // التحقق من عدم تداخل الفترة مع فترات أخرى
            var overlappingPeriod = await _context.FiscalPeriods
                .Where(p => p.FiscalYearId == request.FiscalYearId)
                .Where(p => 
                    (request.StartDate >= p.StartDate && request.StartDate <= p.EndDate) || // بداية الفترة الجديدة تتداخل مع فترة موجودة
                    (request.EndDate >= p.StartDate && request.EndDate <= p.EndDate) || // نهاية الفترة الجديدة تتداخل مع فترة موجودة
                    (request.StartDate <= p.StartDate && request.EndDate >= p.EndDate)) // الفترة الجديدة تحتوي فترة موجودة
                .FirstOrDefaultAsync(cancellationToken);

            if (overlappingPeriod != null)
            {
                throw new ValidationException($"الفترة المحاسبية المطلوب إنشاؤها تتداخل مع فترة محاسبية موجودة (رقم الفترة: {overlappingPeriod.PeriodNumber}).");
            }

            // إنشاء الفترة المحاسبية
            var period = new FiscalPeriod(
                request.FiscalYearId,
                request.PeriodNumber,
                request.Code,
                request.NameAr,
                request.NameEn,
                request.StartDate,
                request.EndDate,
                request.PeriodType,
                request.Notes);

            // تعيين خاصية الفترة الافتراضية للإقفال إذا تم طلبها
            if (request.IsClosingDefault)
            {
                // إذا كانت هناك فترة أخرى معينة كفترة إقفال افتراضية، نلغي تعيينها
                var existingDefaultClosingPeriod = await _context.FiscalPeriods
                    .Where(p => p.FiscalYearId == request.FiscalYearId && p.IsClosingDefault)
                    .FirstOrDefaultAsync(cancellationToken);

                if (existingDefaultClosingPeriod != null)
                {
                    existingDefaultClosingPeriod.SetIsClosingDefault(false);
                }

                // تعيين الفترة الجديدة كفترة إقفال افتراضية
                period.SetIsClosingDefault(true);
            }

            // إضافة الفترة إلى قاعدة البيانات
            _context.FiscalPeriods.Add(period);
            await _context.SaveChangesAsync(cancellationToken);

            return period.Id;
        }
    }
} 