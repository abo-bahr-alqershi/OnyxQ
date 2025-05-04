using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CouponDetail entity
/// </summary>
public sealed class CouponDetailCreatedEvent : DomainEvent
{
    public CouponDetailId CouponDetailId { get; }

    public CouponDetailCreatedEvent(CouponDetailId coupondetailId)
    {
        CouponDetailId = coupondetailId;
    }
}

public sealed class CouponDetailUpdatedEvent : DomainEvent
{
    public CouponDetailId CouponDetailId { get; }

    public CouponDetailUpdatedEvent(CouponDetailId coupondetailId)
    {
        CouponDetailId = coupondetailId;
    }
}

public sealed class CouponDetailDeletedEvent : DomainEvent
{
    public CouponDetailId CouponDetailId { get; }

    public CouponDetailDeletedEvent(CouponDetailId coupondetailId)
    {
        CouponDetailId = coupondetailId;
    }
}
}
