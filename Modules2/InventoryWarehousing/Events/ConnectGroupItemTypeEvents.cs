using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ConnectGroupItemType entity
/// </summary>
public sealed class ConnectGroupItemTypeCreatedEvent : DomainEvent
{
    public ConnectGroupItemTypeId ConnectGroupItemTypeId { get; }

    public ConnectGroupItemTypeCreatedEvent(ConnectGroupItemTypeId connectgroupitemtypeId)
    {
        ConnectGroupItemTypeId = connectgroupitemtypeId;
    }
}

public sealed class ConnectGroupItemTypeUpdatedEvent : DomainEvent
{
    public ConnectGroupItemTypeId ConnectGroupItemTypeId { get; }

    public ConnectGroupItemTypeUpdatedEvent(ConnectGroupItemTypeId connectgroupitemtypeId)
    {
        ConnectGroupItemTypeId = connectgroupitemtypeId;
    }
}

public sealed class ConnectGroupItemTypeDeletedEvent : DomainEvent
{
    public ConnectGroupItemTypeId ConnectGroupItemTypeId { get; }

    public ConnectGroupItemTypeDeletedEvent(ConnectGroupItemTypeId connectgroupitemtypeId)
    {
        ConnectGroupItemTypeId = connectgroupitemtypeId;
    }
}
}
