using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.GetCurrentFiscalPeriod
{
    /// <summary>
    /// معالج استعلام جلب الفترة المحاسبية الحالية
    /// </summary>
    public class GetCurrentFiscalPeriodQueryHandler : IRequestHandler<GetCurrentFiscalPeriodQuery, FiscalPeriodDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;

        /// <summary>
        /// المنشئ
        /// </summary>
        public GetCurrentFiscalPeriodQueryHandler(
            IApplicationDbContext context,
            IMapper mapper,
            IDateTime dateTime)
        {
            _context = context;
            _mapper = mapper;
            _dateTime = dateTime;
        }

        /// <summary>
        /// معالجة الاستعلام
        /// </summary>
        public async Task<FiscalPeriodDto> Handle(GetCurrentFiscalPeriodQuery request, CancellationToken cancellationToken)
        {
            // الحصول على التاريخ الحالي
            var currentDate = _dateTime.Now;

            var query = _context.FiscalPeriods
                .Include(p => p.FiscalYear)
                .Include(p => p.PeriodLocks)
                .Include(p => p.PeriodAdjustments)
                .Where(p => p.StartDate <= currentDate && p.EndDate >= currentDate)
                .AsQueryable();

            // البحث في سنة مالية محددة إذا تم تحديدها
            if (request.FiscalYearId.HasValue)
            {
                query = query.Where(p => p.FiscalYearId == request.FiscalYearId.Value);
            }
            else
            {
                // البحث في السنة المالية الافتراضية أولاً، ثم في السنوات النشطة
                query = query.OrderByDescending(p => p.FiscalYear.IsDefault)
                    .ThenByDescending(p => p.FiscalYear.Status == Domain.SettingsParameters.Enums.FiscalYearStatusEnum.Active)
                    .ThenBy(p => p.StartDate);
            }

            var fiscalPeriod = await query.FirstOrDefaultAsync(cancellationToken);

            if (fiscalPeriod == null)
            {
                // إذا لم تكن هناك فترة حالية، نجلب أقرب فترة (أقرب نهاية)
                var nextPeriodQuery = _context.FiscalPeriods
                    .Include(p => p.FiscalYear)
                    .Include(p => p.PeriodLocks)
                    .Include(p => p.PeriodAdjustments)
                    .Where(p => p.StartDate > currentDate);

                if (request.FiscalYearId.HasValue)
                {
                    nextPeriodQuery = nextPeriodQuery.Where(p => p.FiscalYearId == request.FiscalYearId.Value);
                }
                else
                {
                    nextPeriodQuery = nextPeriodQuery.OrderByDescending(p => p.FiscalYear.IsDefault)
                        .ThenByDescending(p => p.FiscalYear.Status == Domain.SettingsParameters.Enums.FiscalYearStatusEnum.Active);
                }

                fiscalPeriod = await nextPeriodQuery.OrderBy(p => p.StartDate).FirstOrDefaultAsync(cancellationToken);

                // إذا لم تكن هناك فترة قادمة، نجلب آخر فترة (أقرب سابقة)
                if (fiscalPeriod == null)
                {
                    var previousPeriodQuery = _context.FiscalPeriods
                        .Include(p => p.FiscalYear)
                        .Include(p => p.PeriodLocks)
                        .Include(p => p.PeriodAdjustments)
                        .Where(p => p.EndDate < currentDate);

                    if (request.FiscalYearId.HasValue)
                    {
                        previousPeriodQuery = previousPeriodQuery.Where(p => p.FiscalYearId == request.FiscalYearId.Value);
                    }
                    else
                    {
                        previousPeriodQuery = previousPeriodQuery.OrderByDescending(p => p.FiscalYear.IsDefault)
                            .ThenByDescending(p => p.FiscalYear.Status == Domain.SettingsParameters.Enums.FiscalYearStatusEnum.Active);
                    }

                    fiscalPeriod = await previousPeriodQuery.OrderByDescending(p => p.EndDate).FirstOrDefaultAsync(cancellationToken);
                }
            }

            if (fiscalPeriod == null)
            {
                throw new NotFoundException("لا توجد فترة محاسبية حالية أو قريبة.");
            }

            var result = _mapper.Map<FiscalPeriodDto>(fiscalPeriod);
            
            // إضافة معلومات إضافية
            result.FiscalYearCode = fiscalPeriod.FiscalYear.Code;
            result.FiscalYearName = fiscalPeriod.FiscalYear.NameAr; // يمكن تعديله لاستخدام اللغة الحالية
            
            // حساب عدد عمليات التأمين والتسويات
            result.LocksCount = fiscalPeriod.PeriodLocks.Count;
            result.AdjustmentsCount = fiscalPeriod.PeriodAdjustments.Count;

            return result;
        }
    }
} 