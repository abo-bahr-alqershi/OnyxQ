using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to DistributorCouponDetail entity
/// </summary>
public sealed class DistributorCouponDetailCreatedEvent : DomainEvent
{
    public DistributorCouponDetailId DistributorCouponDetailId { get; }

    public DistributorCouponDetailCreatedEvent(DistributorCouponDetailId distributorcoupondetailId)
    {
        DistributorCouponDetailId = distributorcoupondetailId;
    }
}

public sealed class DistributorCouponDetailUpdatedEvent : DomainEvent
{
    public DistributorCouponDetailId DistributorCouponDetailId { get; }

    public DistributorCouponDetailUpdatedEvent(DistributorCouponDetailId distributorcoupondetailId)
    {
        DistributorCouponDetailId = distributorcoupondetailId;
    }
}

public sealed class DistributorCouponDetailDeletedEvent : DomainEvent
{
    public DistributorCouponDetailId DistributorCouponDetailId { get; }

    public DistributorCouponDetailDeletedEvent(DistributorCouponDetailId distributorcoupondetailId)
    {
        DistributorCouponDetailId = distributorcoupondetailId;
    }
}
}
