using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CouponMaster entity
/// </summary>
public sealed class CouponMasterCreatedEvent : DomainEvent
{
    public CouponMasterId CouponMasterId { get; }

    public CouponMasterCreatedEvent(CouponMasterId couponmasterId)
    {
        CouponMasterId = couponmasterId;
    }
}

public sealed class CouponMasterUpdatedEvent : DomainEvent
{
    public CouponMasterId CouponMasterId { get; }

    public CouponMasterUpdatedEvent(CouponMasterId couponmasterId)
    {
        CouponMasterId = couponmasterId;
    }
}

public sealed class CouponMasterDeletedEvent : DomainEvent
{
    public CouponMasterId CouponMasterId { get; }

    public CouponMasterDeletedEvent(CouponMasterId couponmasterId)
    {
        CouponMasterId = couponmasterId;
    }
}
}
