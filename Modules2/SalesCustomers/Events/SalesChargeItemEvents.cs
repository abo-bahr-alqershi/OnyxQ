using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesChargeItem entity
/// </summary>
public sealed class SalesChargeItemCreatedEvent : DomainEvent
{
    public SalesChargeItemId SalesChargeItemId { get; }

    public SalesChargeItemCreatedEvent(SalesChargeItemId saleschargeitemId)
    {
        SalesChargeItemId = saleschargeitemId;
    }
}

public sealed class SalesChargeItemUpdatedEvent : DomainEvent
{
    public SalesChargeItemId SalesChargeItemId { get; }

    public SalesChargeItemUpdatedEvent(SalesChargeItemId saleschargeitemId)
    {
        SalesChargeItemId = saleschargeitemId;
    }
}

public sealed class SalesChargeItemDeletedEvent : DomainEvent
{
    public SalesChargeItemId SalesChargeItemId { get; }

    public SalesChargeItemDeletedEvent(SalesChargeItemId saleschargeitemId)
    {
        SalesChargeItemId = saleschargeitemId;
    }
}
}
