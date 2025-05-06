using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchReturnBillMaster entity
/// </summary>
public sealed class BranchReturnBillMasterCreatedEvent : DomainEvent
{
    public BranchReturnBillMasterId BranchReturnBillMasterId { get; }

    public BranchReturnBillMasterCreatedEvent(BranchReturnBillMasterId branchreturnbillmasterId)
    {
        BranchReturnBillMasterId = branchreturnbillmasterId;
    }
}

public sealed class BranchReturnBillMasterUpdatedEvent : DomainEvent
{
    public BranchReturnBillMasterId BranchReturnBillMasterId { get; }

    public BranchReturnBillMasterUpdatedEvent(BranchReturnBillMasterId branchreturnbillmasterId)
    {
        BranchReturnBillMasterId = branchreturnbillmasterId;
    }
}

public sealed class BranchReturnBillMasterDeletedEvent : DomainEvent
{
    public BranchReturnBillMasterId BranchReturnBillMasterId { get; }

    public BranchReturnBillMasterDeletedEvent(BranchReturnBillMasterId branchreturnbillmasterId)
    {
        BranchReturnBillMasterId = branchreturnbillmasterId;
    }
}
}
