using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Features.SettingsParameters.Queries.GetBranches;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Queries.GetBranchDetails
{
    /// <summary>
    /// استعلام جلب تفاصيل الفرع
    /// </summary>
    public class GetBranchDetailsQuery : IRequest<BranchDetailsDto>
    {
        public Guid Id { get; set; }
    }

    /// <summary>
    /// معالج استعلام جلب تفاصيل الفرع
    /// </summary>
    public class GetBranchDetailsQueryHandler : IRequestHandler<GetBranchDetailsQuery, BranchDetailsDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetBranchDetailsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BranchDetailsDto> Handle(GetBranchDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Branches
                .Include(b => b.Warehouses)
                .FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Branch), request.Id);
            }

            var branchDetails = _mapper.Map<BranchDetailsDto>(entity);

            // إذا كان الفرع له فرع أب، جلب اسم الفرع الأب
            if (entity.ParentBranchId.HasValue)
            {
                var parentBranch = await _context.Branches
                    .FirstOrDefaultAsync(b => b.Id == entity.ParentBranchId.Value, cancellationToken);
                if (parentBranch != null)
                {
                    branchDetails.ParentBranchName = parentBranch.NameAr;
                }
            }

            return branchDetails;
        }
    }
} 