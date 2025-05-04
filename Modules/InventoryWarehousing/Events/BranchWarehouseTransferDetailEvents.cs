using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BranchWarehouseTransferDetail entity
/// </summary>
public sealed class BranchWarehouseTransferDetailCreatedEvent : DomainEvent
{
    public BranchWarehouseTransferDetailId BranchWarehouseTransferDetailId { get; }

    public BranchWarehouseTransferDetailCreatedEvent(BranchWarehouseTransferDetailId branchwarehousetransferdetailId)
    {
        BranchWarehouseTransferDetailId = branchwarehousetransferdetailId;
    }
}

public sealed class BranchWarehouseTransferDetailUpdatedEvent : DomainEvent
{
    public BranchWarehouseTransferDetailId BranchWarehouseTransferDetailId { get; }

    public BranchWarehouseTransferDetailUpdatedEvent(BranchWarehouseTransferDetailId branchwarehousetransferdetailId)
    {
        BranchWarehouseTransferDetailId = branchwarehousetransferdetailId;
    }
}

public sealed class BranchWarehouseTransferDetailDeletedEvent : DomainEvent
{
    public BranchWarehouseTransferDetailId BranchWarehouseTransferDetailId { get; }

    public BranchWarehouseTransferDetailDeletedEvent(BranchWarehouseTransferDetailId branchwarehousetransferdetailId)
    {
        BranchWarehouseTransferDetailId = branchwarehousetransferdetailId;
    }
}
}
