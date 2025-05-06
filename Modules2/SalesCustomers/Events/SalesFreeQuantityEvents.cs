using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesFreeQuantity entity
/// </summary>
public sealed class SalesFreeQuantityCreatedEvent : DomainEvent
{
    public SalesFreeQuantityId SalesFreeQuantityId { get; }

    public SalesFreeQuantityCreatedEvent(SalesFreeQuantityId salesfreequantityId)
    {
        SalesFreeQuantityId = salesfreequantityId;
    }
}

public sealed class SalesFreeQuantityUpdatedEvent : DomainEvent
{
    public SalesFreeQuantityId SalesFreeQuantityId { get; }

    public SalesFreeQuantityUpdatedEvent(SalesFreeQuantityId salesfreequantityId)
    {
        SalesFreeQuantityId = salesfreequantityId;
    }
}

public sealed class SalesFreeQuantityDeletedEvent : DomainEvent
{
    public SalesFreeQuantityId SalesFreeQuantityId { get; }

    public SalesFreeQuantityDeletedEvent(SalesFreeQuantityId salesfreequantityId)
    {
        SalesFreeQuantityId = salesfreequantityId;
    }
}
}
