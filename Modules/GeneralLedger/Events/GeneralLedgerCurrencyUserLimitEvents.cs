using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerCurrencyUserLimit entity
/// </summary>
public sealed class GeneralLedgerCurrencyUserLimitCreatedEvent : DomainEvent
{
    public GeneralLedgerCurrencyUserLimitId GeneralLedgerCurrencyUserLimitId { get; }

    public GeneralLedgerCurrencyUserLimitCreatedEvent(GeneralLedgerCurrencyUserLimitId generalledgercurrencyuserlimitId)
    {
        GeneralLedgerCurrencyUserLimitId = generalledgercurrencyuserlimitId;
    }
}

public sealed class GeneralLedgerCurrencyUserLimitUpdatedEvent : DomainEvent
{
    public GeneralLedgerCurrencyUserLimitId GeneralLedgerCurrencyUserLimitId { get; }

    public GeneralLedgerCurrencyUserLimitUpdatedEvent(GeneralLedgerCurrencyUserLimitId generalledgercurrencyuserlimitId)
    {
        GeneralLedgerCurrencyUserLimitId = generalledgercurrencyuserlimitId;
    }
}

public sealed class GeneralLedgerCurrencyUserLimitDeletedEvent : DomainEvent
{
    public GeneralLedgerCurrencyUserLimitId GeneralLedgerCurrencyUserLimitId { get; }

    public GeneralLedgerCurrencyUserLimitDeletedEvent(GeneralLedgerCurrencyUserLimitId generalledgercurrencyuserlimitId)
    {
        GeneralLedgerCurrencyUserLimitId = generalledgercurrencyuserlimitId;
    }
}
}
