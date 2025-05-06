using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to BranchUserPrivilege entity
/// </summary>
public sealed class BranchUserPrivilegeCreatedEvent : DomainEvent
{
    public BranchUserPrivilegeId BranchUserPrivilegeId { get; }

    public BranchUserPrivilegeCreatedEvent(BranchUserPrivilegeId branchuserprivilegeId)
    {
        BranchUserPrivilegeId = branchuserprivilegeId;
    }
}

public sealed class BranchUserPrivilegeUpdatedEvent : DomainEvent
{
    public BranchUserPrivilegeId BranchUserPrivilegeId { get; }

    public BranchUserPrivilegeUpdatedEvent(BranchUserPrivilegeId branchuserprivilegeId)
    {
        BranchUserPrivilegeId = branchuserprivilegeId;
    }
}

public sealed class BranchUserPrivilegeDeletedEvent : DomainEvent
{
    public BranchUserPrivilegeId BranchUserPrivilegeId { get; }

    public BranchUserPrivilegeDeletedEvent(BranchUserPrivilegeId branchuserprivilegeId)
    {
        BranchUserPrivilegeId = branchuserprivilegeId;
    }
}
}
