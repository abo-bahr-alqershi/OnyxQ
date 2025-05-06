using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Application.Features.InventoryWarehousing.Commands.UpdateWarehouse
{
    /// <summary>
    /// أمر تحديث مستودع
    /// </summary>
    public class UpdateWarehouseCommand : IRequest
    {
        public Guid Id { get; set; }
        
        // المعلومات الأساسية
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
        
        // العلاقات
        public Guid? BranchId { get; set; }
        
        // حالة المستودع
        public string Status { get; set; }
    }

    /// <summary>
    /// معالج أمر تحديث مستودع
    /// </summary>
    public class UpdateWarehouseCommandHandler : IRequestHandler<UpdateWarehouseCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public UpdateWarehouseCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
        {
            _context = context;
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public async Task<Unit> Handle(UpdateWarehouseCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Warehouses.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Warehouse), request.Id);
            }

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

            // إذا كان الطلب يتضمن تغيير الفرع التابع له المستودع
            if (request.BranchId.HasValue && entity.BranchId != request.BranchId.Value)
            {
                // حذف المستودع من الفرع القديم
                var oldBranch = await _context.Branches.FindAsync(entity.BranchId);
                if (oldBranch != null)
                {
                    oldBranch.RemoveWarehouse(entity);
                }
                
                // تغيير الفرع
                entity.ChangeBranch(request.BranchId.Value);
                
                // إضافة المستودع للفرع الجديد
                var newBranch = await _context.Branches.FindAsync(request.BranchId.Value);
                if (newBranch != null)
                {
                    newBranch.AddWarehouse(entity);
                }
            }

            // إذا كان الطلب يتضمن تغيير حالة المستودع
            if (!string.IsNullOrEmpty(request.Status) && entity.Status != request.Status)
            {
                entity.ChangeStatus(request.Status);
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
} 