using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerEditBudgetBalanceDetail entity
/// </summary>
public sealed class GeneralLedgerEditBudgetBalanceDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerEditBudgetBalanceDetailId GeneralLedgerEditBudgetBalanceDetailId { get; }

    public GeneralLedgerEditBudgetBalanceDetailCreatedEvent(GeneralLedgerEditBudgetBalanceDetailId generalledgereditbudgetbalancedetailId)
    {
        GeneralLedgerEditBudgetBalanceDetailId = generalledgereditbudgetbalancedetailId;
    }
}

public sealed class GeneralLedgerEditBudgetBalanceDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerEditBudgetBalanceDetailId GeneralLedgerEditBudgetBalanceDetailId { get; }

    public GeneralLedgerEditBudgetBalanceDetailUpdatedEvent(GeneralLedgerEditBudgetBalanceDetailId generalledgereditbudgetbalancedetailId)
    {
        GeneralLedgerEditBudgetBalanceDetailId = generalledgereditbudgetbalancedetailId;
    }
}

public sealed class GeneralLedgerEditBudgetBalanceDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerEditBudgetBalanceDetailId GeneralLedgerEditBudgetBalanceDetailId { get; }

    public GeneralLedgerEditBudgetBalanceDetailDeletedEvent(GeneralLedgerEditBudgetBalanceDetailId generalledgereditbudgetbalancedetailId)
    {
        GeneralLedgerEditBudgetBalanceDetailId = generalledgereditbudgetbalancedetailId;
    }
}
}
