using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to DefaultDataOnline entity
/// </summary>
public sealed class DefaultDataOnlineCreatedEvent : DomainEvent
{
    public DefaultDataOnlineId DefaultDataOnlineId { get; }

    public DefaultDataOnlineCreatedEvent(DefaultDataOnlineId defaultdataonlineId)
    {
        DefaultDataOnlineId = defaultdataonlineId;
    }
}

public sealed class DefaultDataOnlineUpdatedEvent : DomainEvent
{
    public DefaultDataOnlineId DefaultDataOnlineId { get; }

    public DefaultDataOnlineUpdatedEvent(DefaultDataOnlineId defaultdataonlineId)
    {
        DefaultDataOnlineId = defaultdataonlineId;
    }
}

public sealed class DefaultDataOnlineDeletedEvent : DomainEvent
{
    public DefaultDataOnlineId DefaultDataOnlineId { get; }

    public DefaultDataOnlineDeletedEvent(DefaultDataOnlineId defaultdataonlineId)
    {
        DefaultDataOnlineId = defaultdataonlineId;
    }
}
}
