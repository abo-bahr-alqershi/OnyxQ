using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to AlertDataTemp entity
/// </summary>
public sealed class AlertDataTempCreatedEvent : DomainEvent
{
    public AlertDataTempId AlertDataTempId { get; }

    public AlertDataTempCreatedEvent(AlertDataTempId alertdatatempId)
    {
        AlertDataTempId = alertdatatempId;
    }
}

public sealed class AlertDataTempUpdatedEvent : DomainEvent
{
    public AlertDataTempId AlertDataTempId { get; }

    public AlertDataTempUpdatedEvent(AlertDataTempId alertdatatempId)
    {
        AlertDataTempId = alertdatatempId;
    }
}

public sealed class AlertDataTempDeletedEvent : DomainEvent
{
    public AlertDataTempId AlertDataTempId { get; }

    public AlertDataTempDeletedEvent(AlertDataTempId alertdatatempId)
    {
        AlertDataTempId = alertdatatempId;
    }
}
}
