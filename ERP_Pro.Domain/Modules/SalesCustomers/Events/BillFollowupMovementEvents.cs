using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillFollowupMovement entity
/// </summary>
public sealed class BillFollowupMovementCreatedEvent : DomainEvent
{
    public BillFollowupMovementId BillFollowupMovementId { get; }

    public BillFollowupMovementCreatedEvent(BillFollowupMovementId billfollowupmovementId)
    {
        BillFollowupMovementId = billfollowupmovementId;
    }
}

public sealed class BillFollowupMovementUpdatedEvent : DomainEvent
{
    public BillFollowupMovementId BillFollowupMovementId { get; }

    public BillFollowupMovementUpdatedEvent(BillFollowupMovementId billfollowupmovementId)
    {
        BillFollowupMovementId = billfollowupmovementId;
    }
}

public sealed class BillFollowupMovementDeletedEvent : DomainEvent
{
    public BillFollowupMovementId BillFollowupMovementId { get; }

    public BillFollowupMovementDeletedEvent(BillFollowupMovementId billfollowupmovementId)
    {
        BillFollowupMovementId = billfollowupmovementId;
    }
}
}
