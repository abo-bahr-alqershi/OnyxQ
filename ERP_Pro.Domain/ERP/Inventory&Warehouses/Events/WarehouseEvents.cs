using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class WarehouseCreatedEvent : DomainEvent
    {
        public Guid WarehouseId { get; }
        public long WarehouseCode { get; }
        public string WarehouseName { get; }

        public WarehouseCreatedEvent(Guid warehouseId, long warehouseCode, string warehouseName)
        {
            WarehouseId = warehouseId;
            WarehouseCode = warehouseCode;
            WarehouseName = warehouseName;
        }
    }

    public class WarehouseUpdatedEvent : DomainEvent
    {
        public Guid WarehouseId { get; }

        public WarehouseUpdatedEvent(Guid warehouseId)
        {
            WarehouseId = warehouseId;
        }
    }

    public class WarehouseDeactivatedEvent : DomainEvent
    {
        public Guid WarehouseId { get; }

        public WarehouseDeactivatedEvent(Guid warehouseId)
        {
            WarehouseId = warehouseId;
        }
    }

    public class WarehouseActivatedEvent : DomainEvent
    {
        public Guid WarehouseId { get; }

        public WarehouseActivatedEvent(Guid warehouseId)
        {
            WarehouseId = warehouseId;
        }
    }

    public class WarehouseLocationUpdatedEvent : DomainEvent
    {
        public Guid WarehouseId { get; }

        public WarehouseLocationUpdatedEvent(Guid warehouseId)
        {
            WarehouseId = warehouseId;
        }
    }

    public class WarehouseSettingsUpdatedEvent : DomainEvent
    {
        public Guid WarehouseId { get; }

        public WarehouseSettingsUpdatedEvent(Guid warehouseId)
        {
            WarehouseId = warehouseId;
        }
    }

    public class WarehouseOperationalInfoUpdatedEvent : DomainEvent
    {
        public Guid WarehouseId { get; }

        public WarehouseOperationalInfoUpdatedEvent(Guid warehouseId)
        {
            WarehouseId = warehouseId;
        }
    }

    public class WarehouseBusinessInfoUpdatedEvent : DomainEvent
    {
        public Guid WarehouseId { get; }

        public WarehouseBusinessInfoUpdatedEvent(Guid warehouseId)
        {
            WarehouseId = warehouseId;
        }
    }
} 