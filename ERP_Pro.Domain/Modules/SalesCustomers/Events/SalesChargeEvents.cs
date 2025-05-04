using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesCharge entity
/// </summary>
public sealed class SalesChargeCreatedEvent : DomainEvent
{
    public SalesChargeId SalesChargeId { get; }

    public SalesChargeCreatedEvent(SalesChargeId saleschargeId)
    {
        SalesChargeId = saleschargeId;
    }
}

public sealed class SalesChargeUpdatedEvent : DomainEvent
{
    public SalesChargeId SalesChargeId { get; }

    public SalesChargeUpdatedEvent(SalesChargeId saleschargeId)
    {
        SalesChargeId = saleschargeId;
    }
}

public sealed class SalesChargeDeletedEvent : DomainEvent
{
    public SalesChargeId SalesChargeId { get; }

    public SalesChargeDeletedEvent(SalesChargeId saleschargeId)
    {
        SalesChargeId = saleschargeId;
    }
}
}
