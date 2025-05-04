using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchReturnBillDetailRequest entity
/// </summary>
public sealed class BranchReturnBillDetailRequestCreatedEvent : DomainEvent
{
    public BranchReturnBillDetailRequestId BranchReturnBillDetailRequestId { get; }

    public BranchReturnBillDetailRequestCreatedEvent(BranchReturnBillDetailRequestId branchreturnbilldetailrequestId)
    {
        BranchReturnBillDetailRequestId = branchreturnbilldetailrequestId;
    }
}

public sealed class BranchReturnBillDetailRequestUpdatedEvent : DomainEvent
{
    public BranchReturnBillDetailRequestId BranchReturnBillDetailRequestId { get; }

    public BranchReturnBillDetailRequestUpdatedEvent(BranchReturnBillDetailRequestId branchreturnbilldetailrequestId)
    {
        BranchReturnBillDetailRequestId = branchreturnbilldetailrequestId;
    }
}

public sealed class BranchReturnBillDetailRequestDeletedEvent : DomainEvent
{
    public BranchReturnBillDetailRequestId BranchReturnBillDetailRequestId { get; }

    public BranchReturnBillDetailRequestDeletedEvent(BranchReturnBillDetailRequestId branchreturnbilldetailrequestId)
    {
        BranchReturnBillDetailRequestId = branchreturnbilldetailrequestId;
    }
}
}
