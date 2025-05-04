using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CouponTypeDetail entity
/// </summary>
public sealed class CouponTypeDetailCreatedEvent : DomainEvent
{
    public CouponTypeDetailId CouponTypeDetailId { get; }

    public CouponTypeDetailCreatedEvent(CouponTypeDetailId coupontypedetailId)
    {
        CouponTypeDetailId = coupontypedetailId;
    }
}

public sealed class CouponTypeDetailUpdatedEvent : DomainEvent
{
    public CouponTypeDetailId CouponTypeDetailId { get; }

    public CouponTypeDetailUpdatedEvent(CouponTypeDetailId coupontypedetailId)
    {
        CouponTypeDetailId = coupontypedetailId;
    }
}

public sealed class CouponTypeDetailDeletedEvent : DomainEvent
{
    public CouponTypeDetailId CouponTypeDetailId { get; }

    public CouponTypeDetailDeletedEvent(CouponTypeDetailId coupontypedetailId)
    {
        CouponTypeDetailId = coupontypedetailId;
    }
}
}
