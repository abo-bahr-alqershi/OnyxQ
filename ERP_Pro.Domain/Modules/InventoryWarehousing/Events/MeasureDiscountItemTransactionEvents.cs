using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to MeasureDiscountItemTransaction entity
/// </summary>
public sealed class MeasureDiscountItemTransactionCreatedEvent : DomainEvent
{
    public MeasureDiscountItemTransactionId MeasureDiscountItemTransactionId { get; }

    public MeasureDiscountItemTransactionCreatedEvent(MeasureDiscountItemTransactionId measurediscountitemtransactionId)
    {
        MeasureDiscountItemTransactionId = measurediscountitemtransactionId;
    }
}

public sealed class MeasureDiscountItemTransactionUpdatedEvent : DomainEvent
{
    public MeasureDiscountItemTransactionId MeasureDiscountItemTransactionId { get; }

    public MeasureDiscountItemTransactionUpdatedEvent(MeasureDiscountItemTransactionId measurediscountitemtransactionId)
    {
        MeasureDiscountItemTransactionId = measurediscountitemtransactionId;
    }
}

public sealed class MeasureDiscountItemTransactionDeletedEvent : DomainEvent
{
    public MeasureDiscountItemTransactionId MeasureDiscountItemTransactionId { get; }

    public MeasureDiscountItemTransactionDeletedEvent(MeasureDiscountItemTransactionId measurediscountitemtransactionId)
    {
        MeasureDiscountItemTransactionId = measurediscountitemtransactionId;
    }
}
}
