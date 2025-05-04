using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanType entity
/// </summary>
public sealed class SalesmanTypeCreatedEvent : DomainEvent
{
    public SalesmanTypeId SalesmanTypeId { get; }

    public SalesmanTypeCreatedEvent(SalesmanTypeId salesmantypeId)
    {
        SalesmanTypeId = salesmantypeId;
    }
}

public sealed class SalesmanTypeUpdatedEvent : DomainEvent
{
    public SalesmanTypeId SalesmanTypeId { get; }

    public SalesmanTypeUpdatedEvent(SalesmanTypeId salesmantypeId)
    {
        SalesmanTypeId = salesmantypeId;
    }
}

public sealed class SalesmanTypeDeletedEvent : DomainEvent
{
    public SalesmanTypeId SalesmanTypeId { get; }

    public SalesmanTypeDeletedEvent(SalesmanTypeId salesmantypeId)
    {
        SalesmanTypeId = salesmantypeId;
    }
}
}
