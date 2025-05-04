using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerCashflowDetail entity
/// </summary>
public sealed class GeneralLedgerCashflowDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerCashflowDetailId GeneralLedgerCashflowDetailId { get; }

    public GeneralLedgerCashflowDetailCreatedEvent(GeneralLedgerCashflowDetailId generalledgercashflowdetailId)
    {
        GeneralLedgerCashflowDetailId = generalledgercashflowdetailId;
    }
}

public sealed class GeneralLedgerCashflowDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerCashflowDetailId GeneralLedgerCashflowDetailId { get; }

    public GeneralLedgerCashflowDetailUpdatedEvent(GeneralLedgerCashflowDetailId generalledgercashflowdetailId)
    {
        GeneralLedgerCashflowDetailId = generalledgercashflowdetailId;
    }
}

public sealed class GeneralLedgerCashflowDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerCashflowDetailId GeneralLedgerCashflowDetailId { get; }

    public GeneralLedgerCashflowDetailDeletedEvent(GeneralLedgerCashflowDetailId generalledgercashflowdetailId)
    {
        GeneralLedgerCashflowDetailId = generalledgercashflowdetailId;
    }
}
}
