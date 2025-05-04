using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchBillMaster entity
/// </summary>
public sealed class BranchBillMasterCreatedEvent : DomainEvent
{
    public BranchBillMasterId BranchBillMasterId { get; }

    public BranchBillMasterCreatedEvent(BranchBillMasterId branchbillmasterId)
    {
        BranchBillMasterId = branchbillmasterId;
    }
}

public sealed class BranchBillMasterUpdatedEvent : DomainEvent
{
    public BranchBillMasterId BranchBillMasterId { get; }

    public BranchBillMasterUpdatedEvent(BranchBillMasterId branchbillmasterId)
    {
        BranchBillMasterId = branchbillmasterId;
    }
}

public sealed class BranchBillMasterDeletedEvent : DomainEvent
{
    public BranchBillMasterId BranchBillMasterId { get; }

    public BranchBillMasterDeletedEvent(BranchBillMasterId branchbillmasterId)
    {
        BranchBillMasterId = branchbillmasterId;
    }
}
}
