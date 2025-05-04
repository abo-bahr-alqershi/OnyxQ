using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to DistributorCouponMaster entity
/// </summary>
public sealed class DistributorCouponMasterCreatedEvent : DomainEvent
{
    public DistributorCouponMasterId DistributorCouponMasterId { get; }

    public DistributorCouponMasterCreatedEvent(DistributorCouponMasterId distributorcouponmasterId)
    {
        DistributorCouponMasterId = distributorcouponmasterId;
    }
}

public sealed class DistributorCouponMasterUpdatedEvent : DomainEvent
{
    public DistributorCouponMasterId DistributorCouponMasterId { get; }

    public DistributorCouponMasterUpdatedEvent(DistributorCouponMasterId distributorcouponmasterId)
    {
        DistributorCouponMasterId = distributorcouponmasterId;
    }
}

public sealed class DistributorCouponMasterDeletedEvent : DomainEvent
{
    public DistributorCouponMasterId DistributorCouponMasterId { get; }

    public DistributorCouponMasterDeletedEvent(DistributorCouponMasterId distributorcouponmasterId)
    {
        DistributorCouponMasterId = distributorcouponmasterId;
    }
}
}
