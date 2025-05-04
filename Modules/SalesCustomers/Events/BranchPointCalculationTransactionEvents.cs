using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchPointCalculationTransaction entity
/// </summary>
public sealed class BranchPointCalculationTransactionCreatedEvent : DomainEvent
{
    public BranchPointCalculationTransactionId BranchPointCalculationTransactionId { get; }

    public BranchPointCalculationTransactionCreatedEvent(BranchPointCalculationTransactionId branchpointcalculationtransactionId)
    {
        BranchPointCalculationTransactionId = branchpointcalculationtransactionId;
    }
}

public sealed class BranchPointCalculationTransactionUpdatedEvent : DomainEvent
{
    public BranchPointCalculationTransactionId BranchPointCalculationTransactionId { get; }

    public BranchPointCalculationTransactionUpdatedEvent(BranchPointCalculationTransactionId branchpointcalculationtransactionId)
    {
        BranchPointCalculationTransactionId = branchpointcalculationtransactionId;
    }
}

public sealed class BranchPointCalculationTransactionDeletedEvent : DomainEvent
{
    public BranchPointCalculationTransactionId BranchPointCalculationTransactionId { get; }

    public BranchPointCalculationTransactionDeletedEvent(BranchPointCalculationTransactionId branchpointcalculationtransactionId)
    {
        BranchPointCalculationTransactionId = branchpointcalculationtransactionId;
    }
}
}
