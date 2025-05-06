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
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Application.Features.InventoryWarehousing.Queries.GetWarehouses
{
    /// <summary>
    /// استعلام جلب المستودعات
    /// </summary>
    public class GetWarehousesQuery : IRequest<List<WarehouseDto>>
    {
        public Guid? BranchId { get; set; }
        public bool? ActiveOnly { get; set; }
    }

    /// <summary>
    /// معالج استعلام جلب المستودعات
    /// </summary>
    public class GetWarehousesQueryHandler : IRequestHandler<GetWarehousesQuery, List<WarehouseDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWarehousesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<WarehouseDto>> Handle(GetWarehousesQuery request, CancellationToken cancellationToken)
        {
            IQueryable<Warehouse> query = _context.Warehouses;

            if (request.BranchId.HasValue)
            {
                query = query.Where(x => x.BranchId == request.BranchId.Value);
            }

            if (request.ActiveOnly.HasValue && request.ActiveOnly.Value)
            {
                query = query.Where(x => x.Status == "Active");
            }

            return await query
                .OrderBy(x => x.Code)
                .ProjectTo<WarehouseDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
} 