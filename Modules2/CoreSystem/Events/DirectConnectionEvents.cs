using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to DirectConnection entity
/// </summary>
public sealed class DirectConnectionCreatedEvent : DomainEvent
{
    public DirectConnectionId DirectConnectionId { get; }

    public DirectConnectionCreatedEvent(DirectConnectionId directconnectionId)
    {
        DirectConnectionId = directconnectionId;
    }
}

public sealed class DirectConnectionUpdatedEvent : DomainEvent
{
    public DirectConnectionId DirectConnectionId { get; }

    public DirectConnectionUpdatedEvent(DirectConnectionId directconnectionId)
    {
        DirectConnectionId = directconnectionId;
    }
}

public sealed class DirectConnectionDeletedEvent : DomainEvent
{
    public DirectConnectionId DirectConnectionId { get; }

    public DirectConnectionDeletedEvent(DirectConnectionId directconnectionId)
    {
        DirectConnectionId = directconnectionId;
    }
}
}
