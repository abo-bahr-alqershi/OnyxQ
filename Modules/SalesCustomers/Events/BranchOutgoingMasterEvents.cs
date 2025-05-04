using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchOutgoingMaster entity
/// </summary>
public sealed class BranchOutgoingMasterCreatedEvent : DomainEvent
{
    public BranchOutgoingMasterId BranchOutgoingMasterId { get; }

    public BranchOutgoingMasterCreatedEvent(BranchOutgoingMasterId branchoutgoingmasterId)
    {
        BranchOutgoingMasterId = branchoutgoingmasterId;
    }
}

public sealed class BranchOutgoingMasterUpdatedEvent : DomainEvent
{
    public BranchOutgoingMasterId BranchOutgoingMasterId { get; }

    public BranchOutgoingMasterUpdatedEvent(BranchOutgoingMasterId branchoutgoingmasterId)
    {
        BranchOutgoingMasterId = branchoutgoingmasterId;
    }
}

public sealed class BranchOutgoingMasterDeletedEvent : DomainEvent
{
    public BranchOutgoingMasterId BranchOutgoingMasterId { get; }

    public BranchOutgoingMasterDeletedEvent(BranchOutgoingMasterId branchoutgoingmasterId)
    {
        BranchOutgoingMasterId = branchoutgoingmasterId;
    }
}
}
