using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ConnectWarehouseCodeByActivity entity
/// </summary>
public sealed class ConnectWarehouseCodeByActivityCreatedEvent : DomainEvent
{
    public ConnectWarehouseCodeByActivityId ConnectWarehouseCodeByActivityId { get; }

    public ConnectWarehouseCodeByActivityCreatedEvent(ConnectWarehouseCodeByActivityId connectwarehousecodebyactivityId)
    {
        ConnectWarehouseCodeByActivityId = connectwarehousecodebyactivityId;
    }
}

public sealed class ConnectWarehouseCodeByActivityUpdatedEvent : DomainEvent
{
    public ConnectWarehouseCodeByActivityId ConnectWarehouseCodeByActivityId { get; }

    public ConnectWarehouseCodeByActivityUpdatedEvent(ConnectWarehouseCodeByActivityId connectwarehousecodebyactivityId)
    {
        ConnectWarehouseCodeByActivityId = connectwarehousecodebyactivityId;
    }
}

public sealed class ConnectWarehouseCodeByActivityDeletedEvent : DomainEvent
{
    public ConnectWarehouseCodeByActivityId ConnectWarehouseCodeByActivityId { get; }

    public ConnectWarehouseCodeByActivityDeletedEvent(ConnectWarehouseCodeByActivityId connectwarehousecodebyactivityId)
    {
        ConnectWarehouseCodeByActivityId = connectwarehousecodebyactivityId;
    }
}
}
