using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryManagement entity
/// </summary>
public sealed class InventoryManagementCreatedEvent : DomainEvent
{
    public InventoryManagementId InventoryManagementId { get; }

    public InventoryManagementCreatedEvent(InventoryManagementId inventorymanagementId)
    {
        InventoryManagementId = inventorymanagementId;
    }
}

public sealed class InventoryManagementUpdatedEvent : DomainEvent
{
    public InventoryManagementId InventoryManagementId { get; }

    public InventoryManagementUpdatedEvent(InventoryManagementId inventorymanagementId)
    {
        InventoryManagementId = inventorymanagementId;
    }
}

public sealed class InventoryManagementDeletedEvent : DomainEvent
{
    public InventoryManagementId InventoryManagementId { get; }

    public InventoryManagementDeletedEvent(InventoryManagementId inventorymanagementId)
    {
        InventoryManagementId = inventorymanagementId;
    }
}
}
