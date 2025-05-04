using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SubCustomer entity
/// </summary>
public sealed class SubCustomerCreatedEvent : DomainEvent
{
    public SubCustomerId SubCustomerId { get; }

    public SubCustomerCreatedEvent(SubCustomerId subcustomerId)
    {
        SubCustomerId = subcustomerId;
    }
}

public sealed class SubCustomerUpdatedEvent : DomainEvent
{
    public SubCustomerId SubCustomerId { get; }

    public SubCustomerUpdatedEvent(SubCustomerId subcustomerId)
    {
        SubCustomerId = subcustomerId;
    }
}

public sealed class SubCustomerDeletedEvent : DomainEvent
{
    public SubCustomerId SubCustomerId { get; }

    public SubCustomerDeletedEvent(SubCustomerId subcustomerId)
    {
        SubCustomerId = subcustomerId;
    }
}
}
