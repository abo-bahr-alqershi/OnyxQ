using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerAdvanceExpenseRevenueDetail entity
/// </summary>
public sealed class GeneralLedgerAdvanceExpenseRevenueDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerAdvanceExpenseRevenueDetailId GeneralLedgerAdvanceExpenseRevenueDetailId { get; }

    public GeneralLedgerAdvanceExpenseRevenueDetailCreatedEvent(GeneralLedgerAdvanceExpenseRevenueDetailId generalledgeradvanceexpenserevenuedetailId)
    {
        GeneralLedgerAdvanceExpenseRevenueDetailId = generalledgeradvanceexpenserevenuedetailId;
    }
}

public sealed class GeneralLedgerAdvanceExpenseRevenueDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerAdvanceExpenseRevenueDetailId GeneralLedgerAdvanceExpenseRevenueDetailId { get; }

    public GeneralLedgerAdvanceExpenseRevenueDetailUpdatedEvent(GeneralLedgerAdvanceExpenseRevenueDetailId generalledgeradvanceexpenserevenuedetailId)
    {
        GeneralLedgerAdvanceExpenseRevenueDetailId = generalledgeradvanceexpenserevenuedetailId;
    }
}

public sealed class GeneralLedgerAdvanceExpenseRevenueDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerAdvanceExpenseRevenueDetailId GeneralLedgerAdvanceExpenseRevenueDetailId { get; }

    public GeneralLedgerAdvanceExpenseRevenueDetailDeletedEvent(GeneralLedgerAdvanceExpenseRevenueDetailId generalledgeradvanceexpenserevenuedetailId)
    {
        GeneralLedgerAdvanceExpenseRevenueDetailId = generalledgeradvanceexpenserevenuedetailId;
    }
}
}
