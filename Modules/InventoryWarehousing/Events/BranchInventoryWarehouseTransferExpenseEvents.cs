using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BranchInventoryWarehouseTransferExpense entity
/// </summary>
public sealed class BranchInventoryWarehouseTransferExpenseCreatedEvent : DomainEvent
{
    public BranchInventoryWarehouseTransferExpenseId BranchInventoryWarehouseTransferExpenseId { get; }

    public BranchInventoryWarehouseTransferExpenseCreatedEvent(BranchInventoryWarehouseTransferExpenseId branchinventorywarehousetransferexpenseId)
    {
        BranchInventoryWarehouseTransferExpenseId = branchinventorywarehousetransferexpenseId;
    }
}

public sealed class BranchInventoryWarehouseTransferExpenseUpdatedEvent : DomainEvent
{
    public BranchInventoryWarehouseTransferExpenseId BranchInventoryWarehouseTransferExpenseId { get; }

    public BranchInventoryWarehouseTransferExpenseUpdatedEvent(BranchInventoryWarehouseTransferExpenseId branchinventorywarehousetransferexpenseId)
    {
        BranchInventoryWarehouseTransferExpenseId = branchinventorywarehousetransferexpenseId;
    }
}

public sealed class BranchInventoryWarehouseTransferExpenseDeletedEvent : DomainEvent
{
    public BranchInventoryWarehouseTransferExpenseId BranchInventoryWarehouseTransferExpenseId { get; }

    public BranchInventoryWarehouseTransferExpenseDeletedEvent(BranchInventoryWarehouseTransferExpenseId branchinventorywarehousetransferexpenseId)
    {
        BranchInventoryWarehouseTransferExpenseId = branchinventorywarehousetransferexpenseId;
    }
}
}
