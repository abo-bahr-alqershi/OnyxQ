using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SaleCouponMaster entity
/// </summary>
public sealed class SaleCouponMasterCreatedEvent : DomainEvent
{
    public SaleCouponMasterId SaleCouponMasterId { get; }

    public SaleCouponMasterCreatedEvent(SaleCouponMasterId salecouponmasterId)
    {
        SaleCouponMasterId = salecouponmasterId;
    }
}

public sealed class SaleCouponMasterUpdatedEvent : DomainEvent
{
    public SaleCouponMasterId SaleCouponMasterId { get; }

    public SaleCouponMasterUpdatedEvent(SaleCouponMasterId salecouponmasterId)
    {
        SaleCouponMasterId = salecouponmasterId;
    }
}

public sealed class SaleCouponMasterDeletedEvent : DomainEvent
{
    public SaleCouponMasterId SaleCouponMasterId { get; }

    public SaleCouponMasterDeletedEvent(SaleCouponMasterId salecouponmasterId)
    {
        SaleCouponMasterId = salecouponmasterId;
    }
}
}
