using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationCouponSalesMaster entity
/// </summary>
public sealed class StationCouponSalesMasterCreatedEvent : DomainEvent
{
    public StationCouponSalesMasterId StationCouponSalesMasterId { get; }

    public StationCouponSalesMasterCreatedEvent(StationCouponSalesMasterId stationcouponsalesmasterId)
    {
        StationCouponSalesMasterId = stationcouponsalesmasterId;
    }
}

public sealed class StationCouponSalesMasterUpdatedEvent : DomainEvent
{
    public StationCouponSalesMasterId StationCouponSalesMasterId { get; }

    public StationCouponSalesMasterUpdatedEvent(StationCouponSalesMasterId stationcouponsalesmasterId)
    {
        StationCouponSalesMasterId = stationcouponsalesmasterId;
    }
}

public sealed class StationCouponSalesMasterDeletedEvent : DomainEvent
{
    public StationCouponSalesMasterId StationCouponSalesMasterId { get; }

    public StationCouponSalesMasterDeletedEvent(StationCouponSalesMasterId stationcouponsalesmasterId)
    {
        StationCouponSalesMasterId = stationcouponsalesmasterId;
    }
}
}
