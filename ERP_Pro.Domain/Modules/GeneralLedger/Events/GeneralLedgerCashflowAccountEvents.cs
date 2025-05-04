using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerCashflowAccount entity
/// </summary>
public sealed class GeneralLedgerCashflowAccountCreatedEvent : DomainEvent
{
    public GeneralLedgerCashflowAccountId GeneralLedgerCashflowAccountId { get; }

    public GeneralLedgerCashflowAccountCreatedEvent(GeneralLedgerCashflowAccountId generalledgercashflowaccountId)
    {
        GeneralLedgerCashflowAccountId = generalledgercashflowaccountId;
    }
}

public sealed class GeneralLedgerCashflowAccountUpdatedEvent : DomainEvent
{
    public GeneralLedgerCashflowAccountId GeneralLedgerCashflowAccountId { get; }

    public GeneralLedgerCashflowAccountUpdatedEvent(GeneralLedgerCashflowAccountId generalledgercashflowaccountId)
    {
        GeneralLedgerCashflowAccountId = generalledgercashflowaccountId;
    }
}

public sealed class GeneralLedgerCashflowAccountDeletedEvent : DomainEvent
{
    public GeneralLedgerCashflowAccountId GeneralLedgerCashflowAccountId { get; }

    public GeneralLedgerCashflowAccountDeletedEvent(GeneralLedgerCashflowAccountId generalledgercashflowaccountId)
    {
        GeneralLedgerCashflowAccountId = generalledgercashflowaccountId;
    }
}
}
