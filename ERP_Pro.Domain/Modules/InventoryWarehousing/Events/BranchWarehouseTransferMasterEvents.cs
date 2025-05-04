using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BranchWarehouseTransferMaster entity
/// </summary>
public sealed class BranchWarehouseTransferMasterCreatedEvent : DomainEvent
{
    public BranchWarehouseTransferMasterId BranchWarehouseTransferMasterId { get; }

    public BranchWarehouseTransferMasterCreatedEvent(BranchWarehouseTransferMasterId branchwarehousetransfermasterId)
    {
        BranchWarehouseTransferMasterId = branchwarehousetransfermasterId;
    }
}

public sealed class BranchWarehouseTransferMasterUpdatedEvent : DomainEvent
{
    public BranchWarehouseTransferMasterId BranchWarehouseTransferMasterId { get; }

    public BranchWarehouseTransferMasterUpdatedEvent(BranchWarehouseTransferMasterId branchwarehousetransfermasterId)
    {
        BranchWarehouseTransferMasterId = branchwarehousetransfermasterId;
    }
}

public sealed class BranchWarehouseTransferMasterDeletedEvent : DomainEvent
{
    public BranchWarehouseTransferMasterId BranchWarehouseTransferMasterId { get; }

    public BranchWarehouseTransferMasterDeletedEvent(BranchWarehouseTransferMasterId branchwarehousetransfermasterId)
    {
        BranchWarehouseTransferMasterId = branchwarehousetransfermasterId;
    }
}
}
