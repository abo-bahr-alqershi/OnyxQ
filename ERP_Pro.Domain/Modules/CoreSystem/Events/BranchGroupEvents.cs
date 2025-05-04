using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to BranchGroup entity
/// </summary>
public sealed class BranchGroupCreatedEvent : DomainEvent
{
    public BranchGroupId BranchGroupId { get; }

    public BranchGroupCreatedEvent(BranchGroupId branchgroupId)
    {
        BranchGroupId = branchgroupId;
    }
}

public sealed class BranchGroupUpdatedEvent : DomainEvent
{
    public BranchGroupId BranchGroupId { get; }

    public BranchGroupUpdatedEvent(BranchGroupId branchgroupId)
    {
        BranchGroupId = branchgroupId;
    }
}

public sealed class BranchGroupDeletedEvent : DomainEvent
{
    public BranchGroupId BranchGroupId { get; }

    public BranchGroupDeletedEvent(BranchGroupId branchgroupId)
    {
        BranchGroupId = branchgroupId;
    }
}
}
