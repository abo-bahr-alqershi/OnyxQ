using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to Customer entity
/// </summary>
public sealed class CustomerCreatedEvent : DomainEvent
{
    public CustomerId CustomerId { get; }

    public CustomerCreatedEvent(CustomerId customerId)
    {
        CustomerId = customerId;
    }
}

public sealed class CustomerUpdatedEvent : DomainEvent
{
    public CustomerId CustomerId { get; }

    public CustomerUpdatedEvent(CustomerId customerId)
    {
        CustomerId = customerId;
    }
}

public sealed class CustomerDeletedEvent : DomainEvent
{
    public CustomerId CustomerId { get; }

    public CustomerDeletedEvent(CustomerId customerId)
    {
        CustomerId = customerId;
    }
}
}
