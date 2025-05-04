using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.Events
{
/// <summary>
/// Events related to ReplicaTableMaster entity
/// </summary>
public sealed class ReplicaTableMasterCreatedEvent : DomainEvent
{
    public ReplicaTableMasterId ReplicaTableMasterId { get; }

    public ReplicaTableMasterCreatedEvent(ReplicaTableMasterId replicatablemasterId)
    {
        ReplicaTableMasterId = replicatablemasterId;
    }
}

public sealed class ReplicaTableMasterUpdatedEvent : DomainEvent
{
    public ReplicaTableMasterId ReplicaTableMasterId { get; }

    public ReplicaTableMasterUpdatedEvent(ReplicaTableMasterId replicatablemasterId)
    {
        ReplicaTableMasterId = replicatablemasterId;
    }
}

public sealed class ReplicaTableMasterDeletedEvent : DomainEvent
{
    public ReplicaTableMasterId ReplicaTableMasterId { get; }

    public ReplicaTableMasterDeletedEvent(ReplicaTableMasterId replicatablemasterId)
    {
        ReplicaTableMasterId = replicatablemasterId;
    }
}
}
