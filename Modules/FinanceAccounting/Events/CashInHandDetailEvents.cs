using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CashInHandDetail entity
/// </summary>
public sealed class CashInHandDetailCreatedEvent : DomainEvent
{
    public CashInHandDetailId CashInHandDetailId { get; }

    public CashInHandDetailCreatedEvent(CashInHandDetailId cashinhanddetailId)
    {
        CashInHandDetailId = cashinhanddetailId;
    }
}

public sealed class CashInHandDetailUpdatedEvent : DomainEvent
{
    public CashInHandDetailId CashInHandDetailId { get; }

    public CashInHandDetailUpdatedEvent(CashInHandDetailId cashinhanddetailId)
    {
        CashInHandDetailId = cashinhanddetailId;
    }
}

public sealed class CashInHandDetailDeletedEvent : DomainEvent
{
    public CashInHandDetailId CashInHandDetailId { get; }

    public CashInHandDetailDeletedEvent(CashInHandDetailId cashinhanddetailId)
    {
        CashInHandDetailId = cashinhanddetailId;
    }
}
}
