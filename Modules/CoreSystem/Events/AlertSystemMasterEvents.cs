using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to AlertSystemMaster entity
/// </summary>
public sealed class AlertSystemMasterCreatedEvent : DomainEvent
{
    public AlertSystemMasterId AlertSystemMasterId { get; }

    public AlertSystemMasterCreatedEvent(AlertSystemMasterId alertsystemmasterId)
    {
        AlertSystemMasterId = alertsystemmasterId;
    }
}

public sealed class AlertSystemMasterUpdatedEvent : DomainEvent
{
    public AlertSystemMasterId AlertSystemMasterId { get; }

    public AlertSystemMasterUpdatedEvent(AlertSystemMasterId alertsystemmasterId)
    {
        AlertSystemMasterId = alertsystemmasterId;
    }
}

public sealed class AlertSystemMasterDeletedEvent : DomainEvent
{
    public AlertSystemMasterId AlertSystemMasterId { get; }

    public AlertSystemMasterDeletedEvent(AlertSystemMasterId alertsystemmasterId)
    {
        AlertSystemMasterId = alertsystemmasterId;
    }
}
}
