using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryMachineSubDetail entity
/// </summary>
public sealed class InventoryMachineSubDetailCreatedEvent : DomainEvent
{
    public InventoryMachineSubDetailId InventoryMachineSubDetailId { get; }

    public InventoryMachineSubDetailCreatedEvent(InventoryMachineSubDetailId inventorymachinesubdetailId)
    {
        InventoryMachineSubDetailId = inventorymachinesubdetailId;
    }
}

public sealed class InventoryMachineSubDetailUpdatedEvent : DomainEvent
{
    public InventoryMachineSubDetailId InventoryMachineSubDetailId { get; }

    public InventoryMachineSubDetailUpdatedEvent(InventoryMachineSubDetailId inventorymachinesubdetailId)
    {
        InventoryMachineSubDetailId = inventorymachinesubdetailId;
    }
}

public sealed class InventoryMachineSubDetailDeletedEvent : DomainEvent
{
    public InventoryMachineSubDetailId InventoryMachineSubDetailId { get; }

    public InventoryMachineSubDetailDeletedEvent(InventoryMachineSubDetailId inventorymachinesubdetailId)
    {
        InventoryMachineSubDetailId = inventorymachinesubdetailId;
    }
}
}
