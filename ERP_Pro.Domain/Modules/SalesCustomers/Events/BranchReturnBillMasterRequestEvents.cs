using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchReturnBillMasterRequest entity
/// </summary>
public sealed class BranchReturnBillMasterRequestCreatedEvent : DomainEvent
{
    public BranchReturnBillMasterRequestId BranchReturnBillMasterRequestId { get; }

    public BranchReturnBillMasterRequestCreatedEvent(BranchReturnBillMasterRequestId branchreturnbillmasterrequestId)
    {
        BranchReturnBillMasterRequestId = branchreturnbillmasterrequestId;
    }
}

public sealed class BranchReturnBillMasterRequestUpdatedEvent : DomainEvent
{
    public BranchReturnBillMasterRequestId BranchReturnBillMasterRequestId { get; }

    public BranchReturnBillMasterRequestUpdatedEvent(BranchReturnBillMasterRequestId branchreturnbillmasterrequestId)
    {
        BranchReturnBillMasterRequestId = branchreturnbillmasterrequestId;
    }
}

public sealed class BranchReturnBillMasterRequestDeletedEvent : DomainEvent
{
    public BranchReturnBillMasterRequestId BranchReturnBillMasterRequestId { get; }

    public BranchReturnBillMasterRequestDeletedEvent(BranchReturnBillMasterRequestId branchreturnbillmasterrequestId)
    {
        BranchReturnBillMasterRequestId = branchreturnbillmasterrequestId;
    }
}
}
