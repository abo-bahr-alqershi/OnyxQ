using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to KimbAdjustment entity
/// </summary>
public sealed class KimbAdjustmentCreatedEvent : DomainEvent
{
    public KimbAdjustmentId KimbAdjustmentId { get; }

    public KimbAdjustmentCreatedEvent(KimbAdjustmentId kimbadjustmentId)
    {
        KimbAdjustmentId = kimbadjustmentId;
    }
}

public sealed class KimbAdjustmentUpdatedEvent : DomainEvent
{
    public KimbAdjustmentId KimbAdjustmentId { get; }

    public KimbAdjustmentUpdatedEvent(KimbAdjustmentId kimbadjustmentId)
    {
        KimbAdjustmentId = kimbadjustmentId;
    }
}

public sealed class KimbAdjustmentDeletedEvent : DomainEvent
{
    public KimbAdjustmentId KimbAdjustmentId { get; }

    public KimbAdjustmentDeletedEvent(KimbAdjustmentId kimbadjustmentId)
    {
        KimbAdjustmentId = kimbadjustmentId;
    }
}
}
