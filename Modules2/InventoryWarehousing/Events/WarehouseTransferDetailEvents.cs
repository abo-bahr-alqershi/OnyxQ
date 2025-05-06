using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to WarehouseTransferDetail entity
/// </summary>
public sealed class WarehouseTransferDetailCreatedEvent : DomainEvent
{
    public WarehouseTransferDetailId WarehouseTransferDetailId { get; }

    public WarehouseTransferDetailCreatedEvent(WarehouseTransferDetailId warehousetransferdetailId)
    {
        WarehouseTransferDetailId = warehousetransferdetailId;
    }
}

public sealed class WarehouseTransferDetailUpdatedEvent : DomainEvent
{
    public WarehouseTransferDetailId WarehouseTransferDetailId { get; }

    public WarehouseTransferDetailUpdatedEvent(WarehouseTransferDetailId warehousetransferdetailId)
    {
        WarehouseTransferDetailId = warehousetransferdetailId;
    }
}

public sealed class WarehouseTransferDetailDeletedEvent : DomainEvent
{
    public WarehouseTransferDetailId WarehouseTransferDetailId { get; }

    public WarehouseTransferDetailDeletedEvent(WarehouseTransferDetailId warehousetransferdetailId)
    {
        WarehouseTransferDetailId = warehousetransferdetailId;
    }
}
}
