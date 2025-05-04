using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BranchJournalVoucherMaster entity
/// </summary>
public sealed class BranchJournalVoucherMasterCreatedEvent : DomainEvent
{
    public BranchJournalVoucherMasterId BranchJournalVoucherMasterId { get; }

    public BranchJournalVoucherMasterCreatedEvent(BranchJournalVoucherMasterId branchjournalvouchermasterId)
    {
        BranchJournalVoucherMasterId = branchjournalvouchermasterId;
    }
}

public sealed class BranchJournalVoucherMasterUpdatedEvent : DomainEvent
{
    public BranchJournalVoucherMasterId BranchJournalVoucherMasterId { get; }

    public BranchJournalVoucherMasterUpdatedEvent(BranchJournalVoucherMasterId branchjournalvouchermasterId)
    {
        BranchJournalVoucherMasterId = branchjournalvouchermasterId;
    }
}

public sealed class BranchJournalVoucherMasterDeletedEvent : DomainEvent
{
    public BranchJournalVoucherMasterId BranchJournalVoucherMasterId { get; }

    public BranchJournalVoucherMasterDeletedEvent(BranchJournalVoucherMasterId branchjournalvouchermasterId)
    {
        BranchJournalVoucherMasterId = branchjournalvouchermasterId;
    }
}
}
