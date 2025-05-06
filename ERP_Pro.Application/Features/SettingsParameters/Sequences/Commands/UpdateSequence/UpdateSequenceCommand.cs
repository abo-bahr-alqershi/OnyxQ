using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Models;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.UpdateSequence
{
    /// <summary>
    /// أمر تحديث تسلسل
    /// </summary>
    public class UpdateSequenceCommand : IRequest<ResponseResult<SequenceDetailsDto>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// الرمز
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// الاسم بالعربية
        /// </summary>
        public string NameAr { get; set; }
        
        /// <summary>
        /// الاسم بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }
        
        /// <summary>
        /// نوع المستند
        /// </summary>
        public string DocumentType { get; set; }
        
        /// <summary>
        /// المجموعة
        /// </summary>
        public string Group { get; set; }
        
        /// <summary>
        /// الوصف
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// البادئة
        /// </summary>
        public string Prefix { get; set; }
        
        /// <summary>
        /// اللاحقة
        /// </summary>
        public string Suffix { get; set; }
        
        /// <summary>
        /// استخدام رمز السنة المالية
        /// </summary>
        public bool IncludeFiscalYearCode { get; set; }
        
        /// <summary>
        /// تنسيق رمز السنة
        /// </summary>
        public string YearFormat { get; set; }
        
        /// <summary>
        /// استخدام رمز الفرع
        /// </summary>
        public bool IncludeBranchCode { get; set; }
        
        /// <summary>
        /// استخدام رمز الإدارة
        /// </summary>
        public bool IncludeDepartmentCode { get; set; }
        
        /// <summary>
        /// استخدام رمز القسم
        /// </summary>
        public bool IncludeSectionCode { get; set; }
        
        /// <summary>
        /// استخدام رمز المستخدم
        /// </summary>
        public bool IncludeUserCode { get; set; }
        
        /// <summary>
        /// عدد خانات الترقيم
        /// </summary>
        public int NumberLength { get; set; }
        
        /// <summary>
        /// فاصل البادئة
        /// </summary>
        public string PrefixSeparator { get; set; }
        
        /// <summary>
        /// فاصل اللاحقة
        /// </summary>
        public string SuffixSeparator { get; set; }
        
        /// <summary>
        /// إكمال الخانات بأصفار
        /// </summary>
        public bool PadWithZeros { get; set; }
        
        /// <summary>
        /// بداية نطاق الترقيم
        /// </summary>
        public long StartNumber { get; set; }
        
        /// <summary>
        /// نهاية نطاق الترقيم
        /// </summary>
        public long EndNumber { get; set; }
        
        /// <summary>
        /// الرقم الحالي
        /// </summary>
        public long CurrentNumber { get; set; }
        
        /// <summary>
        /// قيمة الزيادة
        /// </summary>
        public int Increment { get; set; }
        
        /// <summary>
        /// إعادة ضبط مع السنة المالية
        /// </summary>
        public bool ResetWithFiscalYear { get; set; }
        
        /// <summary>
        /// إعادة ضبط مع الفرع
        /// </summary>
        public bool ResetWithBranch { get; set; }
        
        /// <summary>
        /// إعادة ضبط مع الشهر
        /// </summary>
        public bool ResetWithMonth { get; set; }
        
        /// <summary>
        /// السماح بالتعديل اليدوي
        /// </summary>
        public bool AllowManualEdit { get; set; }
        
        /// <summary>
        /// المستخدمون المصرح لهم بالتعديل
        /// </summary>
        public string ManualEditAllowedUsers { get; set; }
        
        /// <summary>
        /// السماح بإعادة استخدام الأرقام الملغاة
        /// </summary>
        public bool AllowReuseOfCanceledNumbers { get; set; }
        
        /// <summary>
        /// أيام انتظار إعادة استخدام الأرقام الملغاة
        /// </summary>
        public int DaysBeforeReuseOfCanceledNumbers { get; set; }
        
        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
        
        /// <summary>
        /// الشاشات التي سيستخدم فيها هذا التسلسل
        /// </summary>
        public string UsedInScreens { get; set; }
    }
    
    /// <summary>
    /// معالج أمر تحديث تسلسل
    /// </summary>
    public class UpdateSequenceCommandHandler : IRequestHandler<UpdateSequenceCommand, ResponseResult<SequenceDetailsDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public UpdateSequenceCommandHandler(
            IApplicationDbContext context,
            IMapper mapper,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _mapper = mapper;
            _currentUserService = currentUserService;
        }
        
        /// <summary>
        /// تنفيذ الأمر
        /// </summary>
        public async Task<ResponseResult<SequenceDetailsDto>> Handle(UpdateSequenceCommand request, CancellationToken cancellationToken)
        {
            // البحث عن التسلسل
            var sequence = await _context.SequenceDefinitions
                .Include(s => s.NumberAllocations)
                .Include(s => s.UsedNumbers)
                .Include(s => s.CanceledNumbers)
                .Include(s => s.NumberGaps)
                .FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);
                
            if (sequence == null)
            {
                return ResponseResult<SequenceDetailsDto>.Failure(
                    "SequenceNotFound",
                    $"التسلسل غير موجود");
            }
            
            // التحقق من عدم وجود تسلسل آخر بنفس الرمز
            var existingSequence = await _context.SequenceDefinitions
                .Where(s => s.Code == request.Code && s.Id != request.Id)
                .FirstOrDefaultAsync(cancellationToken);
                
            if (existingSequence != null)
            {
                return ResponseResult<SequenceDetailsDto>.Failure(
                    "SequenceCodeAlreadyExists",
                    $"تسلسل برمز {request.Code} موجود بالفعل");
            }
            
            // حفظ القيم القديمة للتدقيق
            string oldValues = $"الاسم: {sequence.NameAr}, الرمز: {sequence.Code}, النطاق: {sequence.StartNumber}-{sequence.EndNumber}, الرقم الحالي: {sequence.CurrentNumber}";
            
            // تحديث بيانات التسلسل
            _mapper.Map(request, sequence);
            
            // تحديث بيانات التعديل
            sequence.LastModifiedBy = _currentUserService.UserId;
            sequence.LastModifiedAt = DateTime.UtcNow;
            
            // إضافة حدث تحديث التسلسل
            sequence.AddDomainEvent(new SequenceUpdatedEvent(sequence.Id, sequence.Code, sequence.NameAr));
            
            // حفظ التسلسل في قاعدة البيانات
            await _context.SaveChangesAsync(cancellationToken);
            
            // إضافة سجل تدقيق للتعديل
            var auditEntry = new SequenceAudit
            {
                SequenceId = sequence.Id,
                Type = SequenceAuditTypeEnum.Updated,
                Details = $"تم تعديل التسلسل {sequence.NameAr}\nالقيم السابقة: {oldValues}",
                UserId = _currentUserService.UserId,
                Timestamp = DateTime.UtcNow
            };
            
            _context.SequenceAudits.Add(auditEntry);
            await _context.SaveChangesAsync(cancellationToken);
            
            // إعادة البيانات
            var result = _mapper.Map<SequenceDetailsDto>(sequence);
            return ResponseResult<SequenceDetailsDto>.Success(result);
        }
    }
    
    /// <summary>
    /// مدقق أمر تحديث تسلسل
    /// </summary>
    public class UpdateSequenceCommandValidator : AbstractValidator<UpdateSequenceCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public UpdateSequenceCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.Id)
                .NotEmpty().WithMessage("معرف التسلسل مطلوب");
                
            RuleFor(v => v.Code)
                .NotEmpty().WithMessage("رمز التسلسل مطلوب")
                .MaximumLength(50).WithMessage("يجب ألا يتجاوز رمز التسلسل 50 حرفًا")
                .Must((model, code) => BeUniqueCode(model.Id, code)).WithMessage("رمز التسلسل موجود بالفعل")
                .Matches("^[a-zA-Z0-9_-]*$").WithMessage("رمز التسلسل يجب أن يحتوي على أحرف وأرقام فقط");
                
            RuleFor(v => v.NameAr)
                .NotEmpty().WithMessage("اسم التسلسل بالعربية مطلوب")
                .MaximumLength(100).WithMessage("يجب ألا يتجاوز اسم التسلسل بالعربية 100 حرف");
                
            RuleFor(v => v.NameEn)
                .NotEmpty().WithMessage("اسم التسلسل بالإنجليزية مطلوب")
                .MaximumLength(100).WithMessage("يجب ألا يتجاوز اسم التسلسل بالإنجليزية 100 حرف");
                
            RuleFor(v => v.DocumentType)
                .NotEmpty().WithMessage("نوع المستند مطلوب")
                .MaximumLength(100).WithMessage("يجب ألا يتجاوز نوع المستند 100 حرف");
                
            RuleFor(v => v.Group)
                .MaximumLength(100).WithMessage("يجب ألا تتجاوز المجموعة 100 حرف");
                
            RuleFor(v => v.Prefix)
                .MaximumLength(20).WithMessage("يجب ألا تتجاوز البادئة 20 حرفًا");
                
            RuleFor(v => v.Suffix)
                .MaximumLength(20).WithMessage("يجب ألا تتجاوز اللاحقة 20 حرفًا");
                
            RuleFor(v => v.NumberLength)
                .GreaterThan(0).WithMessage("يجب أن يكون عدد خانات الترقيم أكبر من صفر")
                .LessThanOrEqualTo(20).WithMessage("يجب ألا يتجاوز عدد خانات الترقيم 20 خانة");
                
            RuleFor(v => v.StartNumber)
                .LessThan(v => v.EndNumber).WithMessage("يجب أن تكون بداية نطاق الترقيم أقل من نهايته")
                .Must((model, startNumber) => IsStartNumberValid(model.Id, startNumber)).WithMessage("لا يمكن تغيير بداية النطاق إلى قيمة أكبر من الأرقام المستخدمة بالفعل");
                
            RuleFor(v => v.CurrentNumber)
                .GreaterThanOrEqualTo(v => v.StartNumber).WithMessage("يجب أن يكون الرقم الحالي أكبر من أو يساوي بداية النطاق")
                .LessThanOrEqualTo(v => v.EndNumber).WithMessage("يجب أن يكون الرقم الحالي أقل من أو يساوي نهاية النطاق");
                
            RuleFor(v => v.Increment)
                .GreaterThan(0).WithMessage("يجب أن تكون قيمة الزيادة أكبر من صفر");
                
            RuleFor(v => v.DaysBeforeReuseOfCanceledNumbers)
                .GreaterThanOrEqualTo(0).WithMessage("يجب أن تكون أيام انتظار إعادة استخدام الأرقام الملغاة صفر أو أكثر");
        }
        
        private bool BeUniqueCode(Guid id, string code)
        {
            return !_context.SequenceDefinitions.Any(s => s.Code == code && s.Id != id);
        }
        
        private bool IsStartNumberValid(Guid id, long startNumber)
        {
            // التحقق من أن بداية النطاق الجديدة لا تتجاوز أي رقم مستخدم بالفعل
            var sequence = _context.SequenceDefinitions
                .Include(s => s.UsedNumbers)
                .FirstOrDefault(s => s.Id == id);
                
            if (sequence == null || !sequence.UsedNumbers.Any())
            {
                return true;
            }
            
            // لا يمكن تغيير بداية النطاق إلى قيمة أكبر من أقل رقم مستخدم
            long minUsedNumber = sequence.UsedNumbers.Min(n => n.NumericValue);
            return startNumber <= minUsedNumber;
        }
    }
} 