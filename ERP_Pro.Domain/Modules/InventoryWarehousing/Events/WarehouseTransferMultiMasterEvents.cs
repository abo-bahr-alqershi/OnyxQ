using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to WarehouseTransferMultiMaster entity
/// </summary>
public sealed class WarehouseTransferMultiMasterCreatedEvent : DomainEvent
{
    public WarehouseTransferMultiMasterId WarehouseTransferMultiMasterId { get; }

    public WarehouseTransferMultiMasterCreatedEvent(WarehouseTransferMultiMasterId warehousetransfermultimasterId)
    {
        WarehouseTransferMultiMasterId = warehousetransfermultimasterId;
    }
}

public sealed class WarehouseTransferMultiMasterUpdatedEvent : DomainEvent
{
    public WarehouseTransferMultiMasterId WarehouseTransferMultiMasterId { get; }

    public WarehouseTransferMultiMasterUpdatedEvent(WarehouseTransferMultiMasterId warehousetransfermultimasterId)
    {
        WarehouseTransferMultiMasterId = warehousetransfermultimasterId;
    }
}

public sealed class WarehouseTransferMultiMasterDeletedEvent : DomainEvent
{
    public WarehouseTransferMultiMasterId WarehouseTransferMultiMasterId { get; }

    public WarehouseTransferMultiMasterDeletedEvent(WarehouseTransferMultiMasterId warehousetransfermultimasterId)
    {
        WarehouseTransferMultiMasterId = warehousetransfermultimasterId;
    }
}
}
