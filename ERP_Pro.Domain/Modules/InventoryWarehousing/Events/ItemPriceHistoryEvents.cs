using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemPriceHistory entity
/// </summary>
public sealed class ItemPriceHistoryCreatedEvent : DomainEvent
{
    public ItemPriceHistoryId ItemPriceHistoryId { get; }

    public ItemPriceHistoryCreatedEvent(ItemPriceHistoryId itempricehistoryId)
    {
        ItemPriceHistoryId = itempricehistoryId;
    }
}

public sealed class ItemPriceHistoryUpdatedEvent : DomainEvent
{
    public ItemPriceHistoryId ItemPriceHistoryId { get; }

    public ItemPriceHistoryUpdatedEvent(ItemPriceHistoryId itempricehistoryId)
    {
        ItemPriceHistoryId = itempricehistoryId;
    }
}

public sealed class ItemPriceHistoryDeletedEvent : DomainEvent
{
    public ItemPriceHistoryId ItemPriceHistoryId { get; }

    public ItemPriceHistoryDeletedEvent(ItemPriceHistoryId itempricehistoryId)
    {
        ItemPriceHistoryId = itempricehistoryId;
    }
}
}
