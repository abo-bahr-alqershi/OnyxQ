using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerCashflowFieldDetail entity
/// </summary>
public sealed class GeneralLedgerCashflowFieldDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerCashflowFieldDetailId GeneralLedgerCashflowFieldDetailId { get; }

    public GeneralLedgerCashflowFieldDetailCreatedEvent(GeneralLedgerCashflowFieldDetailId generalledgercashflowfielddetailId)
    {
        GeneralLedgerCashflowFieldDetailId = generalledgercashflowfielddetailId;
    }
}

public sealed class GeneralLedgerCashflowFieldDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerCashflowFieldDetailId GeneralLedgerCashflowFieldDetailId { get; }

    public GeneralLedgerCashflowFieldDetailUpdatedEvent(GeneralLedgerCashflowFieldDetailId generalledgercashflowfielddetailId)
    {
        GeneralLedgerCashflowFieldDetailId = generalledgercashflowfielddetailId;
    }
}

public sealed class GeneralLedgerCashflowFieldDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerCashflowFieldDetailId GeneralLedgerCashflowFieldDetailId { get; }

    public GeneralLedgerCashflowFieldDetailDeletedEvent(GeneralLedgerCashflowFieldDetailId generalledgercashflowfielddetailId)
    {
        GeneralLedgerCashflowFieldDetailId = generalledgercashflowfielddetailId;
    }
}
}
