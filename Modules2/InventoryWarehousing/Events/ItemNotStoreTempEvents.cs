using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemNotStoreTemp entity
/// </summary>
public sealed class ItemNotStoreTempCreatedEvent : DomainEvent
{
    public ItemNotStoreTempId ItemNotStoreTempId { get; }

    public ItemNotStoreTempCreatedEvent(ItemNotStoreTempId itemnotstoretempId)
    {
        ItemNotStoreTempId = itemnotstoretempId;
    }
}

public sealed class ItemNotStoreTempUpdatedEvent : DomainEvent
{
    public ItemNotStoreTempId ItemNotStoreTempId { get; }

    public ItemNotStoreTempUpdatedEvent(ItemNotStoreTempId itemnotstoretempId)
    {
        ItemNotStoreTempId = itemnotstoretempId;
    }
}

public sealed class ItemNotStoreTempDeletedEvent : DomainEvent
{
    public ItemNotStoreTempId ItemNotStoreTempId { get; }

    public ItemNotStoreTempDeletedEvent(ItemNotStoreTempId itemnotstoretempId)
    {
        ItemNotStoreTempId = itemnotstoretempId;
    }
}
}
