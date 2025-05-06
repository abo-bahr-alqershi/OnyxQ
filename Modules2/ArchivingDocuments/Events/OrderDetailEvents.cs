using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to OrderDetail entity
/// </summary>
public sealed class OrderDetailCreatedEvent : DomainEvent
{
    public OrderDetailId OrderDetailId { get; }

    public OrderDetailCreatedEvent(OrderDetailId orderdetailId)
    {
        OrderDetailId = orderdetailId;
    }
}

public sealed class OrderDetailUpdatedEvent : DomainEvent
{
    public OrderDetailId OrderDetailId { get; }

    public OrderDetailUpdatedEvent(OrderDetailId orderdetailId)
    {
        OrderDetailId = orderdetailId;
    }
}

public sealed class OrderDetailDeletedEvent : DomainEvent
{
    public OrderDetailId OrderDetailId { get; }

    public OrderDetailDeletedEvent(OrderDetailId orderdetailId)
    {
        OrderDetailId = orderdetailId;
    }
}
}
