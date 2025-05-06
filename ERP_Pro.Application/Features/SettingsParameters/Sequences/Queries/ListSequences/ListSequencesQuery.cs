using AutoMapper;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.ListSequences
{
    /// <summary>
    /// استعلام قائمة التسلسلات
    /// </summary>
    public class ListSequencesQuery : IRequest<ResponseResult<PaginatedList<SequenceListItemDto>>>
    {
        /// <summary>
        /// رقم الصفحة
        /// </summary>
        public int PageNumber { get; set; } = 1;
        
        /// <summary>
        /// حجم الصفحة
        /// </summary>
        public int PageSize { get; set; } = 10;
        
        /// <summary>
        /// مصطلح البحث
        /// </summary>
        public string SearchTerm { get; set; }
        
        /// <summary>
        /// المجموعة
        /// </summary>
        public string Group { get; set; }
        
        /// <summary>
        /// نوع المستند
        /// </summary>
        public string DocumentType { get; set; }
        
        /// <summary>
        /// الحالة
        /// </summary>
        public string Status { get; set; }
    }
    
    /// <summary>
    /// معالج استعلام قائمة التسلسلات
    /// </summary>
    public class ListSequencesQueryHandler : IRequestHandler<ListSequencesQuery, ResponseResult<PaginatedList<SequenceListItemDto>>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ListSequencesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        /// <summary>
        /// تنفيذ الاستعلام
        /// </summary>
        public async Task<ResponseResult<PaginatedList<SequenceListItemDto>>> Handle(ListSequencesQuery request, CancellationToken cancellationToken)
        {
            var query = _context.SequenceDefinitions.AsQueryable();
            
            // تطبيق مرشحات البحث
            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var searchTerm = request.SearchTerm.Trim().ToLower();
                query = query.Where(s => 
                    s.Code.ToLower().Contains(searchTerm) ||
                    s.NameAr.ToLower().Contains(searchTerm) ||
                    s.NameEn.ToLower().Contains(searchTerm)
                );
            }
            
            if (!string.IsNullOrWhiteSpace(request.Group))
            {
                query = query.Where(s => s.Group == request.Group);
            }
            
            if (!string.IsNullOrWhiteSpace(request.DocumentType))
            {
                query = query.Where(s => s.DocumentType == request.DocumentType);
            }
            
            if (!string.IsNullOrWhiteSpace(request.Status))
            {
                query = query.Where(s => s.Status.ToString() == request.Status);
            }
            
            // ترتيب النتائج
            query = query.OrderBy(s => s.Group).ThenBy(s => s.DocumentType).ThenBy(s => s.Code);
            
            // الحصول على إجمالي العناصر
            var totalItems = await query.CountAsync(cancellationToken);
            
            // تطبيق الصفحات
            var sequences = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);
                
            // تحويل النتائج إلى DTOs
            var items = _mapper.Map<List<SequenceListItemDto>>(sequences);
            
            // إنشاء قائمة مقسمة إلى صفحات
            var paginatedList = new PaginatedList<SequenceListItemDto>(
                items,
                totalItems,
                request.PageNumber,
                request.PageSize
            );
            
            return ResponseResult<PaginatedList<SequenceListItemDto>>.Success(paginatedList);
        }
    }
} 