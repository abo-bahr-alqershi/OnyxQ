using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryItemBinMovement entity
/// </summary>
public sealed class InventoryItemBinMovementCreatedEvent : DomainEvent
{
    public InventoryItemBinMovementId InventoryItemBinMovementId { get; }

    public InventoryItemBinMovementCreatedEvent(InventoryItemBinMovementId inventoryitembinmovementId)
    {
        InventoryItemBinMovementId = inventoryitembinmovementId;
    }
}

public sealed class InventoryItemBinMovementUpdatedEvent : DomainEvent
{
    public InventoryItemBinMovementId InventoryItemBinMovementId { get; }

    public InventoryItemBinMovementUpdatedEvent(InventoryItemBinMovementId inventoryitembinmovementId)
    {
        InventoryItemBinMovementId = inventoryitembinmovementId;
    }
}

public sealed class InventoryItemBinMovementDeletedEvent : DomainEvent
{
    public InventoryItemBinMovementId InventoryItemBinMovementId { get; }

    public InventoryItemBinMovementDeletedEvent(InventoryItemBinMovementId inventoryitembinmovementId)
    {
        InventoryItemBinMovementId = inventoryitembinmovementId;
    }
}
}
