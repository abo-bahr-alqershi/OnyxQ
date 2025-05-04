using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemPeriodicCost entity
/// </summary>
public sealed class ItemPeriodicCostCreatedEvent : DomainEvent
{
    public ItemPeriodicCostId ItemPeriodicCostId { get; }

    public ItemPeriodicCostCreatedEvent(ItemPeriodicCostId itemperiodiccostId)
    {
        ItemPeriodicCostId = itemperiodiccostId;
    }
}

public sealed class ItemPeriodicCostUpdatedEvent : DomainEvent
{
    public ItemPeriodicCostId ItemPeriodicCostId { get; }

    public ItemPeriodicCostUpdatedEvent(ItemPeriodicCostId itemperiodiccostId)
    {
        ItemPeriodicCostId = itemperiodiccostId;
    }
}

public sealed class ItemPeriodicCostDeletedEvent : DomainEvent
{
    public ItemPeriodicCostId ItemPeriodicCostId { get; }

    public ItemPeriodicCostDeletedEvent(ItemPeriodicCostId itemperiodiccostId)
    {
        ItemPeriodicCostId = itemperiodiccostId;
    }
}
}
