using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CouponTypeMaster entity
/// </summary>
public sealed class CouponTypeMasterCreatedEvent : DomainEvent
{
    public CouponTypeMasterId CouponTypeMasterId { get; }

    public CouponTypeMasterCreatedEvent(CouponTypeMasterId coupontypemasterId)
    {
        CouponTypeMasterId = coupontypemasterId;
    }
}

public sealed class CouponTypeMasterUpdatedEvent : DomainEvent
{
    public CouponTypeMasterId CouponTypeMasterId { get; }

    public CouponTypeMasterUpdatedEvent(CouponTypeMasterId coupontypemasterId)
    {
        CouponTypeMasterId = coupontypemasterId;
    }
}

public sealed class CouponTypeMasterDeletedEvent : DomainEvent
{
    public CouponTypeMasterId CouponTypeMasterId { get; }

    public CouponTypeMasterDeletedEvent(CouponTypeMasterId coupontypemasterId)
    {
        CouponTypeMasterId = coupontypemasterId;
    }
}
}
