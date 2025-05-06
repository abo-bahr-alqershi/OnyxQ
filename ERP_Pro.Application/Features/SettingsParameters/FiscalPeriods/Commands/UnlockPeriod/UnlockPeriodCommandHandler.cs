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

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.UnlockPeriod
{
    /// <summary>
    /// معالج أمر إلغاء تأمين فترة محاسبية
    /// </summary>
    public class UnlockPeriodCommandHandler : IRequestHandler<UnlockPeriodCommand, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        /// <summary>
        /// المنشئ
        /// </summary>
        public UnlockPeriodCommandHandler(
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
        public async Task<bool> Handle(UnlockPeriodCommand request, CancellationToken cancellationToken)
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

            // التحقق من أن السنة المالية ليست مغلقة نهائياً
            if (fiscalPeriod.FiscalYear.Status == FiscalYearStatusEnum.Closed)
            {
                throw new InvalidOperationException("لا يمكن إلغاء تأمين فترة محاسبية تنتمي لسنة مالية مغلقة نهائياً");
            }

            // البحث عن التأمين المطلوب إلغاؤه
            FiscalPeriodLock lockToUnlock;

            if (request.LockId.HasValue)
            {
                // إذا تم تحديد معرف التأمين، نبحث عنه بالمعرف
                lockToUnlock = fiscalPeriod.PeriodLocks.FirstOrDefault(l => l.Id == request.LockId.Value);
                if (lockToUnlock == null)
                {
                    throw new NotFoundException(nameof(FiscalPeriodLock), request.LockId.Value);
                }
            }
            else
            {
                // إذا لم يتم تحديد معرف التأمين، نبحث عن آخر تأمين نشط
                lockToUnlock = fiscalPeriod.PeriodLocks
                    .Where(l => l.LockEndDate == null || l.LockEndDate > _dateTime.Now)
                    .OrderByDescending(l => l.LockStartDate)
                    .FirstOrDefault();
                
                if (lockToUnlock == null)
                {
                    throw new ValidationException("لا يوجد تأمين نشط للفترة المحاسبية");
                }
            }

            // التحقق من أن التأمين ليس من نوع الإقفال النهائي
            if (lockToUnlock.LockType == LockTypeEnum.FinalClosing)
            {
                throw new ValidationException("لا يمكن إلغاء تأمين من نوع الإغلاق النهائي");
            }

            // تحديث حالة التأمين
            var currentUserName = _currentUserService.UserId ?? "System";
            lockToUnlock.Unlock(currentUserName, request.Reason, _dateTime.Now, request.Notes);

            // إذا كان التأمين من نوع كامل، نعيد حالة الفترة إلى الحالة السابقة
            if (lockToUnlock.LockType == LockTypeEnum.Full)
            {
                // نستعيد الحالة السابقة (مفتوحة أو مغلقة مؤقتاً) بناءً على حالة الفترة المحاسبية
                if (fiscalPeriod.Status == FiscalPeriodStatusEnum.Locked)
                {
                    fiscalPeriod.ChangeStatus(FiscalPeriodStatusEnum.Open);
                }
            }

            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
} 