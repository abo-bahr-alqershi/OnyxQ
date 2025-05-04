using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to ItemAgingTemp entity
/// </summary>
public sealed class ItemAgingTempCreatedEvent : DomainEvent
{
    public ItemAgingTempId ItemAgingTempId { get; }

    public ItemAgingTempCreatedEvent(ItemAgingTempId itemagingtempId)
    {
        ItemAgingTempId = itemagingtempId;
    }
}

public sealed class ItemAgingTempUpdatedEvent : DomainEvent
{
    public ItemAgingTempId ItemAgingTempId { get; }

    public ItemAgingTempUpdatedEvent(ItemAgingTempId itemagingtempId)
    {
        ItemAgingTempId = itemagingtempId;
    }
}

public sealed class ItemAgingTempDeletedEvent : DomainEvent
{
    public ItemAgingTempId ItemAgingTempId { get; }

    public ItemAgingTempDeletedEvent(ItemAgingTempId itemagingtempId)
    {
        ItemAgingTempId = itemagingtempId;
    }
}
}
