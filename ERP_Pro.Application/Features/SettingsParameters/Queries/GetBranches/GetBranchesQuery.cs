using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Queries.GetBranches
{
    /// <summary>
    /// استعلام جلب الفروع
    /// </summary>
    public class GetBranchesQuery : IRequest<List<BranchDto>>
    {
        public Guid? CompanyId { get; set; }
        public bool? ActiveOnly { get; set; }
    }

    /// <summary>
    /// معالج استعلام جلب الفروع
    /// </summary>
    public class GetBranchesQueryHandler : IRequestHandler<GetBranchesQuery, List<BranchDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetBranchesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<BranchDto>> Handle(GetBranchesQuery request, CancellationToken cancellationToken)
        {
            IQueryable<Branch> query = _context.Branches;

            if (request.CompanyId.HasValue)
            {
                query = query.Where(x => x.CompanyInfoId == request.CompanyId.Value);
            }

            if (request.ActiveOnly.HasValue && request.ActiveOnly.Value)
            {
                query = query.Where(x => x.Status == "Active");
            }

            return await query
                .OrderBy(x => x.IsMainBranch ? 0 : 1)
                .ThenBy(x => x.Code)
                .ProjectTo<BranchDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
} 