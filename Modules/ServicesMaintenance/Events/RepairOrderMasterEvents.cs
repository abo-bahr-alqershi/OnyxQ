using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.Events
{
/// <summary>
/// Events related to RepairOrderMaster entity
/// </summary>
public sealed class RepairOrderMasterCreatedEvent : DomainEvent
{
    public RepairOrderMasterId RepairOrderMasterId { get; }

    public RepairOrderMasterCreatedEvent(RepairOrderMasterId repairordermasterId)
    {
        RepairOrderMasterId = repairordermasterId;
    }
}

public sealed class RepairOrderMasterUpdatedEvent : DomainEvent
{
    public RepairOrderMasterId RepairOrderMasterId { get; }

    public RepairOrderMasterUpdatedEvent(RepairOrderMasterId repairordermasterId)
    {
        RepairOrderMasterId = repairordermasterId;
    }
}

public sealed class RepairOrderMasterDeletedEvent : DomainEvent
{
    public RepairOrderMasterId RepairOrderMasterId { get; }

    public RepairOrderMasterDeletedEvent(RepairOrderMasterId repairordermasterId)
    {
        RepairOrderMasterId = repairordermasterId;
    }
}
}
