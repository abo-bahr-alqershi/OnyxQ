using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemCollectionTemp entity
/// </summary>
public sealed class ItemCollectionTempCreatedEvent : DomainEvent
{
    public ItemCollectionTempId ItemCollectionTempId { get; }

    public ItemCollectionTempCreatedEvent(ItemCollectionTempId itemcollectiontempId)
    {
        ItemCollectionTempId = itemcollectiontempId;
    }
}

public sealed class ItemCollectionTempUpdatedEvent : DomainEvent
{
    public ItemCollectionTempId ItemCollectionTempId { get; }

    public ItemCollectionTempUpdatedEvent(ItemCollectionTempId itemcollectiontempId)
    {
        ItemCollectionTempId = itemcollectiontempId;
    }
}

public sealed class ItemCollectionTempDeletedEvent : DomainEvent
{
    public ItemCollectionTempId ItemCollectionTempId { get; }

    public ItemCollectionTempDeletedEvent(ItemCollectionTempId itemcollectiontempId)
    {
        ItemCollectionTempId = itemcollectiontempId;
    }
}
}
