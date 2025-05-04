using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to LowLimitPeriodStock entity
/// </summary>
public sealed class LowLimitPeriodStockCreatedEvent : DomainEvent
{
    public LowLimitPeriodStockId LowLimitPeriodStockId { get; }

    public LowLimitPeriodStockCreatedEvent(LowLimitPeriodStockId lowlimitperiodstockId)
    {
        LowLimitPeriodStockId = lowlimitperiodstockId;
    }
}

public sealed class LowLimitPeriodStockUpdatedEvent : DomainEvent
{
    public LowLimitPeriodStockId LowLimitPeriodStockId { get; }

    public LowLimitPeriodStockUpdatedEvent(LowLimitPeriodStockId lowlimitperiodstockId)
    {
        LowLimitPeriodStockId = lowlimitperiodstockId;
    }
}

public sealed class LowLimitPeriodStockDeletedEvent : DomainEvent
{
    public LowLimitPeriodStockId LowLimitPeriodStockId { get; }

    public LowLimitPeriodStockDeletedEvent(LowLimitPeriodStockId lowlimitperiodstockId)
    {
        LowLimitPeriodStockId = lowlimitperiodstockId;
    }
}
}
