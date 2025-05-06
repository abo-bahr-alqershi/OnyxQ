using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerClaimVisit entity
/// </summary>
public sealed class CustomerClaimVisitCreatedEvent : DomainEvent
{
    public CustomerClaimVisitId CustomerClaimVisitId { get; }

    public CustomerClaimVisitCreatedEvent(CustomerClaimVisitId customerclaimvisitId)
    {
        CustomerClaimVisitId = customerclaimvisitId;
    }
}

public sealed class CustomerClaimVisitUpdatedEvent : DomainEvent
{
    public CustomerClaimVisitId CustomerClaimVisitId { get; }

    public CustomerClaimVisitUpdatedEvent(CustomerClaimVisitId customerclaimvisitId)
    {
        CustomerClaimVisitId = customerclaimvisitId;
    }
}

public sealed class CustomerClaimVisitDeletedEvent : DomainEvent
{
    public CustomerClaimVisitId CustomerClaimVisitId { get; }

    public CustomerClaimVisitDeletedEvent(CustomerClaimVisitId customerclaimvisitId)
    {
        CustomerClaimVisitId = customerclaimvisitId;
    }
}
}
