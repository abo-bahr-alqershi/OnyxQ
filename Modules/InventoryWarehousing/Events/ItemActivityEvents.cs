using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemActivity entity
/// </summary>
public sealed class ItemActivityCreatedEvent : DomainEvent
{
    public ItemActivityId ItemActivityId { get; }

    public ItemActivityCreatedEvent(ItemActivityId itemactivityId)
    {
        ItemActivityId = itemactivityId;
    }
}

public sealed class ItemActivityUpdatedEvent : DomainEvent
{
    public ItemActivityId ItemActivityId { get; }

    public ItemActivityUpdatedEvent(ItemActivityId itemactivityId)
    {
        ItemActivityId = itemactivityId;
    }
}

public sealed class ItemActivityDeletedEvent : DomainEvent
{
    public ItemActivityId ItemActivityId { get; }

    public ItemActivityDeletedEvent(ItemActivityId itemactivityId)
    {
        ItemActivityId = itemactivityId;
    }
}
}
