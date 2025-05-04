using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to MeasureDiscountItemMaster entity
/// </summary>
public sealed class MeasureDiscountItemMasterCreatedEvent : DomainEvent
{
    public MeasureDiscountItemMasterId MeasureDiscountItemMasterId { get; }

    public MeasureDiscountItemMasterCreatedEvent(MeasureDiscountItemMasterId measurediscountitemmasterId)
    {
        MeasureDiscountItemMasterId = measurediscountitemmasterId;
    }
}

public sealed class MeasureDiscountItemMasterUpdatedEvent : DomainEvent
{
    public MeasureDiscountItemMasterId MeasureDiscountItemMasterId { get; }

    public MeasureDiscountItemMasterUpdatedEvent(MeasureDiscountItemMasterId measurediscountitemmasterId)
    {
        MeasureDiscountItemMasterId = measurediscountitemmasterId;
    }
}

public sealed class MeasureDiscountItemMasterDeletedEvent : DomainEvent
{
    public MeasureDiscountItemMasterId MeasureDiscountItemMasterId { get; }

    public MeasureDiscountItemMasterDeletedEvent(MeasureDiscountItemMasterId measurediscountitemmasterId)
    {
        MeasureDiscountItemMasterId = measurediscountitemmasterId;
    }
}
}
