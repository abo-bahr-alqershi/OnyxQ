using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to JudicialDocumentJournalVoucherTypeConnectAccount entity
/// </summary>
public sealed class JudicialDocumentJournalVoucherTypeConnectAccountCreatedEvent : DomainEvent
{
    public JudicialDocumentJournalVoucherTypeConnectAccountId JudicialDocumentJournalVoucherTypeConnectAccountId { get; }

    public JudicialDocumentJournalVoucherTypeConnectAccountCreatedEvent(JudicialDocumentJournalVoucherTypeConnectAccountId judicialdocumentjournalvouchertypeconnectaccountId)
    {
        JudicialDocumentJournalVoucherTypeConnectAccountId = judicialdocumentjournalvouchertypeconnectaccountId;
    }
}

public sealed class JudicialDocumentJournalVoucherTypeConnectAccountUpdatedEvent : DomainEvent
{
    public JudicialDocumentJournalVoucherTypeConnectAccountId JudicialDocumentJournalVoucherTypeConnectAccountId { get; }

    public JudicialDocumentJournalVoucherTypeConnectAccountUpdatedEvent(JudicialDocumentJournalVoucherTypeConnectAccountId judicialdocumentjournalvouchertypeconnectaccountId)
    {
        JudicialDocumentJournalVoucherTypeConnectAccountId = judicialdocumentjournalvouchertypeconnectaccountId;
    }
}

public sealed class JudicialDocumentJournalVoucherTypeConnectAccountDeletedEvent : DomainEvent
{
    public JudicialDocumentJournalVoucherTypeConnectAccountId JudicialDocumentJournalVoucherTypeConnectAccountId { get; }

    public JudicialDocumentJournalVoucherTypeConnectAccountDeletedEvent(JudicialDocumentJournalVoucherTypeConnectAccountId judicialdocumentjournalvouchertypeconnectaccountId)
    {
        JudicialDocumentJournalVoucherTypeConnectAccountId = judicialdocumentjournalvouchertypeconnectaccountId;
    }
}
}
