using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerCashflowMaster entity
/// </summary>
public sealed class GeneralLedgerCashflowMasterCreatedEvent : DomainEvent
{
    public GeneralLedgerCashflowMasterId GeneralLedgerCashflowMasterId { get; }

    public GeneralLedgerCashflowMasterCreatedEvent(GeneralLedgerCashflowMasterId generalledgercashflowmasterId)
    {
        GeneralLedgerCashflowMasterId = generalledgercashflowmasterId;
    }
}

public sealed class GeneralLedgerCashflowMasterUpdatedEvent : DomainEvent
{
    public GeneralLedgerCashflowMasterId GeneralLedgerCashflowMasterId { get; }

    public GeneralLedgerCashflowMasterUpdatedEvent(GeneralLedgerCashflowMasterId generalledgercashflowmasterId)
    {
        GeneralLedgerCashflowMasterId = generalledgercashflowmasterId;
    }
}

public sealed class GeneralLedgerCashflowMasterDeletedEvent : DomainEvent
{
    public GeneralLedgerCashflowMasterId GeneralLedgerCashflowMasterId { get; }

    public GeneralLedgerCashflowMasterDeletedEvent(GeneralLedgerCashflowMasterId generalledgercashflowmasterId)
    {
        GeneralLedgerCashflowMasterId = generalledgercashflowmasterId;
    }
}
}
