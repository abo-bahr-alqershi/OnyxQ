using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.LockPeriod
{
    /// <summary>
    /// معالج أمر تأمين الفترة المحاسبية
    /// </summary>
    public class LockPeriodCommandHandler : IRequestHandler<LockPeriodCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        /// <summary>
        /// المنشئ
        /// </summary>
        public LockPeriodCommandHandler(
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
        public async Task<Guid> Handle(LockPeriodCommand request, CancellationToken cancellationToken)
        {
            // جلب الفترة المحاسبية
            var fiscalPeriod = await _context.FiscalPeriods
                .Include(p => p.PeriodLocks)
                .Include(p => p.FiscalYear)
                .FirstOrDefaultAsync(p => p.Id == request.FiscalPeriodId, cancellationToken);

            if (fiscalPeriod == null)
            {
                throw new NotFoundException(nameof(FiscalPeriod), request.FiscalPeriodId);
            }

            // التحقق من أن الفترة ليست مغلقة نهائياً
            if (fiscalPeriod.Status == FiscalPeriodStatusEnum.Closed)
            {
                throw new InvalidOperationException("لا يمكن تأمين فترة محاسبية مغلقة نهائياً");
            }

            // التحقق من أن السنة المالية ليست مغلقة نهائياً
            if (fiscalPeriod.FiscalYear.Status == FiscalYearStatusEnum.Closed)
            {
                throw new InvalidOperationException("لا يمكن تأمين فترة محاسبية تنتمي لسنة مالية مغلقة نهائياً");
            }

            // التحقق من وجود تأمين نشط للفترة
            var activeLock = fiscalPeriod.PeriodLocks
                .FirstOrDefault(l => l.LockEndDate == null || l.LockEndDate > _dateTime.Now);

            if (activeLock != null)
            {
                throw new ValidationException($"الفترة المحاسبية مؤمنة بالفعل برمز {activeLock.Id} من نوع {GetLockTypeName(activeLock.LockType)}.");
            }

            // إنشاء تأمين جديد للفترة
            var lockStartDate = _dateTime.Now;
            var performedBy = _currentUserService.UserId ?? "System";

            var periodLock = new FiscalPeriodLock(
                fiscalPeriod.Id,
                lockStartDate,
                request.LockType,
                request.Reason,
                performedBy,
                request.Notes);

            // تعيين تاريخ نهاية التأمين إذا تم تحديده (للتأمين المؤقت)
            if (request.LockEndDate.HasValue && request.LockType == LockTypeEnum.Temporary)
            {
                // نتأكد أن تاريخ نهاية التأمين بعد تاريخ بدايته
                if (request.LockEndDate.Value <= lockStartDate)
                {
                    throw new ValidationException("يجب أن يكون تاريخ نهاية التأمين بعد تاريخ بدايته");
                }

                periodLock = new FiscalPeriodLock(
                    fiscalPeriod.Id,
                    lockStartDate,
                    request.LockType,
                    request.Reason,
                    performedBy,
                    request.Notes);

                // سنتعامل مع تاريخ نهاية التأمين لاحقاً، لأن الكيان لا يسمح بتعيينه عند الإنشاء
            }

            // إضافة التأمين إلى قاعدة البيانات
            _context.FiscalPeriodLocks.Add(periodLock);

            // تغيير حالة الفترة إلى مؤمنة إذا كان التأمين من نوع تأمين كامل أو نهائي
            if (request.LockType == LockTypeEnum.Full || request.LockType == LockTypeEnum.FinalClosing)
            {
                fiscalPeriod.ChangeStatus(FiscalPeriodStatusEnum.Locked);
            }

            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);

            return periodLock.Id;
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