using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerClaimDetail entity
/// </summary>
public sealed class CustomerClaimDetailCreatedEvent : DomainEvent
{
    public CustomerClaimDetailId CustomerClaimDetailId { get; }

    public CustomerClaimDetailCreatedEvent(CustomerClaimDetailId customerclaimdetailId)
    {
        CustomerClaimDetailId = customerclaimdetailId;
    }
}

public sealed class CustomerClaimDetailUpdatedEvent : DomainEvent
{
    public CustomerClaimDetailId CustomerClaimDetailId { get; }

    public CustomerClaimDetailUpdatedEvent(CustomerClaimDetailId customerclaimdetailId)
    {
        CustomerClaimDetailId = customerclaimdetailId;
    }
}

public sealed class CustomerClaimDetailDeletedEvent : DomainEvent
{
    public CustomerClaimDetailId CustomerClaimDetailId { get; }

    public CustomerClaimDetailDeletedEvent(CustomerClaimDetailId customerclaimdetailId)
    {
        CustomerClaimDetailId = customerclaimdetailId;
    }
}
}
