using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to CollectorTemp entity
/// </summary>
public sealed class CollectorTempCreatedEvent : DomainEvent
{
    public CollectorTempId CollectorTempId { get; }

    public CollectorTempCreatedEvent(CollectorTempId collectortempId)
    {
        CollectorTempId = collectortempId;
    }
}

public sealed class CollectorTempUpdatedEvent : DomainEvent
{
    public CollectorTempId CollectorTempId { get; }

    public CollectorTempUpdatedEvent(CollectorTempId collectortempId)
    {
        CollectorTempId = collectortempId;
    }
}

public sealed class CollectorTempDeletedEvent : DomainEvent
{
    public CollectorTempId CollectorTempId { get; }

    public CollectorTempDeletedEvent(CollectorTempId collectortempId)
    {
        CollectorTempId = collectortempId;
    }
}
}
