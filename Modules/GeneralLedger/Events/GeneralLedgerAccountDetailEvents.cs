using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerAccountDetail entity
/// </summary>
public sealed class GeneralLedgerAccountDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailId GeneralLedgerAccountDetailId { get; }

    public GeneralLedgerAccountDetailCreatedEvent(GeneralLedgerAccountDetailId generalledgeraccountdetailId)
    {
        GeneralLedgerAccountDetailId = generalledgeraccountdetailId;
    }
}

public sealed class GeneralLedgerAccountDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailId GeneralLedgerAccountDetailId { get; }

    public GeneralLedgerAccountDetailUpdatedEvent(GeneralLedgerAccountDetailId generalledgeraccountdetailId)
    {
        GeneralLedgerAccountDetailId = generalledgeraccountdetailId;
    }
}

public sealed class GeneralLedgerAccountDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailId GeneralLedgerAccountDetailId { get; }

    public GeneralLedgerAccountDetailDeletedEvent(GeneralLedgerAccountDetailId generalledgeraccountdetailId)
    {
        GeneralLedgerAccountDetailId = generalledgeraccountdetailId;
    }
}
}
