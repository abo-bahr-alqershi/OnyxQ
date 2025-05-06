using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryType entity
/// </summary>
public sealed class InventoryTypeCreatedEvent : DomainEvent
{
    public InventoryTypeId InventoryTypeId { get; }

    public InventoryTypeCreatedEvent(InventoryTypeId inventorytypeId)
    {
        InventoryTypeId = inventorytypeId;
    }
}

public sealed class InventoryTypeUpdatedEvent : DomainEvent
{
    public InventoryTypeId InventoryTypeId { get; }

    public InventoryTypeUpdatedEvent(InventoryTypeId inventorytypeId)
    {
        InventoryTypeId = inventorytypeId;
    }
}

public sealed class InventoryTypeDeletedEvent : DomainEvent
{
    public InventoryTypeId InventoryTypeId { get; }

    public InventoryTypeDeletedEvent(InventoryTypeId inventorytypeId)
    {
        InventoryTypeId = inventorytypeId;
    }
}
}
