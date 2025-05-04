using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BankAdjustmentDetail entity
/// </summary>
public sealed class BankAdjustmentDetailCreatedEvent : DomainEvent
{
    public BankAdjustmentDetailId BankAdjustmentDetailId { get; }

    public BankAdjustmentDetailCreatedEvent(BankAdjustmentDetailId bankadjustmentdetailId)
    {
        BankAdjustmentDetailId = bankadjustmentdetailId;
    }
}

public sealed class BankAdjustmentDetailUpdatedEvent : DomainEvent
{
    public BankAdjustmentDetailId BankAdjustmentDetailId { get; }

    public BankAdjustmentDetailUpdatedEvent(BankAdjustmentDetailId bankadjustmentdetailId)
    {
        BankAdjustmentDetailId = bankadjustmentdetailId;
    }
}

public sealed class BankAdjustmentDetailDeletedEvent : DomainEvent
{
    public BankAdjustmentDetailId BankAdjustmentDetailId { get; }

    public BankAdjustmentDetailDeletedEvent(BankAdjustmentDetailId bankadjustmentdetailId)
    {
        BankAdjustmentDetailId = bankadjustmentdetailId;
    }
}
}
