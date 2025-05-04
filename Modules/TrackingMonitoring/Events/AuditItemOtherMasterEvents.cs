using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditItemOtherMaster entity
/// </summary>
public sealed class AuditItemOtherMasterCreatedEvent : DomainEvent
{
    public AuditItemOtherMasterId AuditItemOtherMasterId { get; }

    public AuditItemOtherMasterCreatedEvent(AuditItemOtherMasterId audititemothermasterId)
    {
        AuditItemOtherMasterId = audititemothermasterId;
    }
}

public sealed class AuditItemOtherMasterUpdatedEvent : DomainEvent
{
    public AuditItemOtherMasterId AuditItemOtherMasterId { get; }

    public AuditItemOtherMasterUpdatedEvent(AuditItemOtherMasterId audititemothermasterId)
    {
        AuditItemOtherMasterId = audititemothermasterId;
    }
}

public sealed class AuditItemOtherMasterDeletedEvent : DomainEvent
{
    public AuditItemOtherMasterId AuditItemOtherMasterId { get; }

    public AuditItemOtherMasterDeletedEvent(AuditItemOtherMasterId audititemothermasterId)
    {
        AuditItemOtherMasterId = audititemothermasterId;
    }
}
}
