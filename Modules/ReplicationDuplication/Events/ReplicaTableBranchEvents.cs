using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.Events
{
/// <summary>
/// Events related to ReplicaTableBranch entity
/// </summary>
public sealed class ReplicaTableBranchCreatedEvent : DomainEvent
{
    public ReplicaTableBranchId ReplicaTableBranchId { get; }

    public ReplicaTableBranchCreatedEvent(ReplicaTableBranchId replicatablebranchId)
    {
        ReplicaTableBranchId = replicatablebranchId;
    }
}

public sealed class ReplicaTableBranchUpdatedEvent : DomainEvent
{
    public ReplicaTableBranchId ReplicaTableBranchId { get; }

    public ReplicaTableBranchUpdatedEvent(ReplicaTableBranchId replicatablebranchId)
    {
        ReplicaTableBranchId = replicatablebranchId;
    }
}

public sealed class ReplicaTableBranchDeletedEvent : DomainEvent
{
    public ReplicaTableBranchId ReplicaTableBranchId { get; }

    public ReplicaTableBranchDeletedEvent(ReplicaTableBranchId replicatablebranchId)
    {
        ReplicaTableBranchId = replicatablebranchId;
    }
}
}
