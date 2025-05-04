using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to Machine entity
/// </summary>
public sealed class MachineCreatedEvent : DomainEvent
{
    public MachineId MachineId { get; }

    public MachineCreatedEvent(MachineId machineId)
    {
        MachineId = machineId;
    }
}

public sealed class MachineUpdatedEvent : DomainEvent
{
    public MachineId MachineId { get; }

    public MachineUpdatedEvent(MachineId machineId)
    {
        MachineId = machineId;
    }
}

public sealed class MachineDeletedEvent : DomainEvent
{
    public MachineId MachineId { get; }

    public MachineDeletedEvent(MachineId machineId)
    {
        MachineId = machineId;
    }
}
}
