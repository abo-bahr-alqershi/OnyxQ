using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerRequest entity
/// </summary>
public sealed class CustomerRequestCreatedEvent : DomainEvent
{
    public CustomerRequestId CustomerRequestId { get; }

    public CustomerRequestCreatedEvent(CustomerRequestId customerrequestId)
    {
        CustomerRequestId = customerrequestId;
    }
}

public sealed class CustomerRequestUpdatedEvent : DomainEvent
{
    public CustomerRequestId CustomerRequestId { get; }

    public CustomerRequestUpdatedEvent(CustomerRequestId customerrequestId)
    {
        CustomerRequestId = customerrequestId;
    }
}

public sealed class CustomerRequestDeletedEvent : DomainEvent
{
    public CustomerRequestId CustomerRequestId { get; }

    public CustomerRequestDeletedEvent(CustomerRequestId customerrequestId)
    {
        CustomerRequestId = customerrequestId;
    }
}
}
