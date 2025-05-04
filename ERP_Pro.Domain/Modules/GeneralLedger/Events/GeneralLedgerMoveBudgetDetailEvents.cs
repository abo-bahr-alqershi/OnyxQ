using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerMoveBudgetDetail entity
/// </summary>
public sealed class GeneralLedgerMoveBudgetDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerMoveBudgetDetailId GeneralLedgerMoveBudgetDetailId { get; }

    public GeneralLedgerMoveBudgetDetailCreatedEvent(GeneralLedgerMoveBudgetDetailId generalledgermovebudgetdetailId)
    {
        GeneralLedgerMoveBudgetDetailId = generalledgermovebudgetdetailId;
    }
}

public sealed class GeneralLedgerMoveBudgetDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerMoveBudgetDetailId GeneralLedgerMoveBudgetDetailId { get; }

    public GeneralLedgerMoveBudgetDetailUpdatedEvent(GeneralLedgerMoveBudgetDetailId generalledgermovebudgetdetailId)
    {
        GeneralLedgerMoveBudgetDetailId = generalledgermovebudgetdetailId;
    }
}

public sealed class GeneralLedgerMoveBudgetDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerMoveBudgetDetailId GeneralLedgerMoveBudgetDetailId { get; }

    public GeneralLedgerMoveBudgetDetailDeletedEvent(GeneralLedgerMoveBudgetDetailId generalledgermovebudgetdetailId)
    {
        GeneralLedgerMoveBudgetDetailId = generalledgermovebudgetdetailId;
    }
}
}
