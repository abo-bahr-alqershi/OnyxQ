using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Queries.GetBranchById
{
    /// <summary>
    /// استعلام للحصول على معلومات فرع بواسطة المعرف
    /// </summary>
    public class GetBranchByIdQuery : IRequest<BranchDetailsDto>
    {
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// هل يتم تضمين معلومات المستودعات
        /// </summary>
        public bool IncludeWarehouses { get; set; } = true;
        
        /// <summary>
        /// هل يتم تضمين معلومات المستندات
        /// </summary>
        public bool IncludeDocuments { get; set; } = true;
        
        /// <summary>
        /// هل يتم تضمين معلومات الفروع الفرعية
        /// </summary>
        public bool IncludeChildBranches { get; set; } = true;
    }
    
    /// <summary>
    /// معالج استعلام الحصول على معلومات فرع بواسطة المعرف
    /// </summary>
    public class GetBranchByIdQueryHandler : IRequestHandler<GetBranchByIdQuery, BranchDetailsDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public GetBranchByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        /// <summary>
        /// معالجة الاستعلام
        /// </summary>
        public async Task<BranchDetailsDto> Handle(GetBranchByIdQuery request, CancellationToken cancellationToken)
        {
            // تجهيز الاستعلام الأساسي
            var query = _context.Branches.AsQueryable();
            
            // إضافة المستودعات إذا كان مطلوباً
            if (request.IncludeWarehouses)
            {
                query = query.Include(b => b.Warehouses);
            }
            
            // البحث عن الفرع
            var branch = await query
                .FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);
                
            if (branch == null)
            {
                throw new NotFoundException(nameof(Branch), request.Id);
            }
            
            // تحويل البيانات إلى DTO
            var branchDto = _mapper.Map<BranchDetailsDto>(branch);
            
            // إضافة معلومات الشركة
            var company = await _context.CompanyInfo
                .FirstOrDefaultAsync(c => c.Id == branch.CompanyInfoId, cancellationToken);
            if (company != null)
            {
                branchDto.CompanyName = company.NameAr;
            }
            
            // إضافة معلومات الفرع الأب
            if (branch.ParentBranchId.HasValue)
            {
                var parentBranch = await _context.Branches
                    .FirstOrDefaultAsync(b => b.Id == branch.ParentBranchId, cancellationToken);
                if (parentBranch != null)
                {
                    branchDto.ParentBranchName = parentBranch.NameAr;
                }
            }
            
            // إضافة معلومات الفروع الفرعية إذا كان مطلوباً
            if (request.IncludeChildBranches)
            {
                var childBranches = await _context.Branches
                    .Where(b => b.ParentBranchId == branch.Id)
                    .ToListAsync(cancellationToken);
                    
                branchDto.ChildBranches = _mapper.Map<List<BranchListItemDto>>(childBranches);
            }
            
            return branchDto;
        }
    }
} 