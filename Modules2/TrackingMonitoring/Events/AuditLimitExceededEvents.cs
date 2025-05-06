using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditLimitExceeded entity
/// </summary>
public sealed class AuditLimitExceededCreatedEvent : DomainEvent
{
    public AuditLimitExceededId AuditLimitExceededId { get; }

    public AuditLimitExceededCreatedEvent(AuditLimitExceededId auditlimitexceededId)
    {
        AuditLimitExceededId = auditlimitexceededId;
    }
}

public sealed class AuditLimitExceededUpdatedEvent : DomainEvent
{
    public AuditLimitExceededId AuditLimitExceededId { get; }

    public AuditLimitExceededUpdatedEvent(AuditLimitExceededId auditlimitexceededId)
    {
        AuditLimitExceededId = auditlimitexceededId;
    }
}

public sealed class AuditLimitExceededDeletedEvent : DomainEvent
{
    public AuditLimitExceededId AuditLimitExceededId { get; }

    public AuditLimitExceededDeletedEvent(AuditLimitExceededId auditlimitexceededId)
    {
        AuditLimitExceededId = auditlimitexceededId;
    }
}
}
