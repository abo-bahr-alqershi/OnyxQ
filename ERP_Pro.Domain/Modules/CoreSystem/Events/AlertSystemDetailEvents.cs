using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to AlertSystemDetail entity
/// </summary>
public sealed class AlertSystemDetailCreatedEvent : DomainEvent
{
    public AlertSystemDetailId AlertSystemDetailId { get; }

    public AlertSystemDetailCreatedEvent(AlertSystemDetailId alertsystemdetailId)
    {
        AlertSystemDetailId = alertsystemdetailId;
    }
}

public sealed class AlertSystemDetailUpdatedEvent : DomainEvent
{
    public AlertSystemDetailId AlertSystemDetailId { get; }

    public AlertSystemDetailUpdatedEvent(AlertSystemDetailId alertsystemdetailId)
    {
        AlertSystemDetailId = alertsystemdetailId;
    }
}

public sealed class AlertSystemDetailDeletedEvent : DomainEvent
{
    public AlertSystemDetailId AlertSystemDetailId { get; }

    public AlertSystemDetailDeletedEvent(AlertSystemDetailId alertsystemdetailId)
    {
        AlertSystemDetailId = alertsystemdetailId;
    }
}
}
