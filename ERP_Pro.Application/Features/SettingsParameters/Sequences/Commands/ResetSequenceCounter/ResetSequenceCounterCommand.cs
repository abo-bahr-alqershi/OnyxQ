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

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.ResetSequenceCounter
{
    /// <summary>
    /// أمر إعادة ضبط عداد التسلسل
    /// </summary>
    public class ResetSequenceCounterCommand : IRequest<ResponseResult<bool>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// القيمة الجديدة للعداد
        /// </summary>
        public long NewCounterValue { get; set; } = 1;
        
        /// <summary>
        /// سبب إعادة الضبط
        /// </summary>
        public string Reason { get; set; }
    }
    
    /// <summary>
    /// معالج أمر إعادة ضبط عداد التسلسل
    /// </summary>
    public class ResetSequenceCounterCommandHandler : IRequestHandler<ResetSequenceCounterCommand, ResponseResult<bool>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ResetSequenceCounterCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;
        }
        
        /// <summary>
        /// تنفيذ الأمر
        /// </summary>
        public async Task<ResponseResult<bool>> Handle(ResetSequenceCounterCommand request, CancellationToken cancellationToken)
        {
            var sequence = await _context.SequenceDefinitions
                .FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);
                
            if (sequence == null)
            {
                return ResponseResult<bool>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود");
            }
            
            // التحقق من أن قيمة العداد الجديدة ضمن النطاق
            if (request.NewCounterValue < sequence.StartNumber || request.NewCounterValue > sequence.EndNumber)
            {
                return ResponseResult<bool>.Failure(
                    "InvalidCounterValue",
                    $"قيمة العداد الجديدة يجب أن تكون بين {sequence.StartNumber} و {sequence.EndNumber}");
            }
            
            // حفظ القيمة القديمة للتدقيق
            var oldValue = sequence.CurrentNumber;
            
            // تحديث قيمة العداد
            sequence.CurrentNumber = request.NewCounterValue;
            
            // تحديث بيانات التعديل
            sequence.LastModifiedBy = _currentUserService.UserId;
            sequence.LastModifiedAt = DateTime.UtcNow;
            
            // إضافة حدث إعادة ضبط عداد التسلسل
            sequence.AddDomainEvent(new SequenceCounterResetEvent(
                sequence.Id, sequence.Code, oldValue, sequence.CurrentNumber));
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            // إضافة سجل تدقيق لإعادة ضبط العداد
            var auditEntry = new SequenceAudit
            {
                SequenceId = sequence.Id,
                Type = SequenceAuditTypeEnum.CounterReset,
                Details = $"تم إعادة ضبط عداد التسلسل {sequence.NameAr} من {oldValue} إلى {sequence.CurrentNumber}" + 
                         (!string.IsNullOrEmpty(request.Reason) ? $"\nالسبب: {request.Reason}" : ""),
                UserId = _currentUserService.UserId,
                Timestamp = DateTime.UtcNow
            };
            
            _context.SequenceAudits.Add(auditEntry);
            await _context.SaveChangesAsync(cancellationToken);
            
            return ResponseResult<bool>.Success(true, 
                $"تم إعادة ضبط عداد التسلسل {sequence.NameAr} من {oldValue} إلى {sequence.CurrentNumber}");
        }
    }
    
    /// <summary>
    /// مدقق أمر إعادة ضبط عداد التسلسل
    /// </summary>
    public class ResetSequenceCounterCommandValidator : AbstractValidator<ResetSequenceCounterCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ResetSequenceCounterCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.Id)
                .NotEmpty().WithMessage("معرف التسلسل مطلوب");
                
            RuleFor(v => v.NewCounterValue)
                .GreaterThan(0).WithMessage("قيمة العداد الجديدة يجب أن تكون أكبر من صفر")
                .Must((model, value) => BeInRange(model.Id, value)).WithMessage("قيمة العداد الجديدة يجب أن تكون ضمن نطاق التسلسل");
                
            RuleFor(v => v.Reason)
                .MaximumLength(500).WithMessage("يجب ألا يتجاوز السبب 500 حرف");
        }
        
        private bool BeInRange(Guid id, long newValue)
        {
            var sequence = _context.SequenceDefinitions
                .FirstOrDefault(s => s.Id == id);
                
            if (sequence == null)
            {
                return false;
            }
            
            return newValue >= sequence.StartNumber && newValue <= sequence.EndNumber;
        }
    }
} 