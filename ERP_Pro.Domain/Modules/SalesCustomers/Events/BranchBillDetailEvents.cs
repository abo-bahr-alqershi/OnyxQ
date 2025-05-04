using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchBillDetail entity
/// </summary>
public sealed class BranchBillDetailCreatedEvent : DomainEvent
{
    public BranchBillDetailId BranchBillDetailId { get; }

    public BranchBillDetailCreatedEvent(BranchBillDetailId branchbilldetailId)
    {
        BranchBillDetailId = branchbilldetailId;
    }
}

public sealed class BranchBillDetailUpdatedEvent : DomainEvent
{
    public BranchBillDetailId BranchBillDetailId { get; }

    public BranchBillDetailUpdatedEvent(BranchBillDetailId branchbilldetailId)
    {
        BranchBillDetailId = branchbilldetailId;
    }
}

public sealed class BranchBillDetailDeletedEvent : DomainEvent
{
    public BranchBillDetailId BranchBillDetailId { get; }

    public BranchBillDetailDeletedEvent(BranchBillDetailId branchbilldetailId)
    {
        BranchBillDetailId = branchbilldetailId;
    }
}
}
