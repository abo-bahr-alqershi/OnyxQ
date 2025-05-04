using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BankCash entity
/// </summary>
public sealed class BankCashCreatedEvent : DomainEvent
{
    public BankCashId BankCashId { get; }

    public BankCashCreatedEvent(BankCashId bankcashId)
    {
        BankCashId = bankcashId;
    }
}

public sealed class BankCashUpdatedEvent : DomainEvent
{
    public BankCashId BankCashId { get; }

    public BankCashUpdatedEvent(BankCashId bankcashId)
    {
        BankCashId = bankcashId;
    }
}

public sealed class BankCashDeletedEvent : DomainEvent
{
    public BankCashId BankCashId { get; }

    public BankCashDeletedEvent(BankCashId bankcashId)
    {
        BankCashId = bankcashId;
    }
}
}
