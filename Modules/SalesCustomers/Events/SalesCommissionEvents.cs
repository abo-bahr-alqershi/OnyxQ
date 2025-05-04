using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesCommission entity
/// </summary>
public sealed class SalesCommissionCreatedEvent : DomainEvent
{
    public SalesCommissionId SalesCommissionId { get; }

    public SalesCommissionCreatedEvent(SalesCommissionId salescommissionId)
    {
        SalesCommissionId = salescommissionId;
    }
}

public sealed class SalesCommissionUpdatedEvent : DomainEvent
{
    public SalesCommissionId SalesCommissionId { get; }

    public SalesCommissionUpdatedEvent(SalesCommissionId salescommissionId)
    {
        SalesCommissionId = salescommissionId;
    }
}

public sealed class SalesCommissionDeletedEvent : DomainEvent
{
    public SalesCommissionId SalesCommissionId { get; }

    public SalesCommissionDeletedEvent(SalesCommissionId salescommissionId)
    {
        SalesCommissionId = salescommissionId;
    }
}
}
