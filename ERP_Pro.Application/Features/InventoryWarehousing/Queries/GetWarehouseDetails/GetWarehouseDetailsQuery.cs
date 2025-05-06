using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Features.InventoryWarehousing.Queries.GetWarehouses;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Application.Features.InventoryWarehousing.Queries.GetWarehouseDetails
{
    /// <summary>
    /// استعلام جلب تفاصيل المستودع
    /// </summary>
    public class GetWarehouseDetailsQuery : IRequest<WarehouseDetailsDto>
    {
        public Guid Id { get; set; }
    }

    /// <summary>
    /// معالج استعلام جلب تفاصيل المستودع
    /// </summary>
    public class GetWarehouseDetailsQueryHandler : IRequestHandler<GetWarehouseDetailsQuery, WarehouseDetailsDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWarehouseDetailsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<WarehouseDetailsDto> Handle(GetWarehouseDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Warehouses
                .FirstOrDefaultAsync(w => w.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Warehouse), request.Id);
            }

            var warehouseDetails = _mapper.Map<WarehouseDetailsDto>(entity);

            // جلب اسم الفرع التابع له المستودع
            var branch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == entity.BranchId, cancellationToken);
            if (branch != null)
            {
                warehouseDetails.BranchName = branch.NameAr;
            }

            return warehouseDetails;
        }
    }
} 