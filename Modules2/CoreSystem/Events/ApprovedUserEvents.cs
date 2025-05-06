using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApprovedUser entity
/// </summary>
public sealed class ApprovedUserCreatedEvent : DomainEvent
{
    public ApprovedUserId ApprovedUserId { get; }

    public ApprovedUserCreatedEvent(ApprovedUserId approveduserId)
    {
        ApprovedUserId = approveduserId;
    }
}

public sealed class ApprovedUserUpdatedEvent : DomainEvent
{
    public ApprovedUserId ApprovedUserId { get; }

    public ApprovedUserUpdatedEvent(ApprovedUserId approveduserId)
    {
        ApprovedUserId = approveduserId;
    }
}

public sealed class ApprovedUserDeletedEvent : DomainEvent
{
    public ApprovedUserId ApprovedUserId { get; }

    public ApprovedUserDeletedEvent(ApprovedUserId approveduserId)
    {
        ApprovedUserId = approveduserId;
    }
}
}
