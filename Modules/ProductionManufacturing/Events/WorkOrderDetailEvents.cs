using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to WorkOrderDetail entity
/// </summary>
public sealed class WorkOrderDetailCreatedEvent : DomainEvent
{
    public WorkOrderDetailId WorkOrderDetailId { get; }

    public WorkOrderDetailCreatedEvent(WorkOrderDetailId workorderdetailId)
    {
        WorkOrderDetailId = workorderdetailId;
    }
}

public sealed class WorkOrderDetailUpdatedEvent : DomainEvent
{
    public WorkOrderDetailId WorkOrderDetailId { get; }

    public WorkOrderDetailUpdatedEvent(WorkOrderDetailId workorderdetailId)
    {
        WorkOrderDetailId = workorderdetailId;
    }
}

public sealed class WorkOrderDetailDeletedEvent : DomainEvent
{
    public WorkOrderDetailId WorkOrderDetailId { get; }

    public WorkOrderDetailDeletedEvent(WorkOrderDetailId workorderdetailId)
    {
        WorkOrderDetailId = workorderdetailId;
    }
}
}
