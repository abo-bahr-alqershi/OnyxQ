using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to MeasureDiscountItemDetail entity
/// </summary>
public sealed class MeasureDiscountItemDetailCreatedEvent : DomainEvent
{
    public MeasureDiscountItemDetailId MeasureDiscountItemDetailId { get; }

    public MeasureDiscountItemDetailCreatedEvent(MeasureDiscountItemDetailId measurediscountitemdetailId)
    {
        MeasureDiscountItemDetailId = measurediscountitemdetailId;
    }
}

public sealed class MeasureDiscountItemDetailUpdatedEvent : DomainEvent
{
    public MeasureDiscountItemDetailId MeasureDiscountItemDetailId { get; }

    public MeasureDiscountItemDetailUpdatedEvent(MeasureDiscountItemDetailId measurediscountitemdetailId)
    {
        MeasureDiscountItemDetailId = measurediscountitemdetailId;
    }
}

public sealed class MeasureDiscountItemDetailDeletedEvent : DomainEvent
{
    public MeasureDiscountItemDetailId MeasureDiscountItemDetailId { get; }

    public MeasureDiscountItemDetailDeletedEvent(MeasureDiscountItemDetailId measurediscountitemdetailId)
    {
        MeasureDiscountItemDetailId = measurediscountitemdetailId;
    }
}
}
