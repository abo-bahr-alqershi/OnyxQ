using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to DedicatedScreenDetail entity
/// </summary>
public sealed class DedicatedScreenDetailCreatedEvent : DomainEvent
{
    public DedicatedScreenDetailId DedicatedScreenDetailId { get; }

    public DedicatedScreenDetailCreatedEvent(DedicatedScreenDetailId dedicatedscreendetailId)
    {
        DedicatedScreenDetailId = dedicatedscreendetailId;
    }
}

public sealed class DedicatedScreenDetailUpdatedEvent : DomainEvent
{
    public DedicatedScreenDetailId DedicatedScreenDetailId { get; }

    public DedicatedScreenDetailUpdatedEvent(DedicatedScreenDetailId dedicatedscreendetailId)
    {
        DedicatedScreenDetailId = dedicatedscreendetailId;
    }
}

public sealed class DedicatedScreenDetailDeletedEvent : DomainEvent
{
    public DedicatedScreenDetailId DedicatedScreenDetailId { get; }

    public DedicatedScreenDetailDeletedEvent(DedicatedScreenDetailId dedicatedscreendetailId)
    {
        DedicatedScreenDetailId = dedicatedscreendetailId;
    }
}
}
