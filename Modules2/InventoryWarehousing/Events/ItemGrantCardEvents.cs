using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemGrantCard entity
/// </summary>
public sealed class ItemGrantCardCreatedEvent : DomainEvent
{
    public ItemGrantCardId ItemGrantCardId { get; }

    public ItemGrantCardCreatedEvent(ItemGrantCardId itemgrantcardId)
    {
        ItemGrantCardId = itemgrantcardId;
    }
}

public sealed class ItemGrantCardUpdatedEvent : DomainEvent
{
    public ItemGrantCardId ItemGrantCardId { get; }

    public ItemGrantCardUpdatedEvent(ItemGrantCardId itemgrantcardId)
    {
        ItemGrantCardId = itemgrantcardId;
    }
}

public sealed class ItemGrantCardDeletedEvent : DomainEvent
{
    public ItemGrantCardId ItemGrantCardId { get; }

    public ItemGrantCardDeletedEvent(ItemGrantCardId itemgrantcardId)
    {
        ItemGrantCardId = itemgrantcardId;
    }
}
}
