using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to WeightedItemsTemp entity
/// </summary>
public sealed class WeightedItemsTempCreatedEvent : DomainEvent
{
    public WeightedItemsTempId WeightedItemsTempId { get; }

    public WeightedItemsTempCreatedEvent(WeightedItemsTempId weighteditemstempId)
    {
        WeightedItemsTempId = weighteditemstempId;
    }
}

public sealed class WeightedItemsTempUpdatedEvent : DomainEvent
{
    public WeightedItemsTempId WeightedItemsTempId { get; }

    public WeightedItemsTempUpdatedEvent(WeightedItemsTempId weighteditemstempId)
    {
        WeightedItemsTempId = weighteditemstempId;
    }
}

public sealed class WeightedItemsTempDeletedEvent : DomainEvent
{
    public WeightedItemsTempId WeightedItemsTempId { get; }

    public WeightedItemsTempDeletedEvent(WeightedItemsTempId weighteditemstempId)
    {
        WeightedItemsTempId = weighteditemstempId;
    }
}
}
