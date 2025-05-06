using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to Audit entity
/// </summary>
public sealed class AuditCreatedEvent : DomainEvent
{
    public AuditId AuditId { get; }

    public AuditCreatedEvent(AuditId auditId)
    {
        AuditId = auditId;
    }
}

public sealed class AuditUpdatedEvent : DomainEvent
{
    public AuditId AuditId { get; }

    public AuditUpdatedEvent(AuditId auditId)
    {
        AuditId = auditId;
    }
}

public sealed class AuditDeletedEvent : DomainEvent
{
    public AuditId AuditId { get; }

    public AuditDeletedEvent(AuditId auditId)
    {
        AuditId = auditId;
    }
}
}
