using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BranchOutgoingDetail entity
/// </summary>
public sealed class BranchOutgoingDetailCreatedEvent : DomainEvent
{
    public BranchOutgoingDetailId BranchOutgoingDetailId { get; }

    public BranchOutgoingDetailCreatedEvent(BranchOutgoingDetailId branchoutgoingdetailId)
    {
        BranchOutgoingDetailId = branchoutgoingdetailId;
    }
}

public sealed class BranchOutgoingDetailUpdatedEvent : DomainEvent
{
    public BranchOutgoingDetailId BranchOutgoingDetailId { get; }

    public BranchOutgoingDetailUpdatedEvent(BranchOutgoingDetailId branchoutgoingdetailId)
    {
        BranchOutgoingDetailId = branchoutgoingdetailId;
    }
}

public sealed class BranchOutgoingDetailDeletedEvent : DomainEvent
{
    public BranchOutgoingDetailId BranchOutgoingDetailId { get; }

    public BranchOutgoingDetailDeletedEvent(BranchOutgoingDetailId branchoutgoingdetailId)
    {
        BranchOutgoingDetailId = branchoutgoingdetailId;
    }
}
}
