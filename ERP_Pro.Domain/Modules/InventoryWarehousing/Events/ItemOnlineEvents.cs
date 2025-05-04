using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemOnline entity
/// </summary>
public sealed class ItemOnlineCreatedEvent : DomainEvent
{
    public ItemOnlineId ItemOnlineId { get; }

    public ItemOnlineCreatedEvent(ItemOnlineId itemonlineId)
    {
        ItemOnlineId = itemonlineId;
    }
}

public sealed class ItemOnlineUpdatedEvent : DomainEvent
{
    public ItemOnlineId ItemOnlineId { get; }

    public ItemOnlineUpdatedEvent(ItemOnlineId itemonlineId)
    {
        ItemOnlineId = itemonlineId;
    }
}

public sealed class ItemOnlineDeletedEvent : DomainEvent
{
    public ItemOnlineId ItemOnlineId { get; }

    public ItemOnlineDeletedEvent(ItemOnlineId itemonlineId)
    {
        ItemOnlineId = itemonlineId;
    }
}
}
