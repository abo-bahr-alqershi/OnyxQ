using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to OnlineConnectWarehouseCodeRegion entity
/// </summary>
public sealed class OnlineConnectWarehouseCodeRegionCreatedEvent : DomainEvent
{
    public OnlineConnectWarehouseCodeRegionId OnlineConnectWarehouseCodeRegionId { get; }

    public OnlineConnectWarehouseCodeRegionCreatedEvent(OnlineConnectWarehouseCodeRegionId onlineconnectwarehousecoderegionId)
    {
        OnlineConnectWarehouseCodeRegionId = onlineconnectwarehousecoderegionId;
    }
}

public sealed class OnlineConnectWarehouseCodeRegionUpdatedEvent : DomainEvent
{
    public OnlineConnectWarehouseCodeRegionId OnlineConnectWarehouseCodeRegionId { get; }

    public OnlineConnectWarehouseCodeRegionUpdatedEvent(OnlineConnectWarehouseCodeRegionId onlineconnectwarehousecoderegionId)
    {
        OnlineConnectWarehouseCodeRegionId = onlineconnectwarehousecoderegionId;
    }
}

public sealed class OnlineConnectWarehouseCodeRegionDeletedEvent : DomainEvent
{
    public OnlineConnectWarehouseCodeRegionId OnlineConnectWarehouseCodeRegionId { get; }

    public OnlineConnectWarehouseCodeRegionDeletedEvent(OnlineConnectWarehouseCodeRegionId onlineconnectwarehousecoderegionId)
    {
        OnlineConnectWarehouseCodeRegionId = onlineconnectwarehousecoderegionId;
    }
}
}
