using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryMachineMaster entity
/// </summary>
public sealed class InventoryMachineMasterCreatedEvent : DomainEvent
{
    public InventoryMachineMasterId InventoryMachineMasterId { get; }

    public InventoryMachineMasterCreatedEvent(InventoryMachineMasterId inventorymachinemasterId)
    {
        InventoryMachineMasterId = inventorymachinemasterId;
    }
}

public sealed class InventoryMachineMasterUpdatedEvent : DomainEvent
{
    public InventoryMachineMasterId InventoryMachineMasterId { get; }

    public InventoryMachineMasterUpdatedEvent(InventoryMachineMasterId inventorymachinemasterId)
    {
        InventoryMachineMasterId = inventorymachinemasterId;
    }
}

public sealed class InventoryMachineMasterDeletedEvent : DomainEvent
{
    public InventoryMachineMasterId InventoryMachineMasterId { get; }

    public InventoryMachineMasterDeletedEvent(InventoryMachineMasterId inventorymachinemasterId)
    {
        InventoryMachineMasterId = inventorymachinemasterId;
    }
}
}
