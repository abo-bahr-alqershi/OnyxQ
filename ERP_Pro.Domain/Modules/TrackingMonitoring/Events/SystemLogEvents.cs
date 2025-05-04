using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to SystemLog entity
/// </summary>
public sealed class SystemLogCreatedEvent : DomainEvent
{
    public SystemLogId SystemLogId { get; }

    public SystemLogCreatedEvent(SystemLogId systemlogId)
    {
        SystemLogId = systemlogId;
    }
}

public sealed class SystemLogUpdatedEvent : DomainEvent
{
    public SystemLogId SystemLogId { get; }

    public SystemLogUpdatedEvent(SystemLogId systemlogId)
    {
        SystemLogId = systemlogId;
    }
}

public sealed class SystemLogDeletedEvent : DomainEvent
{
    public SystemLogId SystemLogId { get; }

    public SystemLogDeletedEvent(SystemLogId systemlogId)
    {
        SystemLogId = systemlogId;
    }
}
}
