using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to StockAdjustment entity
/// </summary>
public sealed class StockAdjustmentCreatedEvent : DomainEvent
{
    public StockAdjustmentId StockAdjustmentId { get; }

    public StockAdjustmentCreatedEvent(StockAdjustmentId stockadjustmentId)
    {
        StockAdjustmentId = stockadjustmentId;
    }
}

public sealed class StockAdjustmentUpdatedEvent : DomainEvent
{
    public StockAdjustmentId StockAdjustmentId { get; }

    public StockAdjustmentUpdatedEvent(StockAdjustmentId stockadjustmentId)
    {
        StockAdjustmentId = stockadjustmentId;
    }
}

public sealed class StockAdjustmentDeletedEvent : DomainEvent
{
    public StockAdjustmentId StockAdjustmentId { get; }

    public StockAdjustmentDeletedEvent(StockAdjustmentId stockadjustmentId)
    {
        StockAdjustmentId = stockadjustmentId;
    }
}
}
