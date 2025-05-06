using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditItemDetail entity
/// </summary>
public sealed class AuditItemDetailCreatedEvent : DomainEvent
{
    public AuditItemDetailId AuditItemDetailId { get; }

    public AuditItemDetailCreatedEvent(AuditItemDetailId audititemdetailId)
    {
        AuditItemDetailId = audititemdetailId;
    }
}

public sealed class AuditItemDetailUpdatedEvent : DomainEvent
{
    public AuditItemDetailId AuditItemDetailId { get; }

    public AuditItemDetailUpdatedEvent(AuditItemDetailId audititemdetailId)
    {
        AuditItemDetailId = audititemdetailId;
    }
}

public sealed class AuditItemDetailDeletedEvent : DomainEvent
{
    public AuditItemDetailId AuditItemDetailId { get; }

    public AuditItemDetailDeletedEvent(AuditItemDetailId audititemdetailId)
    {
        AuditItemDetailId = audititemdetailId;
    }
}
}
