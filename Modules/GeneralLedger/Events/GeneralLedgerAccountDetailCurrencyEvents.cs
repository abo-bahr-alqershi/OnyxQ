using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerAccountDetailCurrency entity
/// </summary>
public sealed class GeneralLedgerAccountDetailCurrencyCreatedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailCurrencyId GeneralLedgerAccountDetailCurrencyId { get; }

    public GeneralLedgerAccountDetailCurrencyCreatedEvent(GeneralLedgerAccountDetailCurrencyId generalledgeraccountdetailcurrencyId)
    {
        GeneralLedgerAccountDetailCurrencyId = generalledgeraccountdetailcurrencyId;
    }
}

public sealed class GeneralLedgerAccountDetailCurrencyUpdatedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailCurrencyId GeneralLedgerAccountDetailCurrencyId { get; }

    public GeneralLedgerAccountDetailCurrencyUpdatedEvent(GeneralLedgerAccountDetailCurrencyId generalledgeraccountdetailcurrencyId)
    {
        GeneralLedgerAccountDetailCurrencyId = generalledgeraccountdetailcurrencyId;
    }
}

public sealed class GeneralLedgerAccountDetailCurrencyDeletedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailCurrencyId GeneralLedgerAccountDetailCurrencyId { get; }

    public GeneralLedgerAccountDetailCurrencyDeletedEvent(GeneralLedgerAccountDetailCurrencyId generalledgeraccountdetailcurrencyId)
    {
        GeneralLedgerAccountDetailCurrencyId = generalledgeraccountdetailcurrencyId;
    }
}
}
