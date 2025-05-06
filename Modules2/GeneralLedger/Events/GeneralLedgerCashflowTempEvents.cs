using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerCashflowTemp entity
/// </summary>
public sealed class GeneralLedgerCashflowTempCreatedEvent : DomainEvent
{
    public GeneralLedgerCashflowTempId GeneralLedgerCashflowTempId { get; }

    public GeneralLedgerCashflowTempCreatedEvent(GeneralLedgerCashflowTempId generalledgercashflowtempId)
    {
        GeneralLedgerCashflowTempId = generalledgercashflowtempId;
    }
}

public sealed class GeneralLedgerCashflowTempUpdatedEvent : DomainEvent
{
    public GeneralLedgerCashflowTempId GeneralLedgerCashflowTempId { get; }

    public GeneralLedgerCashflowTempUpdatedEvent(GeneralLedgerCashflowTempId generalledgercashflowtempId)
    {
        GeneralLedgerCashflowTempId = generalledgercashflowtempId;
    }
}

public sealed class GeneralLedgerCashflowTempDeletedEvent : DomainEvent
{
    public GeneralLedgerCashflowTempId GeneralLedgerCashflowTempId { get; }

    public GeneralLedgerCashflowTempDeletedEvent(GeneralLedgerCashflowTempId generalledgercashflowtempId)
    {
        GeneralLedgerCashflowTempId = generalledgercashflowtempId;
    }
}
}
