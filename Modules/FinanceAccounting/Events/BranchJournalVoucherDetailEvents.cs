using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BranchJournalVoucherDetail entity
/// </summary>
public sealed class BranchJournalVoucherDetailCreatedEvent : DomainEvent
{
    public BranchJournalVoucherDetailId BranchJournalVoucherDetailId { get; }

    public BranchJournalVoucherDetailCreatedEvent(BranchJournalVoucherDetailId branchjournalvoucherdetailId)
    {
        BranchJournalVoucherDetailId = branchjournalvoucherdetailId;
    }
}

public sealed class BranchJournalVoucherDetailUpdatedEvent : DomainEvent
{
    public BranchJournalVoucherDetailId BranchJournalVoucherDetailId { get; }

    public BranchJournalVoucherDetailUpdatedEvent(BranchJournalVoucherDetailId branchjournalvoucherdetailId)
    {
        BranchJournalVoucherDetailId = branchjournalvoucherdetailId;
    }
}

public sealed class BranchJournalVoucherDetailDeletedEvent : DomainEvent
{
    public BranchJournalVoucherDetailId BranchJournalVoucherDetailId { get; }

    public BranchJournalVoucherDetailDeletedEvent(BranchJournalVoucherDetailId branchjournalvoucherdetailId)
    {
        BranchJournalVoucherDetailId = branchjournalvoucherdetailId;
    }
}
}
