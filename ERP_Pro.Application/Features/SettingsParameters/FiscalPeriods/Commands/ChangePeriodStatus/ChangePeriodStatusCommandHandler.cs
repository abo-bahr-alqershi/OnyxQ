using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.ChangePeriodStatus
{
    /// <summary>
    /// معالج أمر تغيير حالة فترة محاسبية
    /// </summary>
    public class ChangePeriodStatusCommandHandler : IRequestHandler<ChangePeriodStatusCommand, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        /// <summary>
        /// المنشئ
        /// </summary>
        public ChangePeriodStatusCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
        {
            _context = context;
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        /// <summary>
        /// معالجة الأمر
        /// </summary>
        public async Task<bool> Handle(ChangePeriodStatusCommand request, CancellationToken cancellationToken)
        {
            // جلب الفترة المحاسبية
            var fiscalPeriod = await _context.FiscalPeriods
                .Include(p => p.FiscalYear)
                .Include(p => p.PeriodLocks)
                .FirstOrDefaultAsync(p => p.Id == request.FiscalPeriodId, cancellationToken);

            if (fiscalPeriod == null)
            {
                throw new NotFoundException(nameof(FiscalPeriod), request.FiscalPeriodId);
            }

            // التحقق من أن السنة المالية ليست مغلقة نهائياً
            if (fiscalPeriod.FiscalYear.Status == FiscalYearStatusEnum.Closed)
            {
                throw new InvalidOperationException("لا يمكن تغيير حالة فترة محاسبية تنتمي لسنة مالية مغلقة نهائياً");
            }

            // التحقق من أن الحالة الجديدة مختلفة عن الحالة الحالية
            if (fiscalPeriod.Status == request.NewStatus)
            {
                throw new ValidationException($"الفترة المحاسبية بالفعل في حالة {GetStatusName(request.NewStatus)}");
            }

            // التحقق من صحة الانتقال بين الحالات
            ValidateStatusTransition(fiscalPeriod.Status, request.NewStatus);

            // في حالة الانتقال إلى حالة الإغلاق النهائي، يجب التحقق من بعض الشروط
            if (request.NewStatus == FiscalPeriodStatusEnum.Closed)
            {
                // التحقق من عدم وجود قيود محاسبية مفتوحة في الفترة
                // TODO: إضافة فحص القيود المحاسبية المفتوحة عند تطوير وحدة القيود المحاسبية

                // التحقق من عدم وجود فترات سابقة مفتوحة
                var previousPeriods = await _context.FiscalPeriods
                    .Where(p => p.FiscalYearId == fiscalPeriod.FiscalYearId && p.PeriodNumber < fiscalPeriod.PeriodNumber)
                    .Where(p => p.Status == FiscalPeriodStatusEnum.Open || p.Status == FiscalPeriodStatusEnum.InPreparation)
                    .ToListAsync(cancellationToken);

                if (previousPeriods.Any())
                {
                    throw new ValidationException("لا يمكن إغلاق الفترة المحاسبية نهائياً بينما لا تزال الفترات السابقة مفتوحة");
                }
            }

            // تغيير حالة الفترة المحاسبية
            fiscalPeriod.ChangeStatus(request.NewStatus);

            // في حالة الإغلاق النهائي، نقوم بإنشاء تأمين نهائي للفترة
            if (request.NewStatus == FiscalPeriodStatusEnum.Closed)
            {
                var currentUserName = _currentUserService.UserId ?? "System";
                var lockStartDate = _dateTime.Now;

                var periodLock = new FiscalPeriodLock(
                    fiscalPeriod.Id,
                    lockStartDate,
                    LockTypeEnum.FinalClosing,
                    request.Reason ?? "إغلاق نهائي للفترة المحاسبية",
                    currentUserName,
                    request.Notes);

                _context.FiscalPeriodLocks.Add(periodLock);
            }

            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }

        /// <summary>
        /// التحقق من صحة الانتقال بين حالات الفترة المحاسبية
        /// </summary>
        private void ValidateStatusTransition(FiscalPeriodStatusEnum currentStatus, FiscalPeriodStatusEnum newStatus)
        {
            var isValidTransition = (currentStatus, newStatus) switch
            {
                // من قيد الإعداد
                (FiscalPeriodStatusEnum.InPreparation, FiscalPeriodStatusEnum.Open) => true,
                (FiscalPeriodStatusEnum.InPreparation, FiscalPeriodStatusEnum.TemporarilyClosed) => true,
                
                // من مفتوحة
                (FiscalPeriodStatusEnum.Open, FiscalPeriodStatusEnum.TemporarilyClosed) => true,
                (FiscalPeriodStatusEnum.Open, FiscalPeriodStatusEnum.Closed) => true,
                (FiscalPeriodStatusEnum.Open, FiscalPeriodStatusEnum.Locked) => true,
                
                // من مغلقة مؤقتاً
                (FiscalPeriodStatusEnum.TemporarilyClosed, FiscalPeriodStatusEnum.Open) => true,
                (FiscalPeriodStatusEnum.TemporarilyClosed, FiscalPeriodStatusEnum.Closed) => true,
                
                // من مؤمنة
                (FiscalPeriodStatusEnum.Locked, FiscalPeriodStatusEnum.Open) => true,
                (FiscalPeriodStatusEnum.Locked, FiscalPeriodStatusEnum.TemporarilyClosed) => true,
                
                // لا يمكن الانتقال من حالة الإغلاق النهائي إلى أي حالة أخرى
                (FiscalPeriodStatusEnum.Closed, _) => false,
                
                // أي انتقال آخر غير مسموح به
                _ => false
            };

            if (!isValidTransition)
            {
                throw new ValidationException($"لا يمكن تغيير حالة الفترة المحاسبية من {GetStatusName(currentStatus)} إلى {GetStatusName(newStatus)}");
            }
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
    }
} 