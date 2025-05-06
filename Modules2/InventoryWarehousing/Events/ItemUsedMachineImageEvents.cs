using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemUsedMachineImage entity
/// </summary>
public sealed class ItemUsedMachineImageCreatedEvent : DomainEvent
{
    public ItemUsedMachineImageId ItemUsedMachineImageId { get; }

    public ItemUsedMachineImageCreatedEvent(ItemUsedMachineImageId itemusedmachineimageId)
    {
        ItemUsedMachineImageId = itemusedmachineimageId;
    }
}

public sealed class ItemUsedMachineImageUpdatedEvent : DomainEvent
{
    public ItemUsedMachineImageId ItemUsedMachineImageId { get; }

    public ItemUsedMachineImageUpdatedEvent(ItemUsedMachineImageId itemusedmachineimageId)
    {
        ItemUsedMachineImageId = itemusedmachineimageId;
    }
}

public sealed class ItemUsedMachineImageDeletedEvent : DomainEvent
{
    public ItemUsedMachineImageId ItemUsedMachineImageId { get; }

    public ItemUsedMachineImageDeletedEvent(ItemUsedMachineImageId itemusedmachineimageId)
    {
        ItemUsedMachineImageId = itemusedmachineimageId;
    }
}
}
