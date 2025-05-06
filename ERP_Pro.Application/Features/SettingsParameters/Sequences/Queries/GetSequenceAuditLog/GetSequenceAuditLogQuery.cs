using AutoMapper;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetSequenceAuditLog
{
    /// <summary>
    /// نموذج سجل تدقيق تسلسل
    /// </summary>
    public class SequenceAuditLogDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// نوع العملية
        /// </summary>
        public string OperationType { get; set; }
        
        /// <summary>
        /// تفاصيل العملية
        /// </summary>
        public string Details { get; set; }
        
        /// <summary>
        /// اسم المستخدم
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// تاريخ العملية
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
    
    /// <summary>
    /// استعلام الحصول على سجل تدقيق تسلسل
    /// </summary>
    public class GetSequenceAuditLogQuery : IRequest<ResponseResult<PaginatedList<SequenceAuditLogDto>>>
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
        /// أنواع العمليات
        /// </summary>
        public List<SequenceAuditTypeEnum> OperationTypes { get; set; }
        
        /// <summary>
        /// معرف المستخدم
        /// </summary>
        public Guid? UserId { get; set; }
    }
    
    /// <summary>
    /// معالج استعلام الحصول على سجل تدقيق تسلسل
    /// </summary>
    public class GetSequenceAuditLogQueryHandler : IRequestHandler<GetSequenceAuditLogQuery, ResponseResult<PaginatedList<SequenceAuditLogDto>>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IUserService _userService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public GetSequenceAuditLogQueryHandler(
            IApplicationDbContext context,
            IUserService userService)
        {
            _context = context;
            _userService = userService;
        }
        
        /// <summary>
        /// تنفيذ الاستعلام
        /// </summary>
        public async Task<ResponseResult<PaginatedList<SequenceAuditLogDto>>> Handle(GetSequenceAuditLogQuery request, CancellationToken cancellationToken)
        {
            // التحقق من وجود التسلسل
            var sequenceExists = await _context.SequenceDefinitions
                .AnyAsync(s => s.Id == request.SequenceId, cancellationToken);
                
            if (!sequenceExists)
            {
                return ResponseResult<PaginatedList<SequenceAuditLogDto>>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود");
            }
            
            // استعلام للحصول على سجلات التدقيق
            var query = _context.SequenceAudits
                .Where(a => a.SequenceId == request.SequenceId);
                
            // تطبيق فلاتر التاريخ
            if (request.StartDate.HasValue)
            {
                query = query.Where(a => a.Timestamp >= request.StartDate.Value);
            }
            
            if (request.EndDate.HasValue)
            {
                query = query.Where(a => a.Timestamp <= request.EndDate.Value);
            }
            
            // تطبيق فلتر أنواع العمليات
            if (request.OperationTypes != null && request.OperationTypes.Count > 0)
            {
                query = query.Where(a => request.OperationTypes.Contains(a.Type));
            }
            
            // تطبيق فلتر المستخدم
            if (request.UserId.HasValue)
            {
                query = query.Where(a => a.UserId == request.UserId.Value);
            }
            
            // ترتيب النتائج من الأحدث إلى الأقدم
            query = query.OrderByDescending(a => a.Timestamp);
            
            // الحصول على إجمالي العناصر
            var totalItems = await query.CountAsync(cancellationToken);
            
            // تطبيق الصفحات
            var auditEntries = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);
                
            // تحويل النتائج إلى DTOs
            var result = new List<SequenceAuditLogDto>();
            
            foreach (var audit in auditEntries)
            {
                var userName = await _userService.GetUserNameAsync(audit.UserId, cancellationToken);
                
                result.Add(new SequenceAuditLogDto
                {
                    Id = audit.Id,
                    OperationType = audit.Type.ToString(),
                    Details = audit.Details,
                    UserName = userName,
                    Timestamp = audit.Timestamp
                });
            }
            
            // إنشاء قائمة مقسمة إلى صفحات
            var paginatedList = new PaginatedList<SequenceAuditLogDto>(
                result,
                totalItems,
                request.PageNumber,
                request.PageSize
            );
            
            return ResponseResult<PaginatedList<SequenceAuditLogDto>>.Success(paginatedList);
        }
    }
} 