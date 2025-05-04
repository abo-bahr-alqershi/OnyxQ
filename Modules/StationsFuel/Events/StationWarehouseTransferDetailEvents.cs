using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationWarehouseTransferDetail entity
/// </summary>
public sealed class StationWarehouseTransferDetailCreatedEvent : DomainEvent
{
    public StationWarehouseTransferDetailId StationWarehouseTransferDetailId { get; }

    public StationWarehouseTransferDetailCreatedEvent(StationWarehouseTransferDetailId stationwarehousetransferdetailId)
    {
        StationWarehouseTransferDetailId = stationwarehousetransferdetailId;
    }
}

public sealed class StationWarehouseTransferDetailUpdatedEvent : DomainEvent
{
    public StationWarehouseTransferDetailId StationWarehouseTransferDetailId { get; }

    public StationWarehouseTransferDetailUpdatedEvent(StationWarehouseTransferDetailId stationwarehousetransferdetailId)
    {
        StationWarehouseTransferDetailId = stationwarehousetransferdetailId;
    }
}

public sealed class StationWarehouseTransferDetailDeletedEvent : DomainEvent
{
    public StationWarehouseTransferDetailId StationWarehouseTransferDetailId { get; }

    public StationWarehouseTransferDetailDeletedEvent(StationWarehouseTransferDetailId stationwarehousetransferdetailId)
    {
        StationWarehouseTransferDetailId = stationwarehousetransferdetailId;
    }
}
}
