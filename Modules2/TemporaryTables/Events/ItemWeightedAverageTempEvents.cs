using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to ItemWeightedAverageTemp entity
/// </summary>
public sealed class ItemWeightedAverageTempCreatedEvent : DomainEvent
{
    public ItemWeightedAverageTempId ItemWeightedAverageTempId { get; }

    public ItemWeightedAverageTempCreatedEvent(ItemWeightedAverageTempId itemweightedaveragetempId)
    {
        ItemWeightedAverageTempId = itemweightedaveragetempId;
    }
}

public sealed class ItemWeightedAverageTempUpdatedEvent : DomainEvent
{
    public ItemWeightedAverageTempId ItemWeightedAverageTempId { get; }

    public ItemWeightedAverageTempUpdatedEvent(ItemWeightedAverageTempId itemweightedaveragetempId)
    {
        ItemWeightedAverageTempId = itemweightedaveragetempId;
    }
}

public sealed class ItemWeightedAverageTempDeletedEvent : DomainEvent
{
    public ItemWeightedAverageTempId ItemWeightedAverageTempId { get; }

    public ItemWeightedAverageTempDeletedEvent(ItemWeightedAverageTempId itemweightedaveragetempId)
    {
        ItemWeightedAverageTempId = itemweightedaveragetempId;
    }
}
}
