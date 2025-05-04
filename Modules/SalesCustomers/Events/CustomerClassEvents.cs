using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerClass entity
/// </summary>
public sealed class CustomerClassCreatedEvent : DomainEvent
{
    public CustomerClassId CustomerClassId { get; }

    public CustomerClassCreatedEvent(CustomerClassId customerclassId)
    {
        CustomerClassId = customerclassId;
    }
}

public sealed class CustomerClassUpdatedEvent : DomainEvent
{
    public CustomerClassId CustomerClassId { get; }

    public CustomerClassUpdatedEvent(CustomerClassId customerclassId)
    {
        CustomerClassId = customerclassId;
    }
}

public sealed class CustomerClassDeletedEvent : DomainEvent
{
    public CustomerClassId CustomerClassId { get; }

    public CustomerClassDeletedEvent(CustomerClassId customerclassId)
    {
        CustomerClassId = customerclassId;
    }
}
}
