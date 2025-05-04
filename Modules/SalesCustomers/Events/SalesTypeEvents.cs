using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesType entity
/// </summary>
public sealed class SalesTypeCreatedEvent : DomainEvent
{
    public SalesTypeId SalesTypeId { get; }

    public SalesTypeCreatedEvent(SalesTypeId salestypeId)
    {
        SalesTypeId = salestypeId;
    }
}

public sealed class SalesTypeUpdatedEvent : DomainEvent
{
    public SalesTypeId SalesTypeId { get; }

    public SalesTypeUpdatedEvent(SalesTypeId salestypeId)
    {
        SalesTypeId = salestypeId;
    }
}

public sealed class SalesTypeDeletedEvent : DomainEvent
{
    public SalesTypeId SalesTypeId { get; }

    public SalesTypeDeletedEvent(SalesTypeId salestypeId)
    {
        SalesTypeId = salestypeId;
    }
}
}
