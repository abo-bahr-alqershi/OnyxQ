using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryItemDiscount entity
/// </summary>
public sealed class InventoryItemDiscountCreatedEvent : DomainEvent
{
    public InventoryItemDiscountId InventoryItemDiscountId { get; }

    public InventoryItemDiscountCreatedEvent(InventoryItemDiscountId inventoryitemdiscountId)
    {
        InventoryItemDiscountId = inventoryitemdiscountId;
    }
}

public sealed class InventoryItemDiscountUpdatedEvent : DomainEvent
{
    public InventoryItemDiscountId InventoryItemDiscountId { get; }

    public InventoryItemDiscountUpdatedEvent(InventoryItemDiscountId inventoryitemdiscountId)
    {
        InventoryItemDiscountId = inventoryitemdiscountId;
    }
}

public sealed class InventoryItemDiscountDeletedEvent : DomainEvent
{
    public InventoryItemDiscountId InventoryItemDiscountId { get; }

    public InventoryItemDiscountDeletedEvent(InventoryItemDiscountId inventoryitemdiscountId)
    {
        InventoryItemDiscountId = inventoryitemdiscountId;
    }
}
}
