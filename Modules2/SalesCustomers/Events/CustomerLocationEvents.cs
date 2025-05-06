using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerLocation entity
/// </summary>
public sealed class CustomerLocationCreatedEvent : DomainEvent
{
    public CustomerLocationId CustomerLocationId { get; }

    public CustomerLocationCreatedEvent(CustomerLocationId customerlocationId)
    {
        CustomerLocationId = customerlocationId;
    }
}

public sealed class CustomerLocationUpdatedEvent : DomainEvent
{
    public CustomerLocationId CustomerLocationId { get; }

    public CustomerLocationUpdatedEvent(CustomerLocationId customerlocationId)
    {
        CustomerLocationId = customerlocationId;
    }
}

public sealed class CustomerLocationDeletedEvent : DomainEvent
{
    public CustomerLocationId CustomerLocationId { get; }

    public CustomerLocationDeletedEvent(CustomerLocationId customerlocationId)
    {
        CustomerLocationId = customerlocationId;
    }
}
}
