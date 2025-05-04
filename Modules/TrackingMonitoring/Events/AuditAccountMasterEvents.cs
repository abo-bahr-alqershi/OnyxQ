using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditAccountMaster entity
/// </summary>
public sealed class AuditAccountMasterCreatedEvent : DomainEvent
{
    public AuditAccountMasterId AuditAccountMasterId { get; }

    public AuditAccountMasterCreatedEvent(AuditAccountMasterId auditaccountmasterId)
    {
        AuditAccountMasterId = auditaccountmasterId;
    }
}

public sealed class AuditAccountMasterUpdatedEvent : DomainEvent
{
    public AuditAccountMasterId AuditAccountMasterId { get; }

    public AuditAccountMasterUpdatedEvent(AuditAccountMasterId auditaccountmasterId)
    {
        AuditAccountMasterId = auditaccountmasterId;
    }
}

public sealed class AuditAccountMasterDeletedEvent : DomainEvent
{
    public AuditAccountMasterId AuditAccountMasterId { get; }

    public AuditAccountMasterDeletedEvent(AuditAccountMasterId auditaccountmasterId)
    {
        AuditAccountMasterId = auditaccountmasterId;
    }
}
}
