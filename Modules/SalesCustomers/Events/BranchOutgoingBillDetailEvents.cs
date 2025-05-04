using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchOutgoingBillDetail entity
/// </summary>
public sealed class BranchOutgoingBillDetailCreatedEvent : DomainEvent
{
    public BranchOutgoingBillDetailId BranchOutgoingBillDetailId { get; }

    public BranchOutgoingBillDetailCreatedEvent(BranchOutgoingBillDetailId branchoutgoingbilldetailId)
    {
        BranchOutgoingBillDetailId = branchoutgoingbilldetailId;
    }
}

public sealed class BranchOutgoingBillDetailUpdatedEvent : DomainEvent
{
    public BranchOutgoingBillDetailId BranchOutgoingBillDetailId { get; }

    public BranchOutgoingBillDetailUpdatedEvent(BranchOutgoingBillDetailId branchoutgoingbilldetailId)
    {
        BranchOutgoingBillDetailId = branchoutgoingbilldetailId;
    }
}

public sealed class BranchOutgoingBillDetailDeletedEvent : DomainEvent
{
    public BranchOutgoingBillDetailId BranchOutgoingBillDetailId { get; }

    public BranchOutgoingBillDetailDeletedEvent(BranchOutgoingBillDetailId branchoutgoingbilldetailId)
    {
        BranchOutgoingBillDetailId = branchoutgoingbilldetailId;
    }
}
}
