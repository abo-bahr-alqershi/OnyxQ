using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to CustomerHandheldDevice entity
/// </summary>
public sealed class CustomerHandheldDeviceCreatedEvent : DomainEvent
{
    public CustomerHandheldDeviceId CustomerHandheldDeviceId { get; }

    public CustomerHandheldDeviceCreatedEvent(CustomerHandheldDeviceId customerhandhelddeviceId)
    {
        CustomerHandheldDeviceId = customerhandhelddeviceId;
    }
}

public sealed class CustomerHandheldDeviceUpdatedEvent : DomainEvent
{
    public CustomerHandheldDeviceId CustomerHandheldDeviceId { get; }

    public CustomerHandheldDeviceUpdatedEvent(CustomerHandheldDeviceId customerhandhelddeviceId)
    {
        CustomerHandheldDeviceId = customerhandhelddeviceId;
    }
}

public sealed class CustomerHandheldDeviceDeletedEvent : DomainEvent
{
    public CustomerHandheldDeviceId CustomerHandheldDeviceId { get; }

    public CustomerHandheldDeviceDeletedEvent(CustomerHandheldDeviceId customerhandhelddeviceId)
    {
        CustomerHandheldDeviceId = customerhandhelddeviceId;
    }
}
}
