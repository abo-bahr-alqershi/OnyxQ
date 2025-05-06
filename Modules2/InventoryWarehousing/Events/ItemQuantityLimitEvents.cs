using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemQuantityLimit entity
/// </summary>
public sealed class ItemQuantityLimitCreatedEvent : DomainEvent
{
    public ItemQuantityLimitId ItemQuantityLimitId { get; }

    public ItemQuantityLimitCreatedEvent(ItemQuantityLimitId itemquantitylimitId)
    {
        ItemQuantityLimitId = itemquantitylimitId;
    }
}

public sealed class ItemQuantityLimitUpdatedEvent : DomainEvent
{
    public ItemQuantityLimitId ItemQuantityLimitId { get; }

    public ItemQuantityLimitUpdatedEvent(ItemQuantityLimitId itemquantitylimitId)
    {
        ItemQuantityLimitId = itemquantitylimitId;
    }
}

public sealed class ItemQuantityLimitDeletedEvent : DomainEvent
{
    public ItemQuantityLimitId ItemQuantityLimitId { get; }

    public ItemQuantityLimitDeletedEvent(ItemQuantityLimitId itemquantitylimitId)
    {
        ItemQuantityLimitId = itemquantitylimitId;
    }
}
}
