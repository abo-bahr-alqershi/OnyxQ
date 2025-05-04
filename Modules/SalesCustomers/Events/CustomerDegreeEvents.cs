using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerDegree entity
/// </summary>
public sealed class CustomerDegreeCreatedEvent : DomainEvent
{
    public CustomerDegreeId CustomerDegreeId { get; }

    public CustomerDegreeCreatedEvent(CustomerDegreeId customerdegreeId)
    {
        CustomerDegreeId = customerdegreeId;
    }
}

public sealed class CustomerDegreeUpdatedEvent : DomainEvent
{
    public CustomerDegreeId CustomerDegreeId { get; }

    public CustomerDegreeUpdatedEvent(CustomerDegreeId customerdegreeId)
    {
        CustomerDegreeId = customerdegreeId;
    }
}

public sealed class CustomerDegreeDeletedEvent : DomainEvent
{
    public CustomerDegreeId CustomerDegreeId { get; }

    public CustomerDegreeDeletedEvent(CustomerDegreeId customerdegreeId)
    {
        CustomerDegreeId = customerdegreeId;
    }
}
}
