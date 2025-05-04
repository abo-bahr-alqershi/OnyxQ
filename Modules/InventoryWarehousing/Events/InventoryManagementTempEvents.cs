using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryManagementTemp entity
/// </summary>
public sealed class InventoryManagementTempCreatedEvent : DomainEvent
{
    public InventoryManagementTempId InventoryManagementTempId { get; }

    public InventoryManagementTempCreatedEvent(InventoryManagementTempId inventorymanagementtempId)
    {
        InventoryManagementTempId = inventorymanagementtempId;
    }
}

public sealed class InventoryManagementTempUpdatedEvent : DomainEvent
{
    public InventoryManagementTempId InventoryManagementTempId { get; }

    public InventoryManagementTempUpdatedEvent(InventoryManagementTempId inventorymanagementtempId)
    {
        InventoryManagementTempId = inventorymanagementtempId;
    }
}

public sealed class InventoryManagementTempDeletedEvent : DomainEvent
{
    public InventoryManagementTempId InventoryManagementTempId { get; }

    public InventoryManagementTempDeletedEvent(InventoryManagementTempId inventorymanagementtempId)
    {
        InventoryManagementTempId = inventorymanagementtempId;
    }
}
}
