using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerMoveBudgetMaster entity
/// </summary>
public sealed class GeneralLedgerMoveBudgetMasterCreatedEvent : DomainEvent
{
    public GeneralLedgerMoveBudgetMasterId GeneralLedgerMoveBudgetMasterId { get; }

    public GeneralLedgerMoveBudgetMasterCreatedEvent(GeneralLedgerMoveBudgetMasterId generalledgermovebudgetmasterId)
    {
        GeneralLedgerMoveBudgetMasterId = generalledgermovebudgetmasterId;
    }
}

public sealed class GeneralLedgerMoveBudgetMasterUpdatedEvent : DomainEvent
{
    public GeneralLedgerMoveBudgetMasterId GeneralLedgerMoveBudgetMasterId { get; }

    public GeneralLedgerMoveBudgetMasterUpdatedEvent(GeneralLedgerMoveBudgetMasterId generalledgermovebudgetmasterId)
    {
        GeneralLedgerMoveBudgetMasterId = generalledgermovebudgetmasterId;
    }
}

public sealed class GeneralLedgerMoveBudgetMasterDeletedEvent : DomainEvent
{
    public GeneralLedgerMoveBudgetMasterId GeneralLedgerMoveBudgetMasterId { get; }

    public GeneralLedgerMoveBudgetMasterDeletedEvent(GeneralLedgerMoveBudgetMasterId generalledgermovebudgetmasterId)
    {
        GeneralLedgerMoveBudgetMasterId = generalledgermovebudgetmasterId;
    }
}
}
