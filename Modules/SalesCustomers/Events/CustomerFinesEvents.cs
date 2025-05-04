using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerFines entity
/// </summary>
public sealed class CustomerFinesCreatedEvent : DomainEvent
{
    public CustomerFinesId CustomerFinesId { get; }

    public CustomerFinesCreatedEvent(CustomerFinesId customerfinesId)
    {
        CustomerFinesId = customerfinesId;
    }
}

public sealed class CustomerFinesUpdatedEvent : DomainEvent
{
    public CustomerFinesId CustomerFinesId { get; }

    public CustomerFinesUpdatedEvent(CustomerFinesId customerfinesId)
    {
        CustomerFinesId = customerfinesId;
    }
}

public sealed class CustomerFinesDeletedEvent : DomainEvent
{
    public CustomerFinesId CustomerFinesId { get; }

    public CustomerFinesDeletedEvent(CustomerFinesId customerfinesId)
    {
        CustomerFinesId = customerfinesId;
    }
}
}
