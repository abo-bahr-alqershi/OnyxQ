using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to WarehouseTransferMultiDetail entity
/// </summary>
public sealed class WarehouseTransferMultiDetailCreatedEvent : DomainEvent
{
    public WarehouseTransferMultiDetailId WarehouseTransferMultiDetailId { get; }

    public WarehouseTransferMultiDetailCreatedEvent(WarehouseTransferMultiDetailId warehousetransfermultidetailId)
    {
        WarehouseTransferMultiDetailId = warehousetransfermultidetailId;
    }
}

public sealed class WarehouseTransferMultiDetailUpdatedEvent : DomainEvent
{
    public WarehouseTransferMultiDetailId WarehouseTransferMultiDetailId { get; }

    public WarehouseTransferMultiDetailUpdatedEvent(WarehouseTransferMultiDetailId warehousetransfermultidetailId)
    {
        WarehouseTransferMultiDetailId = warehousetransfermultidetailId;
    }
}

public sealed class WarehouseTransferMultiDetailDeletedEvent : DomainEvent
{
    public WarehouseTransferMultiDetailId WarehouseTransferMultiDetailId { get; }

    public WarehouseTransferMultiDetailDeletedEvent(WarehouseTransferMultiDetailId warehousetransfermultidetailId)
    {
        WarehouseTransferMultiDetailId = warehousetransfermultidetailId;
    }
}
}
