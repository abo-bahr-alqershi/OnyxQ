using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemAlternative entity
/// </summary>
public sealed class ItemAlternativeCreatedEvent : DomainEvent
{
    public ItemAlternativeId ItemAlternativeId { get; }

    public ItemAlternativeCreatedEvent(ItemAlternativeId itemalternativeId)
    {
        ItemAlternativeId = itemalternativeId;
    }
}

public sealed class ItemAlternativeUpdatedEvent : DomainEvent
{
    public ItemAlternativeId ItemAlternativeId { get; }

    public ItemAlternativeUpdatedEvent(ItemAlternativeId itemalternativeId)
    {
        ItemAlternativeId = itemalternativeId;
    }
}

public sealed class ItemAlternativeDeletedEvent : DomainEvent
{
    public ItemAlternativeId ItemAlternativeId { get; }

    public ItemAlternativeDeletedEvent(ItemAlternativeId itemalternativeId)
    {
        ItemAlternativeId = itemalternativeId;
    }
}
}
