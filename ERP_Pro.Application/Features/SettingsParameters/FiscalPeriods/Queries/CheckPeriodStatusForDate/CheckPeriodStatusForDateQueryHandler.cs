using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.CheckPeriodStatusForDate
{
    /// <summary>
    /// معالج استعلام للتحقق من حالة الفترة لتاريخ محدد
    /// </summary>
    public class CheckPeriodStatusForDateQueryHandler : IRequestHandler<CheckPeriodStatusForDateQuery, PeriodStatusDto>
    {
        private readonly IApplicationDbContext _context;

        /// <summary>
        /// المنشئ
        /// </summary>
        public CheckPeriodStatusForDateQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// معالجة الاستعلام
        /// </summary>
        public async Task<PeriodStatusDto> Handle(CheckPeriodStatusForDateQuery request, CancellationToken cancellationToken)
        {
            var query = _context.FiscalPeriods
                .Include(p => p.FiscalYear)
                .Include(p => p.PeriodLocks)
                .AsQueryable();

            // البحث في سنة مالية محددة إذا تم تحديدها
            if (request.FiscalYearId.HasValue)
            {
                query = query.Where(p => p.FiscalYearId == request.FiscalYearId.Value);
            }

            // البحث عن الفترة التي يقع فيها التاريخ المحدد
            var period = await query
                .Where(p => p.StartDate <= request.Date && p.EndDate >= request.Date)
                .OrderBy(p => p.FiscalYear.StartDate)
                .FirstOrDefaultAsync(cancellationToken);

            var result = new PeriodStatusDto
            {
                QueryDate = request.Date,
                PeriodExists = period != null,
                DateInPeriod = period != null,
                DateInFiscalYear = period != null // سيتم تحديثه لاحقاً إذا لم توجد فترة
            };

            if (period != null)
            {
                // تم العثور على فترة محاسبية للتاريخ المحدد
                result.FiscalPeriodId = period.Id;
                result.FiscalYearId = period.FiscalYearId;
                result.FiscalYearCode = period.FiscalYear.Code;
                result.PeriodNumber = period.PeriodNumber;
                result.PeriodCode = period.Code;
                result.PeriodName = period.NameAr; // يمكن تعديله لاستخدام اللغة الحالية
                result.Status = period.Status;
                result.StatusName = GetStatusName(period.Status);
                
                // التحقق مما إذا كانت الفترة مؤمنة
                var activeLock = period.PeriodLocks
                    .Where(l => l.LockEndDate == null || l.LockEndDate > DateTime.Now)
                    .OrderByDescending(l => l.LockStartDate)
                    .FirstOrDefault();

                result.IsLocked = activeLock != null;
                
                if (activeLock != null)
                {
                    result.LockType = activeLock.LockType;
                    result.LockTypeName = GetLockTypeName(activeLock.LockType);
                    result.LockReason = activeLock.Reason;
                }
            }
            else
            {
                // لم يتم العثور على فترة، التحقق مما إذا كان التاريخ ضمن سنة مالية
                var fiscalYear = await _context.FiscalYears
                    .Where(y => y.StartDate <= request.Date && y.EndDate >= request.Date)
                    .OrderBy(y => y.StartDate)
                    .FirstOrDefaultAsync(cancellationToken);

                if (fiscalYear != null)
                {
                    result.FiscalYearId = fiscalYear.Id;
                    result.FiscalYearCode = fiscalYear.Code;
                    result.DateInFiscalYear = true;
                    result.Status = FiscalPeriodStatusEnum.InPreparation; // قيمة افتراضية
                    result.StatusName = "غير موجودة";
                }
                else
                {
                    result.Status = FiscalPeriodStatusEnum.InPreparation; // قيمة افتراضية
                    result.StatusName = "خارج نطاق السنوات المالية";
                }
            }

            return result;
        }

        /// <summary>
        /// الحصول على اسم حالة الفترة المحاسبية
        /// </summary>
        private string GetStatusName(FiscalPeriodStatusEnum status)
        {
            return status switch
            {
                FiscalPeriodStatusEnum.InPreparation => "قيد الإعداد",
                FiscalPeriodStatusEnum.Open => "مفتوحة",
                FiscalPeriodStatusEnum.TemporarilyClosed => "مغلقة مؤقتاً",
                FiscalPeriodStatusEnum.Closed => "مغلقة نهائياً",
                FiscalPeriodStatusEnum.Locked => "مؤمنة",
                _ => "غير معروفة"
            };
        }

        /// <summary>
        /// الحصول على اسم نوع التأمين
        /// </summary>
        private string GetLockTypeName(LockTypeEnum lockType)
        {
            return lockType switch
            {
                LockTypeEnum.Normal => "تأمين عادي",
                LockTypeEnum.Temporary => "تأمين لفترة محددة",
                LockTypeEnum.Partial => "تأمين جزئي",
                LockTypeEnum.Full => "تأمين كامل",
                LockTypeEnum.Automatic => "تأمين تلقائي",
                LockTypeEnum.FinalClosing => "تأمين للإغلاق النهائي",
                _ => "غير معروف"
            };
        }
    }
} 