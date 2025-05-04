using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditItemOtherDetail entity
/// </summary>
public sealed class AuditItemOtherDetailCreatedEvent : DomainEvent
{
    public AuditItemOtherDetailId AuditItemOtherDetailId { get; }

    public AuditItemOtherDetailCreatedEvent(AuditItemOtherDetailId audititemotherdetailId)
    {
        AuditItemOtherDetailId = audititemotherdetailId;
    }
}

public sealed class AuditItemOtherDetailUpdatedEvent : DomainEvent
{
    public AuditItemOtherDetailId AuditItemOtherDetailId { get; }

    public AuditItemOtherDetailUpdatedEvent(AuditItemOtherDetailId audititemotherdetailId)
    {
        AuditItemOtherDetailId = audititemotherdetailId;
    }
}

public sealed class AuditItemOtherDetailDeletedEvent : DomainEvent
{
    public AuditItemOtherDetailId AuditItemOtherDetailId { get; }

    public AuditItemOtherDetailDeletedEvent(AuditItemOtherDetailId audititemotherdetailId)
    {
        AuditItemOtherDetailId = audititemotherdetailId;
    }
}
}
