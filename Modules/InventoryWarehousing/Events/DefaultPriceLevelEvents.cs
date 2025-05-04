using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to DefaultPriceLevel entity
/// </summary>
public sealed class DefaultPriceLevelCreatedEvent : DomainEvent
{
    public DefaultPriceLevelId DefaultPriceLevelId { get; }

    public DefaultPriceLevelCreatedEvent(DefaultPriceLevelId defaultpricelevelId)
    {
        DefaultPriceLevelId = defaultpricelevelId;
    }
}

public sealed class DefaultPriceLevelUpdatedEvent : DomainEvent
{
    public DefaultPriceLevelId DefaultPriceLevelId { get; }

    public DefaultPriceLevelUpdatedEvent(DefaultPriceLevelId defaultpricelevelId)
    {
        DefaultPriceLevelId = defaultpricelevelId;
    }
}

public sealed class DefaultPriceLevelDeletedEvent : DomainEvent
{
    public DefaultPriceLevelId DefaultPriceLevelId { get; }

    public DefaultPriceLevelDeletedEvent(DefaultPriceLevelId defaultpricelevelId)
    {
        DefaultPriceLevelId = defaultpricelevelId;
    }
}
}
