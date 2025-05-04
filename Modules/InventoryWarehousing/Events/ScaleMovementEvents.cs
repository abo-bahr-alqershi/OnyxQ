using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ScaleMovement entity
/// </summary>
public sealed class ScaleMovementCreatedEvent : DomainEvent
{
    public ScaleMovementId ScaleMovementId { get; }

    public ScaleMovementCreatedEvent(ScaleMovementId scalemovementId)
    {
        ScaleMovementId = scalemovementId;
    }
}

public sealed class ScaleMovementUpdatedEvent : DomainEvent
{
    public ScaleMovementId ScaleMovementId { get; }

    public ScaleMovementUpdatedEvent(ScaleMovementId scalemovementId)
    {
        ScaleMovementId = scalemovementId;
    }
}

public sealed class ScaleMovementDeletedEvent : DomainEvent
{
    public ScaleMovementId ScaleMovementId { get; }

    public ScaleMovementDeletedEvent(ScaleMovementId scalemovementId)
    {
        ScaleMovementId = scalemovementId;
    }
}
}
