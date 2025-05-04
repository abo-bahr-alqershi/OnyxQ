using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to ParaCss entity
/// </summary>
public sealed class ParaCssCreatedEvent : DomainEvent
{
    public ParaCssId ParaCssId { get; }

    public ParaCssCreatedEvent(ParaCssId paracssId)
    {
        ParaCssId = paracssId;
    }
}

public sealed class ParaCssUpdatedEvent : DomainEvent
{
    public ParaCssId ParaCssId { get; }

    public ParaCssUpdatedEvent(ParaCssId paracssId)
    {
        ParaCssId = paracssId;
    }
}

public sealed class ParaCssDeletedEvent : DomainEvent
{
    public ParaCssId ParaCssId { get; }

    public ParaCssDeletedEvent(ParaCssId paracssId)
    {
        ParaCssId = paracssId;
    }
}
}
