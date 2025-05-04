using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ConnectAccountInventoryByGl entity
/// </summary>
public sealed class ConnectAccountInventoryByGlCreatedEvent : DomainEvent
{
    public ConnectAccountInventoryByGlId ConnectAccountInventoryByGlId { get; }

    public ConnectAccountInventoryByGlCreatedEvent(ConnectAccountInventoryByGlId connectaccountinventorybyglId)
    {
        ConnectAccountInventoryByGlId = connectaccountinventorybyglId;
    }
}

public sealed class ConnectAccountInventoryByGlUpdatedEvent : DomainEvent
{
    public ConnectAccountInventoryByGlId ConnectAccountInventoryByGlId { get; }

    public ConnectAccountInventoryByGlUpdatedEvent(ConnectAccountInventoryByGlId connectaccountinventorybyglId)
    {
        ConnectAccountInventoryByGlId = connectaccountinventorybyglId;
    }
}

public sealed class ConnectAccountInventoryByGlDeletedEvent : DomainEvent
{
    public ConnectAccountInventoryByGlId ConnectAccountInventoryByGlId { get; }

    public ConnectAccountInventoryByGlDeletedEvent(ConnectAccountInventoryByGlId connectaccountinventorybyglId)
    {
        ConnectAccountInventoryByGlId = connectaccountinventorybyglId;
    }
}
}
