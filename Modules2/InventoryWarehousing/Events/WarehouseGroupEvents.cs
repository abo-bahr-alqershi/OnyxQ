using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to WarehouseGroup entity
/// </summary>
public sealed class WarehouseGroupCreatedEvent : DomainEvent
{
    public WarehouseGroupId WarehouseGroupId { get; }

    public WarehouseGroupCreatedEvent(WarehouseGroupId warehousegroupId)
    {
        WarehouseGroupId = warehousegroupId;
    }
}

public sealed class WarehouseGroupUpdatedEvent : DomainEvent
{
    public WarehouseGroupId WarehouseGroupId { get; }

    public WarehouseGroupUpdatedEvent(WarehouseGroupId warehousegroupId)
    {
        WarehouseGroupId = warehousegroupId;
    }
}

public sealed class WarehouseGroupDeletedEvent : DomainEvent
{
    public WarehouseGroupId WarehouseGroupId { get; }

    public WarehouseGroupDeletedEvent(WarehouseGroupId warehousegroupId)
    {
        WarehouseGroupId = warehousegroupId;
    }
}
}
