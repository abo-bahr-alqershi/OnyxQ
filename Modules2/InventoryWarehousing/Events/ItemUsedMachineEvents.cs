using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemUsedMachine entity
/// </summary>
public sealed class ItemUsedMachineCreatedEvent : DomainEvent
{
    public ItemUsedMachineId ItemUsedMachineId { get; }

    public ItemUsedMachineCreatedEvent(ItemUsedMachineId itemusedmachineId)
    {
        ItemUsedMachineId = itemusedmachineId;
    }
}

public sealed class ItemUsedMachineUpdatedEvent : DomainEvent
{
    public ItemUsedMachineId ItemUsedMachineId { get; }

    public ItemUsedMachineUpdatedEvent(ItemUsedMachineId itemusedmachineId)
    {
        ItemUsedMachineId = itemusedmachineId;
    }
}

public sealed class ItemUsedMachineDeletedEvent : DomainEvent
{
    public ItemUsedMachineId ItemUsedMachineId { get; }

    public ItemUsedMachineDeletedEvent(ItemUsedMachineId itemusedmachineId)
    {
        ItemUsedMachineId = itemusedmachineId;
    }
}
}
