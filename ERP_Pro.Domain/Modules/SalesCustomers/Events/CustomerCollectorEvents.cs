using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCollector entity
/// </summary>
public sealed class CustomerCollectorCreatedEvent : DomainEvent
{
    public CustomerCollectorId CustomerCollectorId { get; }

    public CustomerCollectorCreatedEvent(CustomerCollectorId customercollectorId)
    {
        CustomerCollectorId = customercollectorId;
    }
}

public sealed class CustomerCollectorUpdatedEvent : DomainEvent
{
    public CustomerCollectorId CustomerCollectorId { get; }

    public CustomerCollectorUpdatedEvent(CustomerCollectorId customercollectorId)
    {
        CustomerCollectorId = customercollectorId;
    }
}

public sealed class CustomerCollectorDeletedEvent : DomainEvent
{
    public CustomerCollectorId CustomerCollectorId { get; }

    public CustomerCollectorDeletedEvent(CustomerCollectorId customercollectorId)
    {
        CustomerCollectorId = customercollectorId;
    }
}
}
