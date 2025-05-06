using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.CancelNumber
{
    /// <summary>
    /// أمر إلغاء رقم تسلسلي
    /// </summary>
    public class CancelNumberCommand : IRequest<ResponseResult<bool>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid SequenceId { get; set; }
        
        /// <summary>
        /// الرقم المراد إلغاؤه
        /// </summary>
        public string Number { get; set; }
        
        /// <summary>
        /// سبب الإلغاء
        /// </summary>
        public string Reason { get; set; }
        
        /// <summary>
        /// السماح بإعادة استخدام الرقم
        /// </summary>
        public bool AllowReuse { get; set; }
    }
    
    /// <summary>
    /// معالج أمر إلغاء رقم تسلسلي
    /// </summary>
    public class CancelNumberCommandHandler : IRequestHandler<CancelNumberCommand, ResponseResult<bool>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTimeService _dateTimeService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public CancelNumberCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IDateTimeService dateTimeService)
        {
            _context = context;
            _currentUserService = currentUserService;
            _dateTimeService = dateTimeService;
        }
        
        /// <summary>
        /// تنفيذ الأمر
        /// </summary>
        public async Task<ResponseResult<bool>> Handle(CancelNumberCommand request, CancellationToken cancellationToken)
        {
            var sequence = await _context.SequenceDefinitions
                .FirstOrDefaultAsync(s => s.Id == request.SequenceId, cancellationToken);
                
            if (sequence == null)
            {
                return ResponseResult<bool>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود");
            }
            
            // البحث عن الرقم المستخدم
            var usedNumber = await _context.UsedNumbers
                .FirstOrDefaultAsync(n => n.SequenceId == request.SequenceId && 
                                      n.FormattedNumber == request.Number, cancellationToken);
                
            if (usedNumber == null)
            {
                return ResponseResult<bool>.Failure(
                    "NumberNotFound",
                    $"الرقم {request.Number} غير مستخدم في هذا التسلسل");
            }
            
            // التحقق من أن الرقم لم يتم إلغاؤه بالفعل
            var existingCancellation = await _context.CanceledNumbers
                .FirstOrDefaultAsync(n => n.SequenceId == request.SequenceId && 
                                      n.FormattedNumber == request.Number, cancellationToken);
                
            if (existingCancellation != null)
            {
                return ResponseResult<bool>.Failure(
                    "NumberAlreadyCanceled",
                    $"الرقم {request.Number} تم إلغاؤه بالفعل");
            }
            
            // إنشاء رقم ملغى جديد
            var canceledNumber = new CanceledNumber
            {
                Id = Guid.NewGuid(),
                SequenceId = sequence.Id,
                NumericValue = usedNumber.NumericValue,
                FormattedNumber = usedNumber.FormattedNumber,
                CancelDate = _dateTimeService.Now,
                Reason = request.Reason,
                AllowReuse = request.AllowReuse,
                ReuseDate = request.AllowReuse ? 
                    _dateTimeService.Now.AddDays(sequence.DaysBeforeReuseOfCanceledNumbers) : null,
                Status = request.AllowReuse ? 
                    CanceledNumberStatusEnum.PendingReuse : CanceledNumberStatusEnum.Permanent,
                UserId = _currentUserService.UserId,
                CreatedAt = _dateTimeService.Now,
                CreatedBy = _currentUserService.UserId
            };
            
            // إضافة سجل الرقم الملغى
            _context.CanceledNumbers.Add(canceledNumber);
            
            // إضافة سجل تدقيق
            var auditEntry = new SequenceAudit
            {
                SequenceId = sequence.Id,
                Type = SequenceAuditTypeEnum.NumberCanceled,
                Details = $"تم إلغاء الرقم {request.Number}" + 
                        (!string.IsNullOrEmpty(request.Reason) ? $"\nالسبب: {request.Reason}" : "") +
                        $"\nالسماح بإعادة الاستخدام: {(request.AllowReuse ? "نعم" : "لا")}",
                UserId = _currentUserService.UserId,
                Timestamp = _dateTimeService.Now
            };
            
            _context.SequenceAudits.Add(auditEntry);
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            return ResponseResult<bool>.Success(true,
                $"تم إلغاء الرقم {request.Number} بنجاح");
        }
    }
    
    /// <summary>
    /// مدقق أمر إلغاء رقم تسلسلي
    /// </summary>
    public class CancelNumberCommandValidator : AbstractValidator<CancelNumberCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public CancelNumberCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.SequenceId)
                .NotEmpty().WithMessage("معرف التسلسل مطلوب");
                
            RuleFor(v => v.Number)
                .NotEmpty().WithMessage("الرقم المراد إلغاؤه مطلوب");
                
            RuleFor(v => v)
                .Must(model => NumberExists(model.SequenceId, model.Number))
                .WithMessage("الرقم غير مستخدم في هذا التسلسل")
                .Must(model => !NumberAlreadyCanceled(model.SequenceId, model.Number))
                .WithMessage("الرقم تم إلغاؤه بالفعل");
                
            RuleFor(v => v.Reason)
                .NotEmpty().WithMessage("سبب الإلغاء مطلوب")
                .MaximumLength(500).WithMessage("يجب ألا يتجاوز سبب الإلغاء 500 حرف");
        }
        
        private bool NumberExists(Guid sequenceId, string number)
        {
            return _context.UsedNumbers
                .Any(n => n.SequenceId == sequenceId && n.FormattedNumber == number);
        }
        
        private bool NumberAlreadyCanceled(Guid sequenceId, string number)
        {
            return _context.CanceledNumbers
                .Any(n => n.SequenceId == sequenceId && n.FormattedNumber == number);
        }
    }
} 