using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ParameterOnline entity
/// </summary>
public sealed class ParameterOnlineCreatedEvent : DomainEvent
{
    public ParameterOnlineId ParameterOnlineId { get; }

    public ParameterOnlineCreatedEvent(ParameterOnlineId parameteronlineId)
    {
        ParameterOnlineId = parameteronlineId;
    }
}

public sealed class ParameterOnlineUpdatedEvent : DomainEvent
{
    public ParameterOnlineId ParameterOnlineId { get; }

    public ParameterOnlineUpdatedEvent(ParameterOnlineId parameteronlineId)
    {
        ParameterOnlineId = parameteronlineId;
    }
}

public sealed class ParameterOnlineDeletedEvent : DomainEvent
{
    public ParameterOnlineId ParameterOnlineId { get; }

    public ParameterOnlineDeletedEvent(ParameterOnlineId parameteronlineId)
    {
        ParameterOnlineId = parameteronlineId;
    }
}
}
