using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to WorkOrderMaster entity
/// </summary>
public sealed class WorkOrderMasterCreatedEvent : DomainEvent
{
    public WorkOrderMasterId WorkOrderMasterId { get; }

    public WorkOrderMasterCreatedEvent(WorkOrderMasterId workordermasterId)
    {
        WorkOrderMasterId = workordermasterId;
    }
}

public sealed class WorkOrderMasterUpdatedEvent : DomainEvent
{
    public WorkOrderMasterId WorkOrderMasterId { get; }

    public WorkOrderMasterUpdatedEvent(WorkOrderMasterId workordermasterId)
    {
        WorkOrderMasterId = workordermasterId;
    }
}

public sealed class WorkOrderMasterDeletedEvent : DomainEvent
{
    public WorkOrderMasterId WorkOrderMasterId { get; }

    public WorkOrderMasterDeletedEvent(WorkOrderMasterId workordermasterId)
    {
        WorkOrderMasterId = workordermasterId;
    }
}
}
