using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemOrder entity
/// </summary>
public sealed class ItemOrderCreatedEvent : DomainEvent
{
    public ItemOrderId ItemOrderId { get; }

    public ItemOrderCreatedEvent(ItemOrderId itemorderId)
    {
        ItemOrderId = itemorderId;
    }
}

public sealed class ItemOrderUpdatedEvent : DomainEvent
{
    public ItemOrderId ItemOrderId { get; }

    public ItemOrderUpdatedEvent(ItemOrderId itemorderId)
    {
        ItemOrderId = itemorderId;
    }
}

public sealed class ItemOrderDeletedEvent : DomainEvent
{
    public ItemOrderId ItemOrderId { get; }

    public ItemOrderDeletedEvent(ItemOrderId itemorderId)
    {
        ItemOrderId = itemorderId;
    }
}
}
