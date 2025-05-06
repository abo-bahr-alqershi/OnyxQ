using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediatR;
using AutoMapper;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Queries.GetBranchHierarchy
{
    /// <summary>
    /// استعلام للحصول على الهيكل الهرمي للفروع
    /// </summary>
    public class GetBranchHierarchyQuery : IRequest<List<BranchHierarchyItemDto>>
    {
        /// <summary>
        /// معرف الشركة (اختياري)
        /// </summary>
        public Guid? CompanyId { get; set; }
        
        /// <summary>
        /// الفروع النشطة فقط (اختياري)
        /// </summary>
        public bool? ActiveOnly { get; set; }
        
        /// <summary>
        /// تضمين تفاصيل إضافية
        /// </summary>
        public bool IncludeDetails { get; set; } = false;
    }
    
    /// <summary>
    /// معالج استعلام الحصول على الهيكل الهرمي للفروع
    /// </summary>
    public class GetBranchHierarchyQueryHandler : IRequestHandler<GetBranchHierarchyQuery, List<BranchHierarchyItemDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public GetBranchHierarchyQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        /// <summary>
        /// معالجة الاستعلام
        /// </summary>
        public async Task<List<BranchHierarchyItemDto>> Handle(GetBranchHierarchyQuery request, CancellationToken cancellationToken)
        {
            // تحضير الاستعلام الأساسي
            var query = _context.Branches.AsQueryable();
            
            // تطبيق الفلتر حسب الشركة
            if (request.CompanyId.HasValue)
            {
                query = query.Where(b => b.CompanyInfoId == request.CompanyId.Value);
            }
            
            // تطبيق الفلتر حسب الحالة
            if (request.ActiveOnly.HasValue && request.ActiveOnly.Value)
            {
                query = query.Where(b => b.Status == "Active");
            }
            
            // الحصول على جميع الفروع
            var allBranches = await query.ToListAsync(cancellationToken);
            
            // تحويل إلى DTOs
            var branchDtos = _mapper.Map<List<BranchHierarchyItemDto>>(allBranches);
            
            // إضافة معلومات إضافية إذا كان مطلوباً
            if (request.IncludeDetails)
            {
                foreach (var branchDto in branchDtos)
                {
                    // إضافة عدد المستودعات
                    branchDto.WarehousesCount = await _context.Warehouses
                        .CountAsync(w => w.BranchId == branchDto.Id, cancellationToken);
                }
            }
            
            // بناء الهيكل الهرمي
            var rootBranches = branchDtos.Where(b => b.ParentBranchId == null).ToList();
            
            // تعيين المستوى للفروع الرئيسية
            foreach (var rootBranch in rootBranches)
            {
                rootBranch.Level = 1;
                BuildHierarchy(rootBranch, branchDtos, 2);
            }
            
            return rootBranches;
        }
        
        /// <summary>
        /// بناء الهيكل الهرمي للفروع بشكل تكراري
        /// </summary>
        private void BuildHierarchy(BranchHierarchyItemDto parentBranch, List<BranchHierarchyItemDto> allBranches, int level)
        {
            // البحث عن الفروع الفرعية
            var childBranches = allBranches
                .Where(b => b.ParentBranchId == parentBranch.Id)
                .ToList();
                
            // إضافة الفروع الفرعية وتحديد مستواها
            foreach (var childBranch in childBranches)
            {
                childBranch.Level = level;
                parentBranch.Children.Add(childBranch);
                
                // استدعاء تكراري للفروع الفرعية
                BuildHierarchy(childBranch, allBranches, level + 1);
            }
        }
    }
} 