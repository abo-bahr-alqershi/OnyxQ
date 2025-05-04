using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditHistory entity
/// </summary>
public sealed class AuditHistoryCreatedEvent : DomainEvent
{
    public AuditHistoryId AuditHistoryId { get; }

    public AuditHistoryCreatedEvent(AuditHistoryId audithistoryId)
    {
        AuditHistoryId = audithistoryId;
    }
}

public sealed class AuditHistoryUpdatedEvent : DomainEvent
{
    public AuditHistoryId AuditHistoryId { get; }

    public AuditHistoryUpdatedEvent(AuditHistoryId audithistoryId)
    {
        AuditHistoryId = audithistoryId;
    }
}

public sealed class AuditHistoryDeletedEvent : DomainEvent
{
    public AuditHistoryId AuditHistoryId { get; }

    public AuditHistoryDeletedEvent(AuditHistoryId audithistoryId)
    {
        AuditHistoryId = audithistoryId;
    }
}
}
