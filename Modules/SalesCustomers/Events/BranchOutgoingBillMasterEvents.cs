using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchOutgoingBillMaster entity
/// </summary>
public sealed class BranchOutgoingBillMasterCreatedEvent : DomainEvent
{
    public BranchOutgoingBillMasterId BranchOutgoingBillMasterId { get; }

    public BranchOutgoingBillMasterCreatedEvent(BranchOutgoingBillMasterId branchoutgoingbillmasterId)
    {
        BranchOutgoingBillMasterId = branchoutgoingbillmasterId;
    }
}

public sealed class BranchOutgoingBillMasterUpdatedEvent : DomainEvent
{
    public BranchOutgoingBillMasterId BranchOutgoingBillMasterId { get; }

    public BranchOutgoingBillMasterUpdatedEvent(BranchOutgoingBillMasterId branchoutgoingbillmasterId)
    {
        BranchOutgoingBillMasterId = branchoutgoingbillmasterId;
    }
}

public sealed class BranchOutgoingBillMasterDeletedEvent : DomainEvent
{
    public BranchOutgoingBillMasterId BranchOutgoingBillMasterId { get; }

    public BranchOutgoingBillMasterDeletedEvent(BranchOutgoingBillMasterId branchoutgoingbillmasterId)
    {
        BranchOutgoingBillMasterId = branchoutgoingbillmasterId;
    }
}
}
