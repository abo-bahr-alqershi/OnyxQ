using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Application.Features.InventoryWarehousing.Commands.CreateWarehouse
{
    /// <summary>
    /// أمر إنشاء مستودع جديد
    /// </summary>
    public class CreateWarehouseCommand : IRequest<Guid>
    {
        // المعلومات الأساسية
        public Guid BranchId { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string WarehouseType { get; set; }
        public decimal Area { get; set; }
        public decimal Capacity { get; set; }
        public DateTime? OperationDate { get; set; }
        
        // معلومات الموقع
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        
        // معلومات إدارية
        public string KeeperName { get; set; }
        public string KeeperPhone { get; set; }
        public string KeeperEmail { get; set; }
        public string Notes { get; set; }
    }

    /// <summary>
    /// معالج أمر إنشاء مستودع جديد
    /// </summary>
    public class CreateWarehouseCommandHandler : IRequestHandler<CreateWarehouseCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public CreateWarehouseCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
        {
            _context = context;
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public async Task<Guid> Handle(CreateWarehouseCommand request, CancellationToken cancellationToken)
        {
            var entity = Warehouse.Create(
                request.BranchId,
                request.Code,
                request.NameAr,
                request.NameEn,
                request.WarehouseType);

            // تحديث المعلومات الأساسية
            entity.UpdateBasicInfo(
                request.NameAr,
                request.NameEn,
                request.WarehouseType,
                request.Area,
                request.Capacity,
                request.OperationDate);

            // تحديث معلومات الموقع
            entity.UpdateLocationInfo(
                request.Address,
                request.City,
                request.Region,
                request.Country,
                request.PostalCode);

            // تحديث معلومات إدارية
            entity.UpdateAdministrativeInfo(
                request.KeeperName,
                request.KeeperPhone,
                request.KeeperEmail,
                request.Notes);

            // إضافة المستودع إلى الفرع
            var branch = await _context.Branches.FindAsync(request.BranchId);
            if (branch != null)
            {
                branch.AddWarehouse(entity);
            }

            // إضافة الكيان للسياق
            _context.Warehouses.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
} 