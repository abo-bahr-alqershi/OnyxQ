using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodsAutomatically
{
    /// <summary>
    /// معالج أمر إنشاء الفترات المحاسبية تلقائياً
    /// </summary>
    public class CreatePeriodsAutomaticallyCommandHandler : IRequestHandler<CreatePeriodsAutomaticallyCommand, Guid[]>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        /// <summary>
        /// المنشئ
        /// </summary>
        public CreatePeriodsAutomaticallyCommandHandler(
            IApplicationDbContext context,
            IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }

        /// <summary>
        /// معالجة الأمر
        /// </summary>
        public async Task<Guid[]> Handle(CreatePeriodsAutomaticallyCommand request, CancellationToken cancellationToken)
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
                throw new InvalidOperationException("لا يمكن إنشاء فترات محاسبية لسنة مالية مغلقة نهائياً");
            }

            // التحقق من عدم وجود فترات مسبقة (إذا كان هناك فترات موجودة، فلن نتمكن من إنشاء فترات جديدة)
            var existingPeriods = await _context.FiscalPeriods
                .Where(p => p.FiscalYearId == request.FiscalYearId)
                .ToListAsync(cancellationToken);

            if (existingPeriods.Any())
            {
                throw new ValidationException($"لا يمكن إنشاء فترات محاسبية جديدة تلقائياً لأن السنة المالية تحتوي بالفعل على {existingPeriods.Count} فترات محاسبية.");
            }

            // حساب عدد الفترات المحاسبية إذا لم يتم تحديدها
            int periodsCount = request.PeriodsCount ?? CalculatePeriodsCount(request.PeriodType);

            // إنشاء نماذج الفترات المحاسبية
            var periods = GeneratePeriods(fiscalYear, request.PeriodType, periodsCount, request.NameArPattern, request.NameEnPattern);

            // إضافة فترة الإقفال إذا تم طلبها
            if (request.AddClosingPeriod)
            {
                var closingPeriod = CreateClosingPeriod(fiscalYear, periodsCount + 1, request.ClosingPeriodNameAr, request.ClosingPeriodNameEn);
                periods.Add(closingPeriod);
            }

            // إضافة الفترات إلى قاعدة البيانات
            _context.FiscalPeriods.AddRange(periods);
            await _context.SaveChangesAsync(cancellationToken);

            // إرجاع معرفات الفترات المنشأة
            return periods.Select(p => p.Id).ToArray();
        }

        /// <summary>
        /// حساب عدد الفترات المحاسبية بناءً على نوع الفترة
        /// </summary>
        private int CalculatePeriodsCount(FiscalPeriodTypeEnum periodType)
        {
            return periodType switch
            {
                FiscalPeriodTypeEnum.Monthly => 12,
                FiscalPeriodTypeEnum.Quarterly => 4,
                FiscalPeriodTypeEnum.HalfYearly => 2,
                FiscalPeriodTypeEnum.Yearly => 1,
                _ => 12 // الافتراضي شهري
            };
        }

        /// <summary>
        /// إنشاء الفترات المحاسبية
        /// </summary>
        private List<FiscalPeriod> GeneratePeriods(
            FiscalYear fiscalYear,
            FiscalPeriodTypeEnum periodType,
            int periodsCount,
            string nameArPattern,
            string nameEnPattern)
        {
            var periods = new List<FiscalPeriod>();
            
            // تحديد أنماط التسمية الافتراضية إذا لم يتم تحديدها
            nameArPattern = string.IsNullOrEmpty(nameArPattern) ? GetDefaultNameArPattern(periodType) : nameArPattern;
            nameEnPattern = string.IsNullOrEmpty(nameEnPattern) ? GetDefaultNameEnPattern(periodType) : nameEnPattern;

            var startDate = fiscalYear.StartDate;
            var yearDuration = (fiscalYear.EndDate - fiscalYear.StartDate).TotalDays + 1;
            var periodDuration = yearDuration / periodsCount;
            
            for (int i = 0; i < periodsCount; i++)
            {
                // حساب تاريخ بداية ونهاية الفترة
                var periodStartDate = startDate.AddDays(i * periodDuration);
                var periodEndDate = i < periodsCount - 1 
                    ? startDate.AddDays((i + 1) * periodDuration).AddDays(-1) 
                    : fiscalYear.EndDate;

                // إنشاء رمز الفترة
                var periodCode = $"{fiscalYear.Code}-{i + 1:D2}";

                // إنشاء اسم الفترة
                var nameAr = string.Format(nameArPattern, i + 1, fiscalYear.NameAr);
                var nameEn = string.Format(nameEnPattern, i + 1, fiscalYear.NameEn);

                // إنشاء الفترة
                var period = new FiscalPeriod(
                    fiscalYear.Id,
                    i + 1,
                    periodCode,
                    nameAr,
                    nameEn,
                    periodStartDate,
                    periodEndDate,
                    periodType);

                periods.Add(period);
            }

            return periods;
        }

        /// <summary>
        /// إنشاء فترة الإقفال
        /// </summary>
        private FiscalPeriod CreateClosingPeriod(
            FiscalYear fiscalYear,
            int periodNumber,
            string closingPeriodNameAr,
            string closingPeriodNameEn)
        {
            // استخدام أسماء افتراضية إذا لم يتم تحديدها
            closingPeriodNameAr = string.IsNullOrEmpty(closingPeriodNameAr) ? $"فترة الإقفال {fiscalYear.NameAr}" : closingPeriodNameAr;
            closingPeriodNameEn = string.IsNullOrEmpty(closingPeriodNameEn) ? $"Closing Period {fiscalYear.NameEn}" : closingPeriodNameEn;

            // رمز فترة الإقفال
            var closingPeriodCode = $"{fiscalYear.Code}-C";

            // إنشاء فترة الإقفال (تستخدم نفس فترة نهاية السنة المالية)
            var period = new FiscalPeriod(
                fiscalYear.Id,
                periodNumber,
                closingPeriodCode,
                closingPeriodNameAr,
                closingPeriodNameEn,
                fiscalYear.EndDate,
                fiscalYear.EndDate,
                FiscalPeriodTypeEnum.ClosingPeriod,
                "فترة مخصصة لإجراءات الإقفال");

            // تعيين هذه الفترة كفترة افتراضية للإقفال
            period.ChangeStatus(FiscalPeriodStatusEnum.InPreparation);

            return period;
        }

        /// <summary>
        /// الحصول على نمط تسمية الفترات العربية الافتراضي
        /// </summary>
        private string GetDefaultNameArPattern(FiscalPeriodTypeEnum periodType)
        {
            return periodType switch
            {
                FiscalPeriodTypeEnum.Monthly => "الشهر {0} {1}",
                FiscalPeriodTypeEnum.Quarterly => "الربع {0} {1}",
                FiscalPeriodTypeEnum.HalfYearly => "النصف {0} {1}",
                FiscalPeriodTypeEnum.Yearly => "السنة {1}",
                _ => "الفترة {0} {1}"
            };
        }

        /// <summary>
        /// الحصول على نمط تسمية الفترات الإنجليزية الافتراضي
        /// </summary>
        private string GetDefaultNameEnPattern(FiscalPeriodTypeEnum periodType)
        {
            return periodType switch
            {
                FiscalPeriodTypeEnum.Monthly => "Month {0} {1}",
                FiscalPeriodTypeEnum.Quarterly => "Q{0} {1}",
                FiscalPeriodTypeEnum.HalfYearly => "H{0} {1}",
                FiscalPeriodTypeEnum.Yearly => "Year {1}",
                _ => "Period {0} {1}"
            };
        }
    }
}