using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetNextNumber
{
    /// <summary>
    /// استعلام الحصول على الرقم التالي في تسلسل
    /// </summary>
    public class GetNextNumberQuery : IRequest<ResponseResult<string>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid? Id { get; set; }
        
        /// <summary>
        /// رمز التسلسل
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid? BranchId { get; set; }
        
        /// <summary>
        /// معرف الإدارة
        /// </summary>
        public Guid? DepartmentId { get; set; }
        
        /// <summary>
        /// معرف القسم
        /// </summary>
        public Guid? SectionId { get; set; }
        
        /// <summary>
        /// تاريخ المستند
        /// </summary>
        public DateTime? DocumentDate { get; set; }
        
        /// <summary>
        /// تثبيت الرقم
        /// </summary>
        public bool CommitNumber { get; set; } = true;
    }
    
    /// <summary>
    /// معالج استعلام الحصول على الرقم التالي في تسلسل
    /// </summary>
    public class GetNextNumberQueryHandler : IRequestHandler<GetNextNumberQuery, ResponseResult<string>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IBranchService _branchService;
        private readonly IDateTimeService _dateTimeService;
        private readonly IFiscalYearService _fiscalYearService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public GetNextNumberQueryHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IBranchService branchService,
            IDateTimeService dateTimeService,
            IFiscalYearService fiscalYearService)
        {
            _context = context;
            _currentUserService = currentUserService;
            _branchService = branchService;
            _dateTimeService = dateTimeService;
            _fiscalYearService = fiscalYearService;
        }
        
        /// <summary>
        /// تنفيذ الاستعلام
        /// </summary>
        public async Task<ResponseResult<string>> Handle(GetNextNumberQuery request, CancellationToken cancellationToken)
        {
            // البحث عن التسلسل باستخدام المعرف أو الرمز
            var sequence = await GetSequenceAsync(request.Id, request.Code, cancellationToken);
            
            if (sequence == null)
            {
                return ResponseResult<string>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود"
                );
            }
            
            // التحقق من أن التسلسل نشط
            if (sequence.Status != SequenceStatusEnum.Active)
            {
                return ResponseResult<string>.Failure(
                    "SequenceNotActive",
                    $"التسلسل {sequence.NameAr} غير نشط"
                );
            }
            
            // التحقق من عدم تجاوز الحد الأقصى للترقيم
            if (sequence.CurrentNumber >= sequence.EndNumber)
            {
                return ResponseResult<string>.Failure(
                    "SequenceRangeExceeded",
                    $"تم تجاوز نطاق التسلسل {sequence.NameAr}"
                );
            }
            
            // الحصول على الفرع الحالي
            var branch = await GetBranchAsync(request.BranchId, cancellationToken);
            
            // الحصول على السنة المالية الحالية
            var fiscalYear = await _fiscalYearService.GetCurrentFiscalYearAsync(cancellationToken);
            
            // توليد الرقم التالي
            var nextNumber = sequence.CurrentNumber;
            var formattedNumber = FormatSequenceNumber(sequence, nextNumber, branch, fiscalYear);
            
            // إذا كان التثبيت مطلوبًا، قم بتحديث الرقم الحالي وإنشاء سجل للرقم المستخدم
            if (request.CommitNumber)
            {
                // تحديث الرقم الحالي
                sequence.CurrentNumber += sequence.Increment;
                
                // إنشاء سجل للرقم المستخدم
                var usedNumber = new UsedNumber
                {
                    SequenceId = sequence.Id,
                    NumericValue = nextNumber,
                    FormattedNumber = formattedNumber,
                    UserId = _currentUserService.UserId,
                    BranchId = branch?.Id,
                    CreatedAt = _dateTimeService.Now
                };
                
                // إضافة حدث توليد الرقم
                sequence.AddDomainEvent(new NumberGeneratedEvent(
                    sequence.Id, sequence.Code, nextNumber, formattedNumber));
                
                // حفظ التغييرات
                _context.UsedNumbers.Add(usedNumber);
                await _context.SaveChangesAsync(cancellationToken);
                
                // إضافة سجل تدقيق
                var auditEntry = new SequenceAudit
                {
                    SequenceId = sequence.Id,
                    Type = SequenceAuditTypeEnum.NumberGenerated,
                    Details = $"تم إنشاء الرقم {formattedNumber}",
                    UserId = _currentUserService.UserId,
                    Timestamp = _dateTimeService.Now
                };
                
                _context.SequenceAudits.Add(auditEntry);
                await _context.SaveChangesAsync(cancellationToken);
            }
            
            return ResponseResult<string>.Success(formattedNumber);
        }
        
        private async Task<SequenceDefinition> GetSequenceAsync(Guid? id, string code, CancellationToken cancellationToken)
        {
            if (id.HasValue)
            {
                return await _context.SequenceDefinitions
                    .FirstOrDefaultAsync(s => s.Id == id.Value, cancellationToken);
            }
            
            if (!string.IsNullOrEmpty(code))
            {
                return await _context.SequenceDefinitions
                    .FirstOrDefaultAsync(s => s.Code == code, cancellationToken);
            }
            
            return null;
        }
        
        private async Task<dynamic> GetBranchAsync(Guid? branchId, CancellationToken cancellationToken)
        {
            if (branchId.HasValue)
            {
                return await _branchService.GetBranchByIdAsync(branchId.Value, cancellationToken);
            }
            
            return await _branchService.GetCurrentBranchAsync(cancellationToken);
        }
        
        private string FormatSequenceNumber(SequenceDefinition sequence, long number, dynamic branch, dynamic fiscalYear)
        {
            var result = new StringBuilder();
            
            // إضافة البادئة
            if (!string.IsNullOrEmpty(sequence.Prefix))
            {
                result.Append(sequence.Prefix);
                if (!string.IsNullOrEmpty(sequence.PrefixSeparator))
                {
                    result.Append(sequence.PrefixSeparator);
                }
            }
            
            // إضافة رمز السنة المالية
            if (sequence.IncludeFiscalYearCode && fiscalYear != null)
            {
                string yearCode = FormatYear(fiscalYear.Year, sequence.YearFormat);
                result.Append(yearCode);
                if (!string.IsNullOrEmpty(sequence.PrefixSeparator))
                {
                    result.Append(sequence.PrefixSeparator);
                }
            }
            
            // إضافة رمز الفرع
            if (sequence.IncludeBranchCode && branch != null)
            {
                result.Append(branch.Code);
                if (!string.IsNullOrEmpty(sequence.PrefixSeparator))
                {
                    result.Append(sequence.PrefixSeparator);
                }
            }
            
            // تنسيق الرقم
            string numberPart = sequence.PadWithZeros
                ? number.ToString().PadLeft(sequence.NumberLength, '0')
                : number.ToString();
                
            result.Append(numberPart);
            
            // إضافة اللاحقة
            if (!string.IsNullOrEmpty(sequence.Suffix))
            {
                if (!string.IsNullOrEmpty(sequence.SuffixSeparator))
                {
                    result.Append(sequence.SuffixSeparator);
                }
                result.Append(sequence.Suffix);
            }
            
            return result.ToString();
        }
        
        private string FormatYear(int year, string format)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "YY"; // الافتراضي: السنة بخانتين
            }
            
            switch (format.ToUpper())
            {
                case "YYYY": // السنة بأربع خانات
                    return year.ToString();
                case "YY": // السنة بخانتين
                    return (year % 100).ToString().PadLeft(2, '0');
                default:
                    return (year % 100).ToString().PadLeft(2, '0');
            }
        }
    }
} 