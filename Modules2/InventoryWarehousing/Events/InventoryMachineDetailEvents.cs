using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryMachineDetail entity
/// </summary>
public sealed class InventoryMachineDetailCreatedEvent : DomainEvent
{
    public InventoryMachineDetailId InventoryMachineDetailId { get; }

    public InventoryMachineDetailCreatedEvent(InventoryMachineDetailId inventorymachinedetailId)
    {
        InventoryMachineDetailId = inventorymachinedetailId;
    }
}

public sealed class InventoryMachineDetailUpdatedEvent : DomainEvent
{
    public InventoryMachineDetailId InventoryMachineDetailId { get; }

    public InventoryMachineDetailUpdatedEvent(InventoryMachineDetailId inventorymachinedetailId)
    {
        InventoryMachineDetailId = inventorymachinedetailId;
    }
}

public sealed class InventoryMachineDetailDeletedEvent : DomainEvent
{
    public InventoryMachineDetailId InventoryMachineDetailId { get; }

    public InventoryMachineDetailDeletedEvent(InventoryMachineDetailId inventorymachinedetailId)
    {
        InventoryMachineDetailId = inventorymachinedetailId;
    }
}
}
