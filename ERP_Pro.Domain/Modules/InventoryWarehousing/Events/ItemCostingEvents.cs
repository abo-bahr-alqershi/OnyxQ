using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemCosting entity
/// </summary>
public sealed class ItemCostingCreatedEvent : DomainEvent
{
    public ItemCostingId ItemCostingId { get; }

    public ItemCostingCreatedEvent(ItemCostingId itemcostingId)
    {
        ItemCostingId = itemcostingId;
    }
}

public sealed class ItemCostingUpdatedEvent : DomainEvent
{
    public ItemCostingId ItemCostingId { get; }

    public ItemCostingUpdatedEvent(ItemCostingId itemcostingId)
    {
        ItemCostingId = itemcostingId;
    }
}

public sealed class ItemCostingDeletedEvent : DomainEvent
{
    public ItemCostingId ItemCostingId { get; }

    public ItemCostingDeletedEvent(ItemCostingId itemcostingId)
    {
        ItemCostingId = itemcostingId;
    }
}
}
