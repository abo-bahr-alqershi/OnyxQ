using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to OpeningStock entity
/// </summary>
public sealed class OpeningStockCreatedEvent : DomainEvent
{
    public OpeningStockId OpeningStockId { get; }

    public OpeningStockCreatedEvent(OpeningStockId openingstockId)
    {
        OpeningStockId = openingstockId;
    }
}

public sealed class OpeningStockUpdatedEvent : DomainEvent
{
    public OpeningStockId OpeningStockId { get; }

    public OpeningStockUpdatedEvent(OpeningStockId openingstockId)
    {
        OpeningStockId = openingstockId;
    }
}

public sealed class OpeningStockDeletedEvent : DomainEvent
{
    public OpeningStockId OpeningStockId { get; }

    public OpeningStockDeletedEvent(OpeningStockId openingstockId)
    {
        OpeningStockId = openingstockId;
    }
}
}
