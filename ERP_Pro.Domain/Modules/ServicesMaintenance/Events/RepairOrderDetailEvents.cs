using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ServicesMaintenance.ValueObjects;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.Events
{
/// <summary>
/// Events related to RepairOrderDetail entity
/// </summary>
public sealed class RepairOrderDetailCreatedEvent : DomainEvent
{
    public RepairOrderDetailId RepairOrderDetailId { get; }

    public RepairOrderDetailCreatedEvent(RepairOrderDetailId repairorderdetailId)
    {
        RepairOrderDetailId = repairorderdetailId;
    }
}

public sealed class RepairOrderDetailUpdatedEvent : DomainEvent
{
    public RepairOrderDetailId RepairOrderDetailId { get; }

    public RepairOrderDetailUpdatedEvent(RepairOrderDetailId repairorderdetailId)
    {
        RepairOrderDetailId = repairorderdetailId;
    }
}

public sealed class RepairOrderDetailDeletedEvent : DomainEvent
{
    public RepairOrderDetailId RepairOrderDetailId { get; }

    public RepairOrderDetailDeletedEvent(RepairOrderDetailId repairorderdetailId)
    {
        RepairOrderDetailId = repairorderdetailId;
    }
}
}
