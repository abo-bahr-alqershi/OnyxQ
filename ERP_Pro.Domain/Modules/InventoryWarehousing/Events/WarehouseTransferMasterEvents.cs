using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to WarehouseTransferMaster entity
/// </summary>
public sealed class WarehouseTransferMasterCreatedEvent : DomainEvent
{
    public WarehouseTransferMasterId WarehouseTransferMasterId { get; }

    public WarehouseTransferMasterCreatedEvent(WarehouseTransferMasterId warehousetransfermasterId)
    {
        WarehouseTransferMasterId = warehousetransfermasterId;
    }
}

public sealed class WarehouseTransferMasterUpdatedEvent : DomainEvent
{
    public WarehouseTransferMasterId WarehouseTransferMasterId { get; }

    public WarehouseTransferMasterUpdatedEvent(WarehouseTransferMasterId warehousetransfermasterId)
    {
        WarehouseTransferMasterId = warehousetransfermasterId;
    }
}

public sealed class WarehouseTransferMasterDeletedEvent : DomainEvent
{
    public WarehouseTransferMasterId WarehouseTransferMasterId { get; }

    public WarehouseTransferMasterDeletedEvent(WarehouseTransferMasterId warehousetransfermasterId)
    {
        WarehouseTransferMasterId = warehousetransfermasterId;
    }
}
}
