using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerEditBudgetBalanceMaster entity
/// </summary>
public sealed class GeneralLedgerEditBudgetBalanceMasterCreatedEvent : DomainEvent
{
    public GeneralLedgerEditBudgetBalanceMasterId GeneralLedgerEditBudgetBalanceMasterId { get; }

    public GeneralLedgerEditBudgetBalanceMasterCreatedEvent(GeneralLedgerEditBudgetBalanceMasterId generalledgereditbudgetbalancemasterId)
    {
        GeneralLedgerEditBudgetBalanceMasterId = generalledgereditbudgetbalancemasterId;
    }
}

public sealed class GeneralLedgerEditBudgetBalanceMasterUpdatedEvent : DomainEvent
{
    public GeneralLedgerEditBudgetBalanceMasterId GeneralLedgerEditBudgetBalanceMasterId { get; }

    public GeneralLedgerEditBudgetBalanceMasterUpdatedEvent(GeneralLedgerEditBudgetBalanceMasterId generalledgereditbudgetbalancemasterId)
    {
        GeneralLedgerEditBudgetBalanceMasterId = generalledgereditbudgetbalancemasterId;
    }
}

public sealed class GeneralLedgerEditBudgetBalanceMasterDeletedEvent : DomainEvent
{
    public GeneralLedgerEditBudgetBalanceMasterId GeneralLedgerEditBudgetBalanceMasterId { get; }

    public GeneralLedgerEditBudgetBalanceMasterDeletedEvent(GeneralLedgerEditBudgetBalanceMasterId generalledgereditbudgetbalancemasterId)
    {
        GeneralLedgerEditBudgetBalanceMasterId = generalledgereditbudgetbalancemasterId;
    }
}
}
