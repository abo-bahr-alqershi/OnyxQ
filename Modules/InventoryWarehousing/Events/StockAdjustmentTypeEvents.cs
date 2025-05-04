using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to StockAdjustmentType entity
/// </summary>
public sealed class StockAdjustmentTypeCreatedEvent : DomainEvent
{
    public StockAdjustmentTypeId StockAdjustmentTypeId { get; }

    public StockAdjustmentTypeCreatedEvent(StockAdjustmentTypeId stockadjustmenttypeId)
    {
        StockAdjustmentTypeId = stockadjustmenttypeId;
    }
}

public sealed class StockAdjustmentTypeUpdatedEvent : DomainEvent
{
    public StockAdjustmentTypeId StockAdjustmentTypeId { get; }

    public StockAdjustmentTypeUpdatedEvent(StockAdjustmentTypeId stockadjustmenttypeId)
    {
        StockAdjustmentTypeId = stockadjustmenttypeId;
    }
}

public sealed class StockAdjustmentTypeDeletedEvent : DomainEvent
{
    public StockAdjustmentTypeId StockAdjustmentTypeId { get; }

    public StockAdjustmentTypeDeletedEvent(StockAdjustmentTypeId stockadjustmenttypeId)
    {
        StockAdjustmentTypeId = stockadjustmenttypeId;
    }
}
}
