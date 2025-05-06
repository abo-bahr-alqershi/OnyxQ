using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AccountGroup entity
/// </summary>
public sealed class AccountGroupCreatedEvent : DomainEvent
{
    public AccountGroupId AccountGroupId { get; }

    public AccountGroupCreatedEvent(AccountGroupId accountgroupId)
    {
        AccountGroupId = accountgroupId;
    }
}

public sealed class AccountGroupUpdatedEvent : DomainEvent
{
    public AccountGroupId AccountGroupId { get; }

    public AccountGroupUpdatedEvent(AccountGroupId accountgroupId)
    {
        AccountGroupId = accountgroupId;
    }
}

public sealed class AccountGroupDeletedEvent : DomainEvent
{
    public AccountGroupId AccountGroupId { get; }

    public AccountGroupDeletedEvent(AccountGroupId accountgroupId)
    {
        AccountGroupId = accountgroupId;
    }
}
}
