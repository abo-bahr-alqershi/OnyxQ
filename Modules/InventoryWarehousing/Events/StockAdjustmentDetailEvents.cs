using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to StockAdjustmentDetail entity
/// </summary>
public sealed class StockAdjustmentDetailCreatedEvent : DomainEvent
{
    public StockAdjustmentDetailId StockAdjustmentDetailId { get; }

    public StockAdjustmentDetailCreatedEvent(StockAdjustmentDetailId stockadjustmentdetailId)
    {
        StockAdjustmentDetailId = stockadjustmentdetailId;
    }
}

public sealed class StockAdjustmentDetailUpdatedEvent : DomainEvent
{
    public StockAdjustmentDetailId StockAdjustmentDetailId { get; }

    public StockAdjustmentDetailUpdatedEvent(StockAdjustmentDetailId stockadjustmentdetailId)
    {
        StockAdjustmentDetailId = stockadjustmentdetailId;
    }
}

public sealed class StockAdjustmentDetailDeletedEvent : DomainEvent
{
    public StockAdjustmentDetailId StockAdjustmentDetailId { get; }

    public StockAdjustmentDetailDeletedEvent(StockAdjustmentDetailId stockadjustmentdetailId)
    {
        StockAdjustmentDetailId = stockadjustmentdetailId;
    }
}
}
