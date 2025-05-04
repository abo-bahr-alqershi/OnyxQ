using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to Branch entity
/// </summary>
public sealed class BranchCreatedEvent : DomainEvent
{
    public BranchId BranchId { get; }

    public BranchCreatedEvent(BranchId branchId)
    {
        BranchId = branchId;
    }
}

public sealed class BranchUpdatedEvent : DomainEvent
{
    public BranchId BranchId { get; }

    public BranchUpdatedEvent(BranchId branchId)
    {
        BranchId = branchId;
    }
}

public sealed class BranchDeletedEvent : DomainEvent
{
    public BranchId BranchId { get; }

    public BranchDeletedEvent(BranchId branchId)
    {
        BranchId = branchId;
    }
}
}
