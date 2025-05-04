using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryWarehouseTransferExpense entity
/// </summary>
public sealed class InventoryWarehouseTransferExpenseCreatedEvent : DomainEvent
{
    public InventoryWarehouseTransferExpenseId InventoryWarehouseTransferExpenseId { get; }

    public InventoryWarehouseTransferExpenseCreatedEvent(InventoryWarehouseTransferExpenseId inventorywarehousetransferexpenseId)
    {
        InventoryWarehouseTransferExpenseId = inventorywarehousetransferexpenseId;
    }
}

public sealed class InventoryWarehouseTransferExpenseUpdatedEvent : DomainEvent
{
    public InventoryWarehouseTransferExpenseId InventoryWarehouseTransferExpenseId { get; }

    public InventoryWarehouseTransferExpenseUpdatedEvent(InventoryWarehouseTransferExpenseId inventorywarehousetransferexpenseId)
    {
        InventoryWarehouseTransferExpenseId = inventorywarehousetransferexpenseId;
    }
}

public sealed class InventoryWarehouseTransferExpenseDeletedEvent : DomainEvent
{
    public InventoryWarehouseTransferExpenseId InventoryWarehouseTransferExpenseId { get; }

    public InventoryWarehouseTransferExpenseDeletedEvent(InventoryWarehouseTransferExpenseId inventorywarehousetransferexpenseId)
    {
        InventoryWarehouseTransferExpenseId = inventorywarehousetransferexpenseId;
    }
}
}
