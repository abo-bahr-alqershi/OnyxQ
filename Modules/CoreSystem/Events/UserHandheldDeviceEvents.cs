using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to UserHandheldDevice entity
/// </summary>
public sealed class UserHandheldDeviceCreatedEvent : DomainEvent
{
    public UserHandheldDeviceId UserHandheldDeviceId { get; }

    public UserHandheldDeviceCreatedEvent(UserHandheldDeviceId userhandhelddeviceId)
    {
        UserHandheldDeviceId = userhandhelddeviceId;
    }
}

public sealed class UserHandheldDeviceUpdatedEvent : DomainEvent
{
    public UserHandheldDeviceId UserHandheldDeviceId { get; }

    public UserHandheldDeviceUpdatedEvent(UserHandheldDeviceId userhandhelddeviceId)
    {
        UserHandheldDeviceId = userhandhelddeviceId;
    }
}

public sealed class UserHandheldDeviceDeletedEvent : DomainEvent
{
    public UserHandheldDeviceId UserHandheldDeviceId { get; }

    public UserHandheldDeviceDeletedEvent(UserHandheldDeviceId userhandhelddeviceId)
    {
        UserHandheldDeviceId = userhandhelddeviceId;
    }
}
}
