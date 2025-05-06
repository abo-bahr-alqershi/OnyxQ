using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediatR;
using AutoMapper;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Queries.ListBranches
{
    /// <summary>
    /// استعلام للحصول على قائمة الفروع
    /// </summary>
    public class ListBranchesQuery : IRequest<PaginatedList<BranchListItemDto>>
    {
        /// <summary>
        /// معرف الشركة (اختياري)
        /// </summary>
        public Guid? CompanyId { get; set; }
        
        /// <summary>
        /// معرف الفرع الأب (اختياري)
        /// </summary>
        public Guid? ParentBranchId { get; set; }
        
        /// <summary>
        /// الفروع النشطة فقط (اختياري)
        /// </summary>
        public bool? ActiveOnly { get; set; }
        
        /// <summary>
        /// كلمة البحث (اختياري)
        /// </summary>
        public string SearchTerm { get; set; }
        
        /// <summary>
        /// رقم الصفحة (للتصفح الصفحي)
        /// </summary>
        public int PageNumber { get; set; } = 1;
        
        /// <summary>
        /// حجم الصفحة (للتصفح الصفحي)
        /// </summary>
        public int PageSize { get; set; } = 10;
        
        /// <summary>
        /// حقل الترتيب
        /// </summary>
        public string OrderBy { get; set; } = "NameAr";
        
        /// <summary>
        /// اتجاه الترتيب
        /// </summary>
        public string OrderDirection { get; set; } = "asc";
    }
    
    /// <summary>
    /// معالج استعلام الحصول على قائمة الفروع
    /// </summary>
    public class ListBranchesQueryHandler : IRequestHandler<ListBranchesQuery, PaginatedList<BranchListItemDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ListBranchesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        /// <summary>
        /// معالجة الاستعلام
        /// </summary>
        public async Task<PaginatedList<BranchListItemDto>> Handle(ListBranchesQuery request, CancellationToken cancellationToken)
        {
            // تحضير الاستعلام الأساسي
            var query = _context.Branches.AsQueryable();
            
            // تطبيق الفلتر حسب الشركة
            if (request.CompanyId.HasValue)
            {
                query = query.Where(b => b.CompanyInfoId == request.CompanyId.Value);
            }
            
            // تطبيق الفلتر حسب الفرع الأب
            if (request.ParentBranchId.HasValue)
            {
                query = query.Where(b => b.ParentBranchId == request.ParentBranchId.Value);
            }
            else if (request.ParentBranchId == Guid.Empty)
            {
                // إذا كان الفرع الأب Empty، استرجاع الفروع الرئيسية فقط
                query = query.Where(b => b.ParentBranchId == null);
            }
            
            // تطبيق الفلتر حسب الحالة
            if (request.ActiveOnly.HasValue && request.ActiveOnly.Value)
            {
                query = query.Where(b => b.Status == "Active");
            }
            
            // تطبيق فلتر البحث
            if (!string.IsNullOrEmpty(request.SearchTerm))
            {
                var searchTerm = request.SearchTerm.ToLower();
                query = query.Where(b => 
                    b.NameAr.ToLower().Contains(searchTerm) ||
                    b.NameEn.ToLower().Contains(searchTerm) ||
                    b.Code.ToLower().Contains(searchTerm));
            }
            
            // تطبيق الترتيب
            query = ApplyOrder(query, request.OrderBy, request.OrderDirection);
            
            // تطبيق التصفح الصفحي
            var totalItems = await query.CountAsync(cancellationToken);
            
            var branches = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);
                
            // تحويل البيانات إلى DTOs
            var branchDtos = _mapper.Map<List<BranchListItemDto>>(branches);
            
            // إضافة معلومات إضافية
            foreach (var branchDto in branchDtos)
            {
                // إضافة عدد المستودعات
                branchDto.WarehousesCount = await _context.Warehouses
                    .CountAsync(w => w.BranchId == branchDto.Id, cancellationToken);
                    
                // إضافة اسم الفرع الأب
                if (branchDto.ParentBranchId.HasValue)
                {
                    var parentBranch = await _context.Branches
                        .FirstOrDefaultAsync(b => b.Id == branchDto.ParentBranchId, cancellationToken);
                    if (parentBranch != null)
                    {
                        branchDto.ParentBranchName = parentBranch.NameAr;
                    }
                }
            }
            
            return new PaginatedList<BranchListItemDto>(
                branchDtos,
                totalItems,
                request.PageNumber,
                request.PageSize);
        }
        
        /// <summary>
        /// تطبيق الترتيب على الاستعلام
        /// </summary>
        private IQueryable<Domain.SettingsParameters.Entities.Branch> ApplyOrder(
            IQueryable<Domain.SettingsParameters.Entities.Branch> query,
            string orderBy,
            string orderDirection)
        {
            orderBy = orderBy?.ToLower() ?? "namear";
            orderDirection = orderDirection?.ToLower() ?? "asc";
            
            bool isAscending = orderDirection != "desc";
            
            return orderBy switch
            {
                "code" => isAscending ? query.OrderBy(b => b.Code) : query.OrderByDescending(b => b.Code),
                "nameen" => isAscending ? query.OrderBy(b => b.NameEn) : query.OrderByDescending(b => b.NameEn),
                "branchtype" => isAscending ? query.OrderBy(b => b.BranchType) : query.OrderByDescending(b => b.BranchType),
                "status" => isAscending ? query.OrderBy(b => b.Status) : query.OrderByDescending(b => b.Status),
                "city" => isAscending ? query.OrderBy(b => b.City) : query.OrderByDescending(b => b.City),
                "country" => isAscending ? query.OrderBy(b => b.Country) : query.OrderByDescending(b => b.Country),
                "createdat" => isAscending ? query.OrderBy(b => b.CreatedAt) : query.OrderByDescending(b => b.CreatedAt),
                _ => isAscending ? query.OrderBy(b => b.NameAr) : query.OrderByDescending(b => b.NameAr)
            };
        }
    }
} 