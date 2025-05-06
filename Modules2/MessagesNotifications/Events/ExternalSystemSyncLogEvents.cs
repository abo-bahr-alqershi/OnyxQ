using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to ExternalSystemSyncLog entity
/// </summary>
public sealed class ExternalSystemSyncLogCreatedEvent : DomainEvent
{
    public ExternalSystemSyncLogId ExternalSystemSyncLogId { get; }

    public ExternalSystemSyncLogCreatedEvent(ExternalSystemSyncLogId externalsystemsynclogId)
    {
        ExternalSystemSyncLogId = externalsystemsynclogId;
    }
}

public sealed class ExternalSystemSyncLogUpdatedEvent : DomainEvent
{
    public ExternalSystemSyncLogId ExternalSystemSyncLogId { get; }

    public ExternalSystemSyncLogUpdatedEvent(ExternalSystemSyncLogId externalsystemsynclogId)
    {
        ExternalSystemSyncLogId = externalsystemsynclogId;
    }
}

public sealed class ExternalSystemSyncLogDeletedEvent : DomainEvent
{
    public ExternalSystemSyncLogId ExternalSystemSyncLogId { get; }

    public ExternalSystemSyncLogDeletedEvent(ExternalSystemSyncLogId externalsystemsynclogId)
    {
        ExternalSystemSyncLogId = externalsystemsynclogId;
    }
}
}
