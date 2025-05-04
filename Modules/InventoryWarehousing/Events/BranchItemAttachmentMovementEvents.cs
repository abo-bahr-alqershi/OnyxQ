using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BranchItemAttachmentMovement entity
/// </summary>
public sealed class BranchItemAttachmentMovementCreatedEvent : DomainEvent
{
    public BranchItemAttachmentMovementId BranchItemAttachmentMovementId { get; }

    public BranchItemAttachmentMovementCreatedEvent(BranchItemAttachmentMovementId branchitemattachmentmovementId)
    {
        BranchItemAttachmentMovementId = branchitemattachmentmovementId;
    }
}

public sealed class BranchItemAttachmentMovementUpdatedEvent : DomainEvent
{
    public BranchItemAttachmentMovementId BranchItemAttachmentMovementId { get; }

    public BranchItemAttachmentMovementUpdatedEvent(BranchItemAttachmentMovementId branchitemattachmentmovementId)
    {
        BranchItemAttachmentMovementId = branchitemattachmentmovementId;
    }
}

public sealed class BranchItemAttachmentMovementDeletedEvent : DomainEvent
{
    public BranchItemAttachmentMovementId BranchItemAttachmentMovementId { get; }

    public BranchItemAttachmentMovementDeletedEvent(BranchItemAttachmentMovementId branchitemattachmentmovementId)
    {
        BranchItemAttachmentMovementId = branchitemattachmentmovementId;
    }
}
}
