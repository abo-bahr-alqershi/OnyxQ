using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemDetail entity
/// </summary>
public sealed class ItemDetailCreatedEvent : DomainEvent
{
    public ItemDetailId ItemDetailId { get; }

    public ItemDetailCreatedEvent(ItemDetailId itemdetailId)
    {
        ItemDetailId = itemdetailId;
    }
}

public sealed class ItemDetailUpdatedEvent : DomainEvent
{
    public ItemDetailId ItemDetailId { get; }

    public ItemDetailUpdatedEvent(ItemDetailId itemdetailId)
    {
        ItemDetailId = itemdetailId;
    }
}

public sealed class ItemDetailDeletedEvent : DomainEvent
{
    public ItemDetailId ItemDetailId { get; }

    public ItemDetailDeletedEvent(ItemDetailId itemdetailId)
    {
        ItemDetailId = itemdetailId;
    }
}
}
