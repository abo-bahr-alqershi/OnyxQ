using AutoMapper;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetSequenceNumbersHistory
{
    /// <summary>
    /// نموذج تاريخ الأرقام المستخدمة
    /// </summary>
    public class SequenceNumberHistoryDto
    {
        /// <summary>
        /// الرقم المنسق
        /// </summary>
        public string FormattedNumber { get; set; }
        
        /// <summary>
        /// القيمة العددية
        /// </summary>
        public long NumericValue { get; set; }
        
        /// <summary>
        /// تاريخ الاستخدام
        /// </summary>
        public DateTime UsageDate { get; set; }
        
        /// <summary>
        /// اسم المستخدم
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// اسم الفرع
        /// </summary>
        public string BranchName { get; set; }
        
        /// <summary>
        /// حالة الرقم
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// تاريخ الإلغاء
        /// </summary>
        public DateTime? CancelDate { get; set; }
        
        /// <summary>
        /// سبب الإلغاء
        /// </summary>
        public string CancelReason { get; set; }
    }
    
    /// <summary>
    /// استعلام الحصول على تاريخ الأرقام المستخدمة في تسلسل
    /// </summary>
    public class GetSequenceNumbersHistoryQuery : IRequest<ResponseResult<PaginatedList<SequenceNumberHistoryDto>>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid SequenceId { get; set; }
        
        /// <summary>
        /// رقم الصفحة
        /// </summary>
        public int PageNumber { get; set; } = 1;
        
        /// <summary>
        /// حجم الصفحة
        /// </summary>
        public int PageSize { get; set; } = 20;
        
        /// <summary>
        /// تاريخ البداية
        /// </summary>
        public DateTime? StartDate { get; set; }
        
        /// <summary>
        /// تاريخ النهاية
        /// </summary>
        public DateTime? EndDate { get; set; }
        
        /// <summary>
        /// نوع الترتيب
        /// </summary>
        public string SortBy { get; set; } = "Date";
        
        /// <summary>
        /// اتجاه الترتيب
        /// </summary>
        public string SortDirection { get; set; } = "Desc";
        
        /// <summary>
        /// مصطلح البحث
        /// </summary>
        public string SearchTerm { get; set; }
        
        /// <summary>
        /// عرض الأرقام الملغاة فقط
        /// </summary>
        public bool? CanceledOnly { get; set; }
    }
    
    /// <summary>
    /// معالج استعلام الحصول على تاريخ الأرقام المستخدمة في تسلسل
    /// </summary>
    public class GetSequenceNumbersHistoryQueryHandler : IRequestHandler<GetSequenceNumbersHistoryQuery, ResponseResult<PaginatedList<SequenceNumberHistoryDto>>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IUserService _userService;
        private readonly IBranchService _branchService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public GetSequenceNumbersHistoryQueryHandler(
            IApplicationDbContext context,
            IUserService userService,
            IBranchService branchService)
        {
            _context = context;
            _userService = userService;
            _branchService = branchService;
        }
        
        /// <summary>
        /// تنفيذ الاستعلام
        /// </summary>
        public async Task<ResponseResult<PaginatedList<SequenceNumberHistoryDto>>> Handle(GetSequenceNumbersHistoryQuery request, CancellationToken cancellationToken)
        {
            // التحقق من وجود التسلسل
            var sequenceExists = await _context.SequenceDefinitions
                .AnyAsync(s => s.Id == request.SequenceId, cancellationToken);
                
            if (!sequenceExists)
            {
                return ResponseResult<PaginatedList<SequenceNumberHistoryDto>>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود");
            }
            
            // الحصول على الأرقام المستخدمة
            var usedNumbersQuery = _context.UsedNumbers
                .Where(n => n.SequenceId == request.SequenceId);
                
            // تطبيق فلاتر التاريخ
            if (request.StartDate.HasValue)
            {
                usedNumbersQuery = usedNumbersQuery.Where(n => n.CreatedAt >= request.StartDate.Value);
            }
            
            if (request.EndDate.HasValue)
            {
                usedNumbersQuery = usedNumbersQuery.Where(n => n.CreatedAt <= request.EndDate.Value);
            }
            
            // الحصول على الأرقام الملغاة
            var canceledNumbersQuery = _context.CanceledNumbers
                .Where(n => n.SequenceId == request.SequenceId);
                
            // دمج الاستعلامين للحصول على البيانات
            var usedNumbers = await usedNumbersQuery.ToListAsync(cancellationToken);
            var canceledNumbers = await canceledNumbersQuery.ToListAsync(cancellationToken);
            
            // إنشاء القائمة النهائية
            var result = new List<SequenceNumberHistoryDto>();
            
            foreach (var usedNumber in usedNumbers)
            {
                var canceledNumber = canceledNumbers
                    .FirstOrDefault(c => c.FormattedNumber == usedNumber.FormattedNumber);
                    
                var userName = await _userService.GetUserNameAsync(usedNumber.UserId, cancellationToken);
                var branchName = usedNumber.BranchId.HasValue 
                    ? await _branchService.GetBranchNameAsync(usedNumber.BranchId.Value, cancellationToken)
                    : "غير محدد";
                    
                var historyItem = new SequenceNumberHistoryDto
                {
                    FormattedNumber = usedNumber.FormattedNumber,
                    NumericValue = usedNumber.NumericValue,
                    UsageDate = usedNumber.CreatedAt,
                    UserName = userName,
                    BranchName = branchName,
                    Status = canceledNumber != null ? "ملغي" : "مستخدم",
                    CancelDate = canceledNumber?.CancelDate,
                    CancelReason = canceledNumber?.Reason
                };
                
                // فلترة بناءً على حالة الإلغاء إذا تم تحديدها
                if (request.CanceledOnly.HasValue)
                {
                    if (request.CanceledOnly.Value && canceledNumber == null)
                    {
                        continue; // تخطي هذا الرقم إذا لم يكن ملغى
                    }
                    else if (!request.CanceledOnly.Value && canceledNumber != null)
                    {
                        continue; // تخطي هذا الرقم إذا كان ملغى
                    }
                }
                
                // فلترة بناءً على مصطلح البحث
                if (!string.IsNullOrEmpty(request.SearchTerm))
                {
                    var searchTerm = request.SearchTerm.ToLower();
                    if (!(historyItem.FormattedNumber.ToLower().Contains(searchTerm) ||
                          historyItem.UserName.ToLower().Contains(searchTerm) ||
                          historyItem.BranchName.ToLower().Contains(searchTerm) ||
                          (historyItem.CancelReason?.ToLower().Contains(searchTerm) ?? false)))
                    {
                        continue; // تخطي هذا الرقم إذا لم يتطابق مع مصطلح البحث
                    }
                }
                
                result.Add(historyItem);
            }
            
            // ترتيب النتائج
            switch (request.SortBy.ToLower())
            {
                case "number":
                    result = request.SortDirection.ToLower() == "asc"
                        ? result.OrderBy(h => h.FormattedNumber).ToList()
                        : result.OrderByDescending(h => h.FormattedNumber).ToList();
                    break;
                case "numericvalue":
                    result = request.SortDirection.ToLower() == "asc"
                        ? result.OrderBy(h => h.NumericValue).ToList()
                        : result.OrderByDescending(h => h.NumericValue).ToList();
                    break;
                case "status":
                    result = request.SortDirection.ToLower() == "asc"
                        ? result.OrderBy(h => h.Status).ToList()
                        : result.OrderByDescending(h => h.Status).ToList();
                    break;
                case "branch":
                    result = request.SortDirection.ToLower() == "asc"
                        ? result.OrderBy(h => h.BranchName).ToList()
                        : result.OrderByDescending(h => h.BranchName).ToList();
                    break;
                case "user":
                    result = request.SortDirection.ToLower() == "asc"
                        ? result.OrderBy(h => h.UserName).ToList()
                        : result.OrderByDescending(h => h.UserName).ToList();
                    break;
                case "canceldate":
                    result = request.SortDirection.ToLower() == "asc"
                        ? result.OrderBy(h => h.CancelDate ?? DateTime.MaxValue).ToList()
                        : result.OrderByDescending(h => h.CancelDate ?? DateTime.MinValue).ToList();
                    break;
                default: // Date
                    result = request.SortDirection.ToLower() == "asc"
                        ? result.OrderBy(h => h.UsageDate).ToList()
                        : result.OrderByDescending(h => h.UsageDate).ToList();
                    break;
            }
            
            // تطبيق الصفحات
            var totalItems = result.Count;
            var paginatedItems = result
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();
                
            // إنشاء قائمة مقسمة إلى صفحات
            var paginatedList = new PaginatedList<SequenceNumberHistoryDto>(
                paginatedItems,
                totalItems,
                request.PageNumber,
                request.PageSize
            );
            
            return ResponseResult<PaginatedList<SequenceNumberHistoryDto>>.Success(paginatedList);
        }
    }
} 