using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillCoupon entity
/// </summary>
public sealed class BillCouponCreatedEvent : DomainEvent
{
    public BillCouponId BillCouponId { get; }

    public BillCouponCreatedEvent(BillCouponId billcouponId)
    {
        BillCouponId = billcouponId;
    }
}

public sealed class BillCouponUpdatedEvent : DomainEvent
{
    public BillCouponId BillCouponId { get; }

    public BillCouponUpdatedEvent(BillCouponId billcouponId)
    {
        BillCouponId = billcouponId;
    }
}

public sealed class BillCouponDeletedEvent : DomainEvent
{
    public BillCouponId BillCouponId { get; }

    public BillCouponDeletedEvent(BillCouponId billcouponId)
    {
        BillCouponId = billcouponId;
    }
}
}
