using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryItemCostOrder entity
/// </summary>
public sealed class InventoryItemCostOrderCreatedEvent : DomainEvent
{
    public InventoryItemCostOrderId InventoryItemCostOrderId { get; }

    public InventoryItemCostOrderCreatedEvent(InventoryItemCostOrderId inventoryitemcostorderId)
    {
        InventoryItemCostOrderId = inventoryitemcostorderId;
    }
}

public sealed class InventoryItemCostOrderUpdatedEvent : DomainEvent
{
    public InventoryItemCostOrderId InventoryItemCostOrderId { get; }

    public InventoryItemCostOrderUpdatedEvent(InventoryItemCostOrderId inventoryitemcostorderId)
    {
        InventoryItemCostOrderId = inventoryitemcostorderId;
    }
}

public sealed class InventoryItemCostOrderDeletedEvent : DomainEvent
{
    public InventoryItemCostOrderId InventoryItemCostOrderId { get; }

    public InventoryItemCostOrderDeletedEvent(InventoryItemCostOrderId inventoryitemcostorderId)
    {
        InventoryItemCostOrderId = inventoryitemcostorderId;
    }
}
}
