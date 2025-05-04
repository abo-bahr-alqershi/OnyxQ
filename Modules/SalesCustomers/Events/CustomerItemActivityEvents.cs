using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerItemActivity entity
/// </summary>
public sealed class CustomerItemActivityCreatedEvent : DomainEvent
{
    public CustomerItemActivityId CustomerItemActivityId { get; }

    public CustomerItemActivityCreatedEvent(CustomerItemActivityId customeritemactivityId)
    {
        CustomerItemActivityId = customeritemactivityId;
    }
}

public sealed class CustomerItemActivityUpdatedEvent : DomainEvent
{
    public CustomerItemActivityId CustomerItemActivityId { get; }

    public CustomerItemActivityUpdatedEvent(CustomerItemActivityId customeritemactivityId)
    {
        CustomerItemActivityId = customeritemactivityId;
    }
}

public sealed class CustomerItemActivityDeletedEvent : DomainEvent
{
    public CustomerItemActivityId CustomerItemActivityId { get; }

    public CustomerItemActivityDeletedEvent(CustomerItemActivityId customeritemactivityId)
    {
        CustomerItemActivityId = customeritemactivityId;
    }
}
}
