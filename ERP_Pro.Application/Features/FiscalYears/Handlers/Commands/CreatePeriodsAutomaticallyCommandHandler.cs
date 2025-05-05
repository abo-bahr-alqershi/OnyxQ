using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.FiscalYears.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Handlers.Commands
{
    /// <summary>
    /// معالج أمر إنشاء فترات محاسبية تلقائياً
    /// </summary>
    public class CreatePeriodsAutomaticallyCommandHandler : IRequestHandler<CreatePeriodsAutomaticallyCommand, bool>
    {
        private readonly IFiscalYearRepository _fiscalYearRepository;
        private readonly ICurrentUserService _currentUserService;

        public CreatePeriodsAutomaticallyCommandHandler(
            IFiscalYearRepository fiscalYearRepository,
            ICurrentUserService currentUserService)
        {
            _fiscalYearRepository = fiscalYearRepository;
            _currentUserService = currentUserService;
        }

        public async Task<bool> Handle(CreatePeriodsAutomaticallyCommand request, CancellationToken cancellationToken)
        {
            // الحصول على السنة المالية
            var fiscalYearId = FiscalYearId.Create(request.FiscalYearId);
            var fiscalYear = await _fiscalYearRepository.GetByIdAsync(fiscalYearId, true);
            if (fiscalYear == null)
            {
                throw new Exception("السنة المالية غير موجودة");
            }

            // التحقق من حالة السنة المالية
            if (fiscalYear.Status != FiscalYearStatusEnum.InPreparation && 
                fiscalYear.Status != FiscalYearStatusEnum.Open)
            {
                throw new Exception("لا يمكن إضافة فترات محاسبية لسنة مالية مغلقة");
            }

            // التحقق من المدخلات
            if (request.PeriodsCount <= 0)
            {
                throw new Exception("عدد الفترات يجب أن يكون أكبر من صفر");
            }

            // إنشاء الفترات المحاسبية تلقائياً
            var startDate = fiscalYear.StartDate;
            var endDate = fiscalYear.EndDate;
            var totalDays = (endDate - startDate).Days + 1;
            var periodDays = totalDays / request.PeriodsCount;

            // تحديد أطوال الفترات بناءً على نمط الفترات
            DateTime[] periodStartDates = new DateTime[request.PeriodsCount];
            DateTime[] periodEndDates = new DateTime[request.PeriodsCount];

            switch (request.PeriodPattern)
            {
                case FiscalPeriodTypeEnum.Monthly:
                    // تقسيم الفترات بالشهور
                    for (int i = 0; i < request.PeriodsCount; i++)
                    {
                        if (i == 0)
                        {
                            periodStartDates[i] = startDate;
                        }
                        else
                        {
                            periodStartDates[i] = periodEndDates[i - 1].AddDays(1);
                        }

                        if (i == request.PeriodsCount - 1)
                        {
                            // الفترة الأخيرة تنتهي بنهاية السنة المالية
                            periodEndDates[i] = endDate;
                        }
                        else
                        {
                            // إضافة شهر واحد لتاريخ البداية ثم طرح يوم واحد
                            periodEndDates[i] = periodStartDates[i].AddMonths(1).AddDays(-1);
                        }
                    }
                    break;

                case FiscalPeriodTypeEnum.Quarterly:
                    // تقسيم الفترات بالربع سنوي (3 أشهر)
                    for (int i = 0; i < request.PeriodsCount; i++)
                    {
                        if (i == 0)
                        {
                            periodStartDates[i] = startDate;
                        }
                        else
                        {
                            periodStartDates[i] = periodEndDates[i - 1].AddDays(1);
                        }

                        if (i == request.PeriodsCount - 1)
                        {
                            // الفترة الأخيرة تنتهي بنهاية السنة المالية
                            periodEndDates[i] = endDate;
                        }
                        else
                        {
                            // إضافة 3 أشهر لتاريخ البداية ثم طرح يوم واحد
                            periodEndDates[i] = periodStartDates[i].AddMonths(3).AddDays(-1);
                        }
                    }
                    break;

                case FiscalPeriodTypeEnum.SemiAnnually:
                    // تقسيم الفترات بالنصف سنوي (6 أشهر)
                    for (int i = 0; i < request.PeriodsCount; i++)
                    {
                        if (i == 0)
                        {
                            periodStartDates[i] = startDate;
                        }
                        else
                        {
                            periodStartDates[i] = periodEndDates[i - 1].AddDays(1);
                        }

                        if (i == request.PeriodsCount - 1)
                        {
                            // الفترة الأخيرة تنتهي بنهاية السنة المالية
                            periodEndDates[i] = endDate;
                        }
                        else
                        {
                            // إضافة 6 أشهر لتاريخ البداية ثم طرح يوم واحد
                            periodEndDates[i] = periodStartDates[i].AddMonths(6).AddDays(-1);
                        }
                    }
                    break;

                default:
                    // تقسيم متساوي لعدد الأيام
                    for (int i = 0; i < request.PeriodsCount; i++)
                    {
                        if (i == 0)
                        {
                            periodStartDates[i] = startDate;
                        }
                        else
                        {
                            periodStartDates[i] = periodEndDates[i - 1].AddDays(1);
                        }

                        if (i == request.PeriodsCount - 1)
                        {
                            // الفترة الأخيرة تنتهي بنهاية السنة المالية
                            periodEndDates[i] = endDate;
                        }
                        else
                        {
                            // إضافة عدد أيام الفترة
                            periodEndDates[i] = periodStartDates[i].AddDays(periodDays - 1);
                        }
                    }
                    break;
            }

            // إنشاء الفترات المحاسبية
            for (int i = 0; i < request.PeriodsCount; i++)
            {
                string code = $"{request.CodePrefix}{i + 1:D2}";
                string nameAr = $"{request.NamePrefix} {i + 1}";
                string nameEn = $"{request.NamePrefixEn} {i + 1}";

                // إنشاء كيان الفترة المحاسبية
                var fiscalPeriodId = FiscalPeriodId.CreateNew();
                var fiscalPeriod = new FiscalPeriod(
                    fiscalPeriodId,
                    fiscalYearId,
                    i + 1,
                    code,
                    nameAr,
                    nameEn,
                    periodStartDates[i],
                    periodEndDates[i],
                    request.PeriodPattern);

                // إضافة الفترة المحاسبية للسنة المالية
                fiscalYear.AddFiscalPeriod(fiscalPeriod);
            }

            // إضافة فترة تسوية نهائية إذا كان نمط الفترة هو شهري أو ربع سنوي
            if (request.PeriodPattern == FiscalPeriodTypeEnum.Monthly || 
                request.PeriodPattern == FiscalPeriodTypeEnum.Quarterly)
            {
                string adjustmentCode = $"{request.CodePrefix}ADJ";
                string adjustmentNameAr = "فترة التسوية النهائية";
                string adjustmentNameEn = "Final Adjustment Period";

                // إنشاء كيان فترة التسوية
                var adjustmentPeriodId = FiscalPeriodId.CreateNew();
                var adjustmentPeriod = new FiscalPeriod(
                    adjustmentPeriodId,
                    fiscalYearId,
                    request.PeriodsCount + 1,
                    adjustmentCode,
                    adjustmentNameAr,
                    adjustmentNameEn,
                    endDate, // تاريخ البداية والنهاية هو نفس تاريخ نهاية السنة المالية
                    endDate,
                    FiscalPeriodTypeEnum.Adjustment);

                // إضافة فترة التسوية للسنة المالية
                fiscalYear.AddFiscalPeriod(adjustmentPeriod);
            }

            // حفظ التغييرات
            await _fiscalYearRepository.UpdateAsync(fiscalYear);
            await _fiscalYearRepository.SaveChangesAsync();

            return true;
        }
    }
} 