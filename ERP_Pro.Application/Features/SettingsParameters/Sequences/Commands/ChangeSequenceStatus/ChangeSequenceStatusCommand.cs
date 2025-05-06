using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.ChangeSequenceStatus
{
    /// <summary>
    /// أمر تغيير حالة التسلسل
    /// </summary>
    public class ChangeSequenceStatusCommand : IRequest<ResponseResult<bool>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public SequenceStatusEnum NewStatus { get; set; }
        
        /// <summary>
        /// سبب تغيير الحالة
        /// </summary>
        public string Reason { get; set; }
    }
    
    /// <summary>
    /// معالج أمر تغيير حالة التسلسل
    /// </summary>
    public class ChangeSequenceStatusCommandHandler : IRequestHandler<ChangeSequenceStatusCommand, ResponseResult<bool>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ChangeSequenceStatusCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;
        }
        
        /// <summary>
        /// تنفيذ الأمر
        /// </summary>
        public async Task<ResponseResult<bool>> Handle(ChangeSequenceStatusCommand request, CancellationToken cancellationToken)
        {
            var sequence = await _context.SequenceDefinitions
                .FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);
                
            if (sequence == null)
            {
                return ResponseResult<bool>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود");
            }
            
            // لا داعي للتغيير إذا كانت الحالة هي نفسها
            if (sequence.Status == request.NewStatus)
            {
                return ResponseResult<bool>.Success(true, "الحالة لم تتغير لأنها نفس الحالة الحالية");
            }
            
            // حفظ الحالة القديمة للتدقيق
            var oldStatus = sequence.Status;
            
            // تحديث الحالة
            sequence.Status = request.NewStatus;
            
            // تحديث بيانات التعديل
            sequence.LastModifiedBy = _currentUserService.UserId;
            sequence.LastModifiedAt = DateTime.UtcNow;
            
            // إضافة حدث تغيير حالة التسلسل
            sequence.AddDomainEvent(new SequenceStatusChangedEvent(
                sequence.Id, sequence.Code, oldStatus, sequence.Status));
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            // إضافة سجل تدقيق لتغيير الحالة
            var auditEntry = new SequenceAudit
            {
                SequenceId = sequence.Id,
                Type = SequenceAuditTypeEnum.StatusChanged,
                Details = $"تم تغيير حالة التسلسل {sequence.NameAr} من {oldStatus} إلى {sequence.Status}" + 
                         (!string.IsNullOrEmpty(request.Reason) ? $"\nالسبب: {request.Reason}" : ""),
                UserId = _currentUserService.UserId,
                Timestamp = DateTime.UtcNow
            };
            
            _context.SequenceAudits.Add(auditEntry);
            await _context.SaveChangesAsync(cancellationToken);
            
            return ResponseResult<bool>.Success(true, 
                $"تم تغيير حالة التسلسل {sequence.NameAr} من {oldStatus} إلى {sequence.Status}");
        }
    }
    
    /// <summary>
    /// مدقق أمر تغيير حالة التسلسل
    /// </summary>
    public class ChangeSequenceStatusCommandValidator : AbstractValidator<ChangeSequenceStatusCommand>
    {
        /// <summary>
        /// المنشئ
        /// </summary>
        public ChangeSequenceStatusCommandValidator()
        {
            RuleFor(v => v.Id)
                .NotEmpty().WithMessage("معرف التسلسل مطلوب");
                
            RuleFor(v => v.NewStatus)
                .IsInEnum().WithMessage("الحالة الجديدة غير صالحة");
                
            RuleFor(v => v.Reason)
                .MaximumLength(500).WithMessage("يجب ألا يتجاوز السبب 500 حرف");
        }
    }
} 