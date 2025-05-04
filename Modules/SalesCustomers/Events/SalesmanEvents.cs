using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to Salesman entity
/// </summary>
public sealed class SalesmanCreatedEvent : DomainEvent
{
    public SalesmanId SalesmanId { get; }

    public SalesmanCreatedEvent(SalesmanId salesmanId)
    {
        SalesmanId = salesmanId;
    }
}

public sealed class SalesmanUpdatedEvent : DomainEvent
{
    public SalesmanId SalesmanId { get; }

    public SalesmanUpdatedEvent(SalesmanId salesmanId)
    {
        SalesmanId = salesmanId;
    }
}

public sealed class SalesmanDeletedEvent : DomainEvent
{
    public SalesmanId SalesmanId { get; }

    public SalesmanDeletedEvent(SalesmanId salesmanId)
    {
        SalesmanId = salesmanId;
    }
}
}
