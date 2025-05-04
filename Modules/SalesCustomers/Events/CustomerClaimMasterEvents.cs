using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerClaimMaster entity
/// </summary>
public sealed class CustomerClaimMasterCreatedEvent : DomainEvent
{
    public CustomerClaimMasterId CustomerClaimMasterId { get; }

    public CustomerClaimMasterCreatedEvent(CustomerClaimMasterId customerclaimmasterId)
    {
        CustomerClaimMasterId = customerclaimmasterId;
    }
}

public sealed class CustomerClaimMasterUpdatedEvent : DomainEvent
{
    public CustomerClaimMasterId CustomerClaimMasterId { get; }

    public CustomerClaimMasterUpdatedEvent(CustomerClaimMasterId customerclaimmasterId)
    {
        CustomerClaimMasterId = customerclaimmasterId;
    }
}

public sealed class CustomerClaimMasterDeletedEvent : DomainEvent
{
    public CustomerClaimMasterId CustomerClaimMasterId { get; }

    public CustomerClaimMasterDeletedEvent(CustomerClaimMasterId customerclaimmasterId)
    {
        CustomerClaimMasterId = customerclaimmasterId;
    }
}
}
