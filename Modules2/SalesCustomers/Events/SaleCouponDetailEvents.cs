using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SaleCouponDetail entity
/// </summary>
public sealed class SaleCouponDetailCreatedEvent : DomainEvent
{
    public SaleCouponDetailId SaleCouponDetailId { get; }

    public SaleCouponDetailCreatedEvent(SaleCouponDetailId salecoupondetailId)
    {
        SaleCouponDetailId = salecoupondetailId;
    }
}

public sealed class SaleCouponDetailUpdatedEvent : DomainEvent
{
    public SaleCouponDetailId SaleCouponDetailId { get; }

    public SaleCouponDetailUpdatedEvent(SaleCouponDetailId salecoupondetailId)
    {
        SaleCouponDetailId = salecoupondetailId;
    }
}

public sealed class SaleCouponDetailDeletedEvent : DomainEvent
{
    public SaleCouponDetailId SaleCouponDetailId { get; }

    public SaleCouponDetailDeletedEvent(SaleCouponDetailId salecoupondetailId)
    {
        SaleCouponDetailId = salecoupondetailId;
    }
}
}
