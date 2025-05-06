using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Domain.SettingsParameters.Events;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.DeleteSequence
{
    /// <summary>
    /// أمر حذف تسلسل
    /// </summary>
    public class DeleteSequenceCommand : IRequest<ResponseResult<bool>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// سبب الحذف
        /// </summary>
        public string Reason { get; set; }
    }
    
    /// <summary>
    /// معالج أمر حذف تسلسل
    /// </summary>
    public class DeleteSequenceCommandHandler : IRequestHandler<DeleteSequenceCommand, ResponseResult<bool>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public DeleteSequenceCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;
        }
        
        /// <summary>
        /// تنفيذ الأمر
        /// </summary>
        public async Task<ResponseResult<bool>> Handle(DeleteSequenceCommand request, CancellationToken cancellationToken)
        {
            var sequence = await _context.SequenceDefinitions
                .Include(s => s.UsedNumbers)
                .Include(s => s.CanceledNumbers)
                .Include(s => s.NumberAllocations)
                .Include(s => s.NumberGaps)
                .Include(s => s.SequenceAudits)
                .FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);
                
            if (sequence == null)
            {
                return ResponseResult<bool>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود");
            }
            
            // التحقق مما إذا كان التسلسل مستخدمًا (له أرقام مستخدمة)
            if (sequence.UsedNumbers.Any())
            {
                return ResponseResult<bool>.Failure(
                    "SequenceInUse",
                    "لا يمكن حذف التسلسل لأنه مستخدم بالفعل. يمكنك تعطيله بدلاً من حذفه.");
            }
            
            // إضافة حدث حذف التسلسل
            var eventData = new SequenceDeletedEvent(sequence.Id, sequence.Code, sequence.NameAr);
            
            // حذف السجلات المرتبطة أولاً
            if (sequence.CanceledNumbers.Any())
            {
                _context.CanceledNumbers.RemoveRange(sequence.CanceledNumbers);
            }
            
            if (sequence.NumberAllocations.Any())
            {
                _context.NumberAllocations.RemoveRange(sequence.NumberAllocations);
            }
            
            if (sequence.NumberGaps.Any())
            {
                _context.NumberGaps.RemoveRange(sequence.NumberGaps);
            }
            
            if (sequence.SequenceAudits.Any())
            {
                _context.SequenceAudits.RemoveRange(sequence.SequenceAudits);
            }
            
            // حذف التسلسل
            _context.SequenceDefinitions.Remove(sequence);
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            // نشر حدث الحذف
            await _context.PublishDomainEventAsync(eventData, cancellationToken);
            
            return ResponseResult<bool>.Success(true, 
                $"تم حذف التسلسل {sequence.NameAr} بنجاح");
        }
    }
    
    /// <summary>
    /// مدقق أمر حذف تسلسل
    /// </summary>
    public class DeleteSequenceCommandValidator : AbstractValidator<DeleteSequenceCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public DeleteSequenceCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.Id)
                .NotEmpty().WithMessage("معرف التسلسل مطلوب")
                .Must(CanBeDeleted).WithMessage("لا يمكن حذف التسلسل لأنه مستخدم بالفعل");
                
            RuleFor(v => v.Reason)
                .MaximumLength(500).WithMessage("يجب ألا يتجاوز سبب الحذف 500 حرف");
        }
        
        private bool CanBeDeleted(Guid id)
        {
            var sequence = _context.SequenceDefinitions
                .Include(s => s.UsedNumbers)
                .FirstOrDefault(s => s.Id == id);
                
            return sequence != null && !sequence.UsedNumbers.Any();
        }
    }
} 