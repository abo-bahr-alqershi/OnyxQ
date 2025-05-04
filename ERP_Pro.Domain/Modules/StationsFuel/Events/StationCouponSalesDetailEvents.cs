using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationCouponSalesDetail entity
/// </summary>
public sealed class StationCouponSalesDetailCreatedEvent : DomainEvent
{
    public StationCouponSalesDetailId StationCouponSalesDetailId { get; }

    public StationCouponSalesDetailCreatedEvent(StationCouponSalesDetailId stationcouponsalesdetailId)
    {
        StationCouponSalesDetailId = stationcouponsalesdetailId;
    }
}

public sealed class StationCouponSalesDetailUpdatedEvent : DomainEvent
{
    public StationCouponSalesDetailId StationCouponSalesDetailId { get; }

    public StationCouponSalesDetailUpdatedEvent(StationCouponSalesDetailId stationcouponsalesdetailId)
    {
        StationCouponSalesDetailId = stationcouponsalesdetailId;
    }
}

public sealed class StationCouponSalesDetailDeletedEvent : DomainEvent
{
    public StationCouponSalesDetailId StationCouponSalesDetailId { get; }

    public StationCouponSalesDetailDeletedEvent(StationCouponSalesDetailId stationcouponsalesdetailId)
    {
        StationCouponSalesDetailId = stationcouponsalesdetailId;
    }
}
}
