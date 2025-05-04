using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationCoupon entity
/// </summary>
public sealed class StationCouponCreatedEvent : DomainEvent
{
    public StationCouponId StationCouponId { get; }

    public StationCouponCreatedEvent(StationCouponId stationcouponId)
    {
        StationCouponId = stationcouponId;
    }
}

public sealed class StationCouponUpdatedEvent : DomainEvent
{
    public StationCouponId StationCouponId { get; }

    public StationCouponUpdatedEvent(StationCouponId stationcouponId)
    {
        StationCouponId = stationcouponId;
    }
}

public sealed class StationCouponDeletedEvent : DomainEvent
{
    public StationCouponId StationCouponId { get; }

    public StationCouponDeletedEvent(StationCouponId stationcouponId)
    {
        StationCouponId = stationcouponId;
    }
}
}
