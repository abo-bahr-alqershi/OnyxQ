using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Models;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;
using System;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using System.Linq;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.CreateSequence
{
    /// <summary>
    /// أمر إنشاء تسلسل جديد
    /// </summary>
    public class CreateSequenceCommand : IRequest<ResponseResult<SequenceDetailsDto>>
    {
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
        public int NumberLength { get; set; } = 6;
        
        /// <summary>
        /// فاصل البادئة
        /// </summary>
        public string PrefixSeparator { get; set; } = "-";
        
        /// <summary>
        /// فاصل اللاحقة
        /// </summary>
        public string SuffixSeparator { get; set; } = "-";
        
        /// <summary>
        /// إكمال الخانات بأصفار
        /// </summary>
        public bool PadWithZeros { get; set; } = true;
        
        /// <summary>
        /// بداية نطاق الترقيم
        /// </summary>
        public long StartNumber { get; set; } = 1;
        
        /// <summary>
        /// نهاية نطاق الترقيم
        /// </summary>
        public long EndNumber { get; set; } = 999999;
        
        /// <summary>
        /// الرقم الحالي
        /// </summary>
        public long CurrentNumber { get; set; } = 1;
        
        /// <summary>
        /// قيمة الزيادة
        /// </summary>
        public int Increment { get; set; } = 1;
        
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
        public int DaysBeforeReuseOfCanceledNumbers { get; set; } = 30;
        
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
    /// معالج أمر إنشاء تسلسل جديد
    /// </summary>
    public class CreateSequenceCommandHandler : IRequestHandler<CreateSequenceCommand, ResponseResult<SequenceDetailsDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public CreateSequenceCommandHandler(
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
        public async Task<ResponseResult<SequenceDetailsDto>> Handle(CreateSequenceCommand request, CancellationToken cancellationToken)
        {
            // التحقق من عدم وجود تسلسل بنفس الرمز
            var existingSequence = _context.SequenceDefinitions
                .Where(s => s.Code == request.Code)
                .FirstOrDefault();
                
            if (existingSequence != null)
            {
                return ResponseResult<SequenceDetailsDto>.Failure(
                    "SequenceCodeAlreadyExists",
                    $"تسلسل برمز {request.Code} موجود بالفعل");
            }
            
            // إنشاء كيان التسلسل
            var sequence = _mapper.Map<SequenceDefinition>(request);
            
            // إضافة بيانات الإنشاء
            sequence.CreatedBy = _currentUserService.UserId;
            sequence.CreatedAt = DateTime.UtcNow;
            
            // إضافة حدث إنشاء التسلسل
            sequence.AddDomainEvent(new SequenceCreatedEvent(sequence.Id, sequence.Code, sequence.NameAr));
            
            // حفظ التسلسل في قاعدة البيانات
            _context.SequenceDefinitions.Add(sequence);
            await _context.SaveChangesAsync(cancellationToken);
            
            // إضافة سجل تدقيق للإنشاء
            var auditEntry = new SequenceAudit
            {
                SequenceId = sequence.Id,
                Type = SequenceAuditTypeEnum.Created,
                Details = $"تم إنشاء التسلسل {sequence.NameAr}",
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
    /// مدقق أمر إنشاء تسلسل جديد
    /// </summary>
    public class CreateSequenceCommandValidator : AbstractValidator<CreateSequenceCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public CreateSequenceCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.Code)
                .NotEmpty().WithMessage("رمز التسلسل مطلوب")
                .MaximumLength(50).WithMessage("يجب ألا يتجاوز رمز التسلسل 50 حرفًا")
                .Must(BeUniqueCode).WithMessage("رمز التسلسل موجود بالفعل")
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
                .LessThan(v => v.EndNumber).WithMessage("يجب أن تكون بداية نطاق الترقيم أقل من نهايته");
                
            RuleFor(v => v.CurrentNumber)
                .GreaterThanOrEqualTo(v => v.StartNumber).WithMessage("يجب أن يكون الرقم الحالي أكبر من أو يساوي بداية النطاق")
                .LessThanOrEqualTo(v => v.EndNumber).WithMessage("يجب أن يكون الرقم الحالي أقل من أو يساوي نهاية النطاق");
                
            RuleFor(v => v.Increment)
                .GreaterThan(0).WithMessage("يجب أن تكون قيمة الزيادة أكبر من صفر");
                
            RuleFor(v => v.DaysBeforeReuseOfCanceledNumbers)
                .GreaterThanOrEqualTo(0).WithMessage("يجب أن تكون أيام انتظار إعادة استخدام الأرقام الملغاة صفر أو أكثر");
        }
        
        private bool BeUniqueCode(string code)
        {
            return !_context.SequenceDefinitions.Any(s => s.Code == code);
        }
    }
} 