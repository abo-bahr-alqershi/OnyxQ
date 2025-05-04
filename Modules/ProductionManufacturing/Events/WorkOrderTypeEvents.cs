using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to WorkOrderType entity
/// </summary>
public sealed class WorkOrderTypeCreatedEvent : DomainEvent
{
    public WorkOrderTypeId WorkOrderTypeId { get; }

    public WorkOrderTypeCreatedEvent(WorkOrderTypeId workordertypeId)
    {
        WorkOrderTypeId = workordertypeId;
    }
}

public sealed class WorkOrderTypeUpdatedEvent : DomainEvent
{
    public WorkOrderTypeId WorkOrderTypeId { get; }

    public WorkOrderTypeUpdatedEvent(WorkOrderTypeId workordertypeId)
    {
        WorkOrderTypeId = workordertypeId;
    }
}

public sealed class WorkOrderTypeDeletedEvent : DomainEvent
{
    public WorkOrderTypeId WorkOrderTypeId { get; }

    public WorkOrderTypeDeletedEvent(WorkOrderTypeId workordertypeId)
    {
        WorkOrderTypeId = workordertypeId;
    }
}
}
