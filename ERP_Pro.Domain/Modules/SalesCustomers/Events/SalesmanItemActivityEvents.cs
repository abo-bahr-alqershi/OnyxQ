using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanItemActivity entity
/// </summary>
public sealed class SalesmanItemActivityCreatedEvent : DomainEvent
{
    public SalesmanItemActivityId SalesmanItemActivityId { get; }

    public SalesmanItemActivityCreatedEvent(SalesmanItemActivityId salesmanitemactivityId)
    {
        SalesmanItemActivityId = salesmanitemactivityId;
    }
}

public sealed class SalesmanItemActivityUpdatedEvent : DomainEvent
{
    public SalesmanItemActivityId SalesmanItemActivityId { get; }

    public SalesmanItemActivityUpdatedEvent(SalesmanItemActivityId salesmanitemactivityId)
    {
        SalesmanItemActivityId = salesmanitemactivityId;
    }
}

public sealed class SalesmanItemActivityDeletedEvent : DomainEvent
{
    public SalesmanItemActivityId SalesmanItemActivityId { get; }

    public SalesmanItemActivityDeletedEvent(SalesmanItemActivityId salesmanitemactivityId)
    {
        SalesmanItemActivityId = salesmanitemactivityId;
    }
}
}
