using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationBillCoupon entity
/// </summary>
public sealed class StationBillCouponCreatedEvent : DomainEvent
{
    public StationBillCouponId StationBillCouponId { get; }

    public StationBillCouponCreatedEvent(StationBillCouponId stationbillcouponId)
    {
        StationBillCouponId = stationbillcouponId;
    }
}

public sealed class StationBillCouponUpdatedEvent : DomainEvent
{
    public StationBillCouponId StationBillCouponId { get; }

    public StationBillCouponUpdatedEvent(StationBillCouponId stationbillcouponId)
    {
        StationBillCouponId = stationbillcouponId;
    }
}

public sealed class StationBillCouponDeletedEvent : DomainEvent
{
    public StationBillCouponId StationBillCouponId { get; }

    public StationBillCouponDeletedEvent(StationBillCouponId stationbillcouponId)
    {
        StationBillCouponId = stationbillcouponId;
    }
}
}
