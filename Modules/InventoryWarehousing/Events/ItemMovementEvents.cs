using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemMovement entity
/// </summary>
public sealed class ItemMovementCreatedEvent : DomainEvent
{
    public ItemMovementId ItemMovementId { get; }

    public ItemMovementCreatedEvent(ItemMovementId itemmovementId)
    {
        ItemMovementId = itemmovementId;
    }
}

public sealed class ItemMovementUpdatedEvent : DomainEvent
{
    public ItemMovementId ItemMovementId { get; }

    public ItemMovementUpdatedEvent(ItemMovementId itemmovementId)
    {
        ItemMovementId = itemmovementId;
    }
}

public sealed class ItemMovementDeletedEvent : DomainEvent
{
    public ItemMovementId ItemMovementId { get; }

    public ItemMovementDeletedEvent(ItemMovementId itemmovementId)
    {
        ItemMovementId = itemmovementId;
    }
}
}
