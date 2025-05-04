using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AccountConfirmBalanceMaster entity
/// </summary>
public sealed class AccountConfirmBalanceMasterCreatedEvent : DomainEvent
{
    public AccountConfirmBalanceMasterId AccountConfirmBalanceMasterId { get; }

    public AccountConfirmBalanceMasterCreatedEvent(AccountConfirmBalanceMasterId accountconfirmbalancemasterId)
    {
        AccountConfirmBalanceMasterId = accountconfirmbalancemasterId;
    }
}

public sealed class AccountConfirmBalanceMasterUpdatedEvent : DomainEvent
{
    public AccountConfirmBalanceMasterId AccountConfirmBalanceMasterId { get; }

    public AccountConfirmBalanceMasterUpdatedEvent(AccountConfirmBalanceMasterId accountconfirmbalancemasterId)
    {
        AccountConfirmBalanceMasterId = accountconfirmbalancemasterId;
    }
}

public sealed class AccountConfirmBalanceMasterDeletedEvent : DomainEvent
{
    public AccountConfirmBalanceMasterId AccountConfirmBalanceMasterId { get; }

    public AccountConfirmBalanceMasterDeletedEvent(AccountConfirmBalanceMasterId accountconfirmbalancemasterId)
    {
        AccountConfirmBalanceMasterId = accountconfirmbalancemasterId;
    }
}
}
