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

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.ReserveNumberRange
{
    /// <summary>
    /// أمر حجز نطاق أرقام في تسلسل
    /// </summary>
    public class ReserveNumberRangeCommand : IRequest<ResponseResult<Guid>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid SequenceId { get; set; }
        
        /// <summary>
        /// بداية النطاق
        /// </summary>
        public long RangeStart { get; set; }
        
        /// <summary>
        /// نهاية النطاق
        /// </summary>
        public long RangeEnd { get; set; }
        
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid? BranchId { get; set; }
        
        /// <summary>
        /// سبب الحجز
        /// </summary>
        public string Reason { get; set; }
        
        /// <summary>
        /// تاريخ انتهاء الصلاحية
        /// </summary>
        public DateTime? ExpiryDate { get; set; }
    }
    
    /// <summary>
    /// معالج أمر حجز نطاق أرقام في تسلسل
    /// </summary>
    public class ReserveNumberRangeCommandHandler : IRequestHandler<ReserveNumberRangeCommand, ResponseResult<Guid>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IBranchService _branchService;
        private readonly IDateTimeService _dateTimeService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ReserveNumberRangeCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IBranchService branchService,
            IDateTimeService dateTimeService)
        {
            _context = context;
            _currentUserService = currentUserService;
            _branchService = branchService;
            _dateTimeService = dateTimeService;
        }
        
        /// <summary>
        /// تنفيذ الأمر
        /// </summary>
        public async Task<ResponseResult<Guid>> Handle(ReserveNumberRangeCommand request, CancellationToken cancellationToken)
        {
            var sequence = await _context.SequenceDefinitions
                .Include(s => s.NumberAllocations)
                .FirstOrDefaultAsync(s => s.Id == request.SequenceId, cancellationToken);
                
            if (sequence == null)
            {
                return ResponseResult<Guid>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود");
            }
            
            // التحقق من أن النطاق ضمن نطاق التسلسل
            if (request.RangeStart < sequence.StartNumber || request.RangeEnd > sequence.EndNumber)
            {
                return ResponseResult<Guid>.Failure(
                    "InvalidRange",
                    $"النطاق المطلوب خارج نطاق التسلسل ({sequence.StartNumber}-{sequence.EndNumber})");
            }
            
            // التحقق من أن النطاق غير محجوز بالفعل
            var overlappingAllocations = sequence.NumberAllocations
                .Where(a => a.Status != NumberAllocationStatusEnum.Expired &&
                          (a.StartNumber <= request.RangeEnd && a.EndNumber >= request.RangeStart))
                .ToList();
                
            if (overlappingAllocations.Any())
            {
                return ResponseResult<Guid>.Failure(
                    "RangeOverlap",
                    "النطاق المطلوب يتداخل مع نطاق محجوز بالفعل");
            }
            
            // التحقق من الفرع
            string branchName = "النظام";
            if (request.BranchId.HasValue)
            {
                var branch = await _branchService.GetBranchByIdAsync(request.BranchId.Value, cancellationToken);
                if (branch == null)
                {
                    return ResponseResult<Guid>.Failure(
                        "BranchNotFound",
                        "الفرع غير موجود");
                }
                branchName = branch.Name;
            }
            
            // إنشاء تخصيص جديد
            var allocationId = Guid.NewGuid();
            var allocation = new NumberAllocation
            {
                Id = allocationId,
                SequenceId = sequence.Id,
                StartNumber = request.RangeStart,
                EndNumber = request.RangeEnd,
                CurrentNumber = request.RangeStart,
                BranchId = request.BranchId,
                BranchName = branchName,
                Reason = request.Reason,
                Status = NumberAllocationStatusEnum.Active,
                AllocationDate = _dateTimeService.Now,
                ExpiryDate = request.ExpiryDate,
                CreatedBy = _currentUserService.UserId,
                CreatedAt = _dateTimeService.Now
            };
            
            // إضافة حدث حجز نطاق أرقام
            sequence.AddDomainEvent(new NumberRangeReservedEvent(
                sequence.Id, sequence.Code, request.RangeStart, request.RangeEnd, branchName));
            
            // حفظ التخصيص
            _context.NumberAllocations.Add(allocation);
            
            // إضافة سجل تدقيق
            var auditEntry = new SequenceAudit
            {
                SequenceId = sequence.Id,
                Type = SequenceAuditTypeEnum.NumberRangeReserved,
                Details = $"تم حجز نطاق الأرقام ({request.RangeStart}-{request.RangeEnd}) للفرع {branchName}" +
                        (!string.IsNullOrEmpty(request.Reason) ? $"\nالسبب: {request.Reason}" : ""),
                UserId = _currentUserService.UserId,
                Timestamp = _dateTimeService.Now
            };
            
            _context.SequenceAudits.Add(auditEntry);
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            return ResponseResult<Guid>.Success(allocationId,
                $"تم حجز نطاق الأرقام ({request.RangeStart}-{request.RangeEnd}) بنجاح");
        }
    }
    
    /// <summary>
    /// مدقق أمر حجز نطاق أرقام في تسلسل
    /// </summary>
    public class ReserveNumberRangeCommandValidator : AbstractValidator<ReserveNumberRangeCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ReserveNumberRangeCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.SequenceId)
                .NotEmpty().WithMessage("معرف التسلسل مطلوب");
                
            RuleFor(v => v.RangeStart)
                .GreaterThan(0).WithMessage("بداية النطاق يجب أن تكون أكبر من صفر");
                
            RuleFor(v => v.RangeEnd)
                .GreaterThan(v => v.RangeStart).WithMessage("نهاية النطاق يجب أن تكون أكبر من بداية النطاق");
                
            RuleFor(v => v)
                .Must(model => IsValidRange(model.SequenceId, model.RangeStart, model.RangeEnd))
                .WithMessage("النطاق المطلوب خارج نطاق التسلسل أو متداخل مع نطاق محجوز بالفعل");
                
            RuleFor(v => v.Reason)
                .MaximumLength(500).WithMessage("يجب ألا يتجاوز سبب الحجز 500 حرف");
                
            RuleFor(v => v.ExpiryDate)
                .Must(date => date == null || date > DateTime.UtcNow)
                .WithMessage("تاريخ انتهاء الصلاحية يجب أن يكون في المستقبل");
        }
        
        private bool IsValidRange(Guid sequenceId, long rangeStart, long rangeEnd)
        {
            var sequence = _context.SequenceDefinitions
                .Include(s => s.NumberAllocations)
                .FirstOrDefault(s => s.Id == sequenceId);
                
            if (sequence == null)
            {
                return false;
            }
            
            // التحقق من أن النطاق ضمن نطاق التسلسل
            if (rangeStart < sequence.StartNumber || rangeEnd > sequence.EndNumber)
            {
                return false;
            }
            
            // التحقق من عدم تداخل النطاق مع نطاقات محجوزة أخرى
            return !sequence.NumberAllocations
                .Where(a => a.Status != NumberAllocationStatusEnum.Expired)
                .Any(a => a.StartNumber <= rangeEnd && a.EndNumber >= rangeStart);
        }
    }
} 