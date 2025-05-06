using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerCashflowField entity
/// </summary>
public sealed class GeneralLedgerCashflowFieldCreatedEvent : DomainEvent
{
    public GeneralLedgerCashflowFieldId GeneralLedgerCashflowFieldId { get; }

    public GeneralLedgerCashflowFieldCreatedEvent(GeneralLedgerCashflowFieldId generalledgercashflowfieldId)
    {
        GeneralLedgerCashflowFieldId = generalledgercashflowfieldId;
    }
}

public sealed class GeneralLedgerCashflowFieldUpdatedEvent : DomainEvent
{
    public GeneralLedgerCashflowFieldId GeneralLedgerCashflowFieldId { get; }

    public GeneralLedgerCashflowFieldUpdatedEvent(GeneralLedgerCashflowFieldId generalledgercashflowfieldId)
    {
        GeneralLedgerCashflowFieldId = generalledgercashflowfieldId;
    }
}

public sealed class GeneralLedgerCashflowFieldDeletedEvent : DomainEvent
{
    public GeneralLedgerCashflowFieldId GeneralLedgerCashflowFieldId { get; }

    public GeneralLedgerCashflowFieldDeletedEvent(GeneralLedgerCashflowFieldId generalledgercashflowfieldId)
    {
        GeneralLedgerCashflowFieldId = generalledgercashflowfieldId;
    }
}
}
