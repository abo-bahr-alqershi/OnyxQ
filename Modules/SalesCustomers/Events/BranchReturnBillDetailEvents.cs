using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchReturnBillDetail entity
/// </summary>
public sealed class BranchReturnBillDetailCreatedEvent : DomainEvent
{
    public BranchReturnBillDetailId BranchReturnBillDetailId { get; }

    public BranchReturnBillDetailCreatedEvent(BranchReturnBillDetailId branchreturnbilldetailId)
    {
        BranchReturnBillDetailId = branchreturnbilldetailId;
    }
}

public sealed class BranchReturnBillDetailUpdatedEvent : DomainEvent
{
    public BranchReturnBillDetailId BranchReturnBillDetailId { get; }

    public BranchReturnBillDetailUpdatedEvent(BranchReturnBillDetailId branchreturnbilldetailId)
    {
        BranchReturnBillDetailId = branchreturnbilldetailId;
    }
}

public sealed class BranchReturnBillDetailDeletedEvent : DomainEvent
{
    public BranchReturnBillDetailId BranchReturnBillDetailId { get; }

    public BranchReturnBillDetailDeletedEvent(BranchReturnBillDetailId branchreturnbilldetailId)
    {
        BranchReturnBillDetailId = branchreturnbilldetailId;
    }
}
}
