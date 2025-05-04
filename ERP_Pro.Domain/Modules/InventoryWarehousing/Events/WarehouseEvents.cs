using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to Warehouse entity
/// </summary>
public sealed class WarehouseCreatedEvent : DomainEvent
{
    public WarehouseId WarehouseId { get; }

    public WarehouseCreatedEvent(WarehouseId warehouseId)
    {
        WarehouseId = warehouseId;
    }
}

public sealed class WarehouseUpdatedEvent : DomainEvent
{
    public WarehouseId WarehouseId { get; }

    public WarehouseUpdatedEvent(WarehouseId warehouseId)
    {
        WarehouseId = warehouseId;
    }
}

public sealed class WarehouseDeletedEvent : DomainEvent
{
    public WarehouseId WarehouseId { get; }

    public WarehouseDeletedEvent(WarehouseId warehouseId)
    {
        WarehouseId = warehouseId;
    }
}
}
