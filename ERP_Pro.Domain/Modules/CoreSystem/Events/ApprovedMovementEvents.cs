using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApprovedMovement entity
/// </summary>
public sealed class ApprovedMovementCreatedEvent : DomainEvent
{
    public ApprovedMovementId ApprovedMovementId { get; }

    public ApprovedMovementCreatedEvent(ApprovedMovementId approvedmovementId)
    {
        ApprovedMovementId = approvedmovementId;
    }
}

public sealed class ApprovedMovementUpdatedEvent : DomainEvent
{
    public ApprovedMovementId ApprovedMovementId { get; }

    public ApprovedMovementUpdatedEvent(ApprovedMovementId approvedmovementId)
    {
        ApprovedMovementId = approvedmovementId;
    }
}

public sealed class ApprovedMovementDeletedEvent : DomainEvent
{
    public ApprovedMovementId ApprovedMovementId { get; }

    public ApprovedMovementDeletedEvent(ApprovedMovementId approvedmovementId)
    {
        ApprovedMovementId = approvedmovementId;
    }
}
}
