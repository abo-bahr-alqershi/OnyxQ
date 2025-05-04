using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BankAdjustmentMaster entity
/// </summary>
public sealed class BankAdjustmentMasterCreatedEvent : DomainEvent
{
    public BankAdjustmentMasterId BankAdjustmentMasterId { get; }

    public BankAdjustmentMasterCreatedEvent(BankAdjustmentMasterId bankadjustmentmasterId)
    {
        BankAdjustmentMasterId = bankadjustmentmasterId;
    }
}

public sealed class BankAdjustmentMasterUpdatedEvent : DomainEvent
{
    public BankAdjustmentMasterId BankAdjustmentMasterId { get; }

    public BankAdjustmentMasterUpdatedEvent(BankAdjustmentMasterId bankadjustmentmasterId)
    {
        BankAdjustmentMasterId = bankadjustmentmasterId;
    }
}

public sealed class BankAdjustmentMasterDeletedEvent : DomainEvent
{
    public BankAdjustmentMasterId BankAdjustmentMasterId { get; }

    public BankAdjustmentMasterDeletedEvent(BankAdjustmentMasterId bankadjustmentmasterId)
    {
        BankAdjustmentMasterId = bankadjustmentmasterId;
    }
}
}
