using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AccountConfirmBalanceDetail entity
/// </summary>
public sealed class AccountConfirmBalanceDetailCreatedEvent : DomainEvent
{
    public AccountConfirmBalanceDetailId AccountConfirmBalanceDetailId { get; }

    public AccountConfirmBalanceDetailCreatedEvent(AccountConfirmBalanceDetailId accountconfirmbalancedetailId)
    {
        AccountConfirmBalanceDetailId = accountconfirmbalancedetailId;
    }
}

public sealed class AccountConfirmBalanceDetailUpdatedEvent : DomainEvent
{
    public AccountConfirmBalanceDetailId AccountConfirmBalanceDetailId { get; }

    public AccountConfirmBalanceDetailUpdatedEvent(AccountConfirmBalanceDetailId accountconfirmbalancedetailId)
    {
        AccountConfirmBalanceDetailId = accountconfirmbalancedetailId;
    }
}

public sealed class AccountConfirmBalanceDetailDeletedEvent : DomainEvent
{
    public AccountConfirmBalanceDetailId AccountConfirmBalanceDetailId { get; }

    public AccountConfirmBalanceDetailDeletedEvent(AccountConfirmBalanceDetailId accountconfirmbalancedetailId)
    {
        AccountConfirmBalanceDetailId = accountconfirmbalancedetailId;
    }
}
}
