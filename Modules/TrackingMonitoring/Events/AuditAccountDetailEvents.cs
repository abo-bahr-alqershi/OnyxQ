using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditAccountDetail entity
/// </summary>
public sealed class AuditAccountDetailCreatedEvent : DomainEvent
{
    public AuditAccountDetailId AuditAccountDetailId { get; }

    public AuditAccountDetailCreatedEvent(AuditAccountDetailId auditaccountdetailId)
    {
        AuditAccountDetailId = auditaccountdetailId;
    }
}

public sealed class AuditAccountDetailUpdatedEvent : DomainEvent
{
    public AuditAccountDetailId AuditAccountDetailId { get; }

    public AuditAccountDetailUpdatedEvent(AuditAccountDetailId auditaccountdetailId)
    {
        AuditAccountDetailId = auditaccountdetailId;
    }
}

public sealed class AuditAccountDetailDeletedEvent : DomainEvent
{
    public AuditAccountDetailId AuditAccountDetailId { get; }

    public AuditAccountDetailDeletedEvent(AuditAccountDetailId auditaccountdetailId)
    {
        AuditAccountDetailId = auditaccountdetailId;
    }
}
}
