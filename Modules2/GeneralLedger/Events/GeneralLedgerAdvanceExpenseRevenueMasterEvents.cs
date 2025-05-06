using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerAdvanceExpenseRevenueMaster entity
/// </summary>
public sealed class GeneralLedgerAdvanceExpenseRevenueMasterCreatedEvent : DomainEvent
{
    public GeneralLedgerAdvanceExpenseRevenueMasterId GeneralLedgerAdvanceExpenseRevenueMasterId { get; }

    public GeneralLedgerAdvanceExpenseRevenueMasterCreatedEvent(GeneralLedgerAdvanceExpenseRevenueMasterId generalledgeradvanceexpenserevenuemasterId)
    {
        GeneralLedgerAdvanceExpenseRevenueMasterId = generalledgeradvanceexpenserevenuemasterId;
    }
}

public sealed class GeneralLedgerAdvanceExpenseRevenueMasterUpdatedEvent : DomainEvent
{
    public GeneralLedgerAdvanceExpenseRevenueMasterId GeneralLedgerAdvanceExpenseRevenueMasterId { get; }

    public GeneralLedgerAdvanceExpenseRevenueMasterUpdatedEvent(GeneralLedgerAdvanceExpenseRevenueMasterId generalledgeradvanceexpenserevenuemasterId)
    {
        GeneralLedgerAdvanceExpenseRevenueMasterId = generalledgeradvanceexpenserevenuemasterId;
    }
}

public sealed class GeneralLedgerAdvanceExpenseRevenueMasterDeletedEvent : DomainEvent
{
    public GeneralLedgerAdvanceExpenseRevenueMasterId GeneralLedgerAdvanceExpenseRevenueMasterId { get; }

    public GeneralLedgerAdvanceExpenseRevenueMasterDeletedEvent(GeneralLedgerAdvanceExpenseRevenueMasterId generalledgeradvanceexpenserevenuemasterId)
    {
        GeneralLedgerAdvanceExpenseRevenueMasterId = generalledgeradvanceexpenserevenuemasterId;
    }
}
}
