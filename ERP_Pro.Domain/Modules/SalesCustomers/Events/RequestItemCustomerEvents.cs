using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to RequestItemCustomer entity
/// </summary>
public sealed class RequestItemCustomerCreatedEvent : DomainEvent
{
    public RequestItemCustomerId RequestItemCustomerId { get; }

    public RequestItemCustomerCreatedEvent(RequestItemCustomerId requestitemcustomerId)
    {
        RequestItemCustomerId = requestitemcustomerId;
    }
}

public sealed class RequestItemCustomerUpdatedEvent : DomainEvent
{
    public RequestItemCustomerId RequestItemCustomerId { get; }

    public RequestItemCustomerUpdatedEvent(RequestItemCustomerId requestitemcustomerId)
    {
        RequestItemCustomerId = requestitemcustomerId;
    }
}

public sealed class RequestItemCustomerDeletedEvent : DomainEvent
{
    public RequestItemCustomerId RequestItemCustomerId { get; }

    public RequestItemCustomerDeletedEvent(RequestItemCustomerId requestitemcustomerId)
    {
        RequestItemCustomerId = requestitemcustomerId;
    }
}
}
