using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditItemMaster entity
/// </summary>
public sealed class AuditItemMasterCreatedEvent : DomainEvent
{
    public AuditItemMasterId AuditItemMasterId { get; }

    public AuditItemMasterCreatedEvent(AuditItemMasterId audititemmasterId)
    {
        AuditItemMasterId = audititemmasterId;
    }
}

public sealed class AuditItemMasterUpdatedEvent : DomainEvent
{
    public AuditItemMasterId AuditItemMasterId { get; }

    public AuditItemMasterUpdatedEvent(AuditItemMasterId audititemmasterId)
    {
        AuditItemMasterId = audititemmasterId;
    }
}

public sealed class AuditItemMasterDeletedEvent : DomainEvent
{
    public AuditItemMasterId AuditItemMasterId { get; }

    public AuditItemMasterDeletedEvent(AuditItemMasterId audititemmasterId)
    {
        AuditItemMasterId = audititemmasterId;
    }
}
}
