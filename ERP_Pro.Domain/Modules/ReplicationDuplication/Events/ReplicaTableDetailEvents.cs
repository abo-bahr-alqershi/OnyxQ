using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ReplicationDuplication.ValueObjects;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.Events
{
/// <summary>
/// Events related to ReplicaTableDetail entity
/// </summary>
public sealed class ReplicaTableDetailCreatedEvent : DomainEvent
{
    public ReplicaTableDetailId ReplicaTableDetailId { get; }

    public ReplicaTableDetailCreatedEvent(ReplicaTableDetailId replicatabledetailId)
    {
        ReplicaTableDetailId = replicatabledetailId;
    }
}

public sealed class ReplicaTableDetailUpdatedEvent : DomainEvent
{
    public ReplicaTableDetailId ReplicaTableDetailId { get; }

    public ReplicaTableDetailUpdatedEvent(ReplicaTableDetailId replicatabledetailId)
    {
        ReplicaTableDetailId = replicatabledetailId;
    }
}

public sealed class ReplicaTableDetailDeletedEvent : DomainEvent
{
    public ReplicaTableDetailId ReplicaTableDetailId { get; }

    public ReplicaTableDetailDeletedEvent(ReplicaTableDetailId replicatabledetailId)
    {
        ReplicaTableDetailId = replicatabledetailId;
    }
}
}
