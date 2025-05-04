using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to OnlineConnectWarehouseCode entity
/// </summary>
public sealed class OnlineConnectWarehouseCodeCreatedEvent : DomainEvent
{
    public OnlineConnectWarehouseCodeId OnlineConnectWarehouseCodeId { get; }

    public OnlineConnectWarehouseCodeCreatedEvent(OnlineConnectWarehouseCodeId onlineconnectwarehousecodeId)
    {
        OnlineConnectWarehouseCodeId = onlineconnectwarehousecodeId;
    }
}

public sealed class OnlineConnectWarehouseCodeUpdatedEvent : DomainEvent
{
    public OnlineConnectWarehouseCodeId OnlineConnectWarehouseCodeId { get; }

    public OnlineConnectWarehouseCodeUpdatedEvent(OnlineConnectWarehouseCodeId onlineconnectwarehousecodeId)
    {
        OnlineConnectWarehouseCodeId = onlineconnectwarehousecodeId;
    }
}

public sealed class OnlineConnectWarehouseCodeDeletedEvent : DomainEvent
{
    public OnlineConnectWarehouseCodeId OnlineConnectWarehouseCodeId { get; }

    public OnlineConnectWarehouseCodeDeletedEvent(OnlineConnectWarehouseCodeId onlineconnectwarehousecodeId)
    {
        OnlineConnectWarehouseCodeId = onlineconnectwarehousecodeId;
    }
}
}
