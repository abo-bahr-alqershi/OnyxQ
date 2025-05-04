using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemType entity
/// </summary>
public sealed class ItemTypeCreatedEvent : DomainEvent
{
    public ItemTypeId ItemTypeId { get; }

    public ItemTypeCreatedEvent(ItemTypeId itemtypeId)
    {
        ItemTypeId = itemtypeId;
    }
}

public sealed class ItemTypeUpdatedEvent : DomainEvent
{
    public ItemTypeId ItemTypeId { get; }

    public ItemTypeUpdatedEvent(ItemTypeId itemtypeId)
    {
        ItemTypeId = itemtypeId;
    }
}

public sealed class ItemTypeDeletedEvent : DomainEvent
{
    public ItemTypeId ItemTypeId { get; }

    public ItemTypeDeletedEvent(ItemTypeId itemtypeId)
    {
        ItemTypeId = itemtypeId;
    }
}
}
