using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerDevices entity
/// </summary>
public sealed class CustomerDevicesCreatedEvent : DomainEvent
{
    public CustomerDevicesId CustomerDevicesId { get; }

    public CustomerDevicesCreatedEvent(CustomerDevicesId customerdevicesId)
    {
        CustomerDevicesId = customerdevicesId;
    }
}

public sealed class CustomerDevicesUpdatedEvent : DomainEvent
{
    public CustomerDevicesId CustomerDevicesId { get; }

    public CustomerDevicesUpdatedEvent(CustomerDevicesId customerdevicesId)
    {
        CustomerDevicesId = customerdevicesId;
    }
}

public sealed class CustomerDevicesDeletedEvent : DomainEvent
{
    public CustomerDevicesId CustomerDevicesId { get; }

    public CustomerDevicesDeletedEvent(CustomerDevicesId customerdevicesId)
    {
        CustomerDevicesId = customerdevicesId;
    }
}
}
