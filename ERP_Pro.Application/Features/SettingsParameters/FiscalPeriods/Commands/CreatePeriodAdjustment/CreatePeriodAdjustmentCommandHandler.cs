using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodAdjustment
{
    /// <summary>
    /// معالج أمر إنشاء تسوية للفترة المحاسبية
    /// </summary>
    public class CreatePeriodAdjustmentCommandHandler : IRequestHandler<CreatePeriodAdjustmentCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        /// <summary>
        /// المنشئ
        /// </summary>
        public CreatePeriodAdjustmentCommandHandler(
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
        public async Task<Guid> Handle(CreatePeriodAdjustmentCommand request, CancellationToken cancellationToken)
        {
            // جلب الفترة المحاسبية
            var fiscalPeriod = await _context.FiscalPeriods
                .Include(p => p.FiscalYear)
                .FirstOrDefaultAsync(p => p.Id == request.FiscalPeriodId, cancellationToken);

            if (fiscalPeriod == null)
            {
                throw new NotFoundException(nameof(FiscalPeriod), request.FiscalPeriodId);
            }

            // التحقق من أن السنة المالية ليست مغلقة نهائياً
            if (fiscalPeriod.FiscalYear.Status == FiscalYearStatusEnum.Closed)
            {
                throw new InvalidOperationException("لا يمكن إنشاء تسوية لفترة محاسبية تنتمي لسنة مالية مغلقة نهائياً");
            }

            // التحقق من أن الفترة المحاسبية ليست مغلقة نهائياً
            if (fiscalPeriod.Status == FiscalPeriodStatusEnum.Closed)
            {
                throw new ValidationException("لا يمكن إنشاء تسوية لفترة محاسبية مغلقة نهائياً");
            }

            // التحقق من أن تاريخ التسوية ضمن نطاق الفترة المحاسبية
            if (request.AdjustmentDate < fiscalPeriod.StartDate || request.AdjustmentDate > fiscalPeriod.EndDate)
            {
                throw new ValidationException("يجب أن يكون تاريخ التسوية ضمن نطاق الفترة المحاسبية");
            }

            // التحقق من أن نوع التسوية صالح
            if (request.AdjustmentType == AdjustmentTypeEnum.Unknown)
            {
                throw new ValidationException("يجب اختيار نوع صالح للتسوية");
            }

            // التحقق من وصف التسوية
            if (string.IsNullOrWhiteSpace(request.Description))
            {
                throw new ValidationException("وصف التسوية مطلوب");
            }

            // جلب المستخدم الحالي
            var currentUserName = _currentUserService.UserId ?? "System";

            // إنشاء تسوية جديدة
            var adjustment = new FiscalPeriodAdjustment(
                request.FiscalPeriodId,
                request.AdjustmentType,
                request.AdjustmentDate,
                request.Description,
                currentUserName,
                request.Notes);

            // إضافة معرف ورقم قيد التسوية إذا تم تحديدهما
            if (request.JournalEntryId.HasValue)
            {
                adjustment.SetJournalEntry(request.JournalEntryId.Value, request.JournalEntryNumber);
            }

            // إضافة التسوية إلى قاعدة البيانات
            _context.FiscalPeriodAdjustments.Add(adjustment);
            await _context.SaveChangesAsync(cancellationToken);

            return adjustment.Id;
        }
    }
} 