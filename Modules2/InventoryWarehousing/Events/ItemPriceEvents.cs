using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemPrice entity
/// </summary>
public sealed class ItemPriceCreatedEvent : DomainEvent
{
    public ItemPriceId ItemPriceId { get; }

    public ItemPriceCreatedEvent(ItemPriceId itempriceId)
    {
        ItemPriceId = itempriceId;
    }
}

public sealed class ItemPriceUpdatedEvent : DomainEvent
{
    public ItemPriceId ItemPriceId { get; }

    public ItemPriceUpdatedEvent(ItemPriceId itempriceId)
    {
        ItemPriceId = itempriceId;
    }
}

public sealed class ItemPriceDeletedEvent : DomainEvent
{
    public ItemPriceId ItemPriceId { get; }

    public ItemPriceDeletedEvent(ItemPriceId itempriceId)
    {
        ItemPriceId = itempriceId;
    }
}
}
