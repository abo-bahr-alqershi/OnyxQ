using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesDiscount entity
/// </summary>
public sealed class SalesDiscountCreatedEvent : DomainEvent
{
    public SalesDiscountId SalesDiscountId { get; }

    public SalesDiscountCreatedEvent(SalesDiscountId salesdiscountId)
    {
        SalesDiscountId = salesdiscountId;
    }
}

public sealed class SalesDiscountUpdatedEvent : DomainEvent
{
    public SalesDiscountId SalesDiscountId { get; }

    public SalesDiscountUpdatedEvent(SalesDiscountId salesdiscountId)
    {
        SalesDiscountId = salesdiscountId;
    }
}

public sealed class SalesDiscountDeletedEvent : DomainEvent
{
    public SalesDiscountId SalesDiscountId { get; }

    public SalesDiscountDeletedEvent(SalesDiscountId salesdiscountId)
    {
        SalesDiscountId = salesdiscountId;
    }
}
}
