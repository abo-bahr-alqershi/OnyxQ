using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemStoreTemp entity
/// </summary>
public sealed class ItemStoreTempCreatedEvent : DomainEvent
{
    public ItemStoreTempId ItemStoreTempId { get; }

    public ItemStoreTempCreatedEvent(ItemStoreTempId itemstoretempId)
    {
        ItemStoreTempId = itemstoretempId;
    }
}

public sealed class ItemStoreTempUpdatedEvent : DomainEvent
{
    public ItemStoreTempId ItemStoreTempId { get; }

    public ItemStoreTempUpdatedEvent(ItemStoreTempId itemstoretempId)
    {
        ItemStoreTempId = itemstoretempId;
    }
}

public sealed class ItemStoreTempDeletedEvent : DomainEvent
{
    public ItemStoreTempId ItemStoreTempId { get; }

    public ItemStoreTempDeletedEvent(ItemStoreTempId itemstoretempId)
    {
        ItemStoreTempId = itemstoretempId;
    }
}
}
