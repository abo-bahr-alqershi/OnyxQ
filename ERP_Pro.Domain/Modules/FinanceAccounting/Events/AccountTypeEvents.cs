using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AccountType entity
/// </summary>
public sealed class AccountTypeCreatedEvent : DomainEvent
{
    public AccountTypeId AccountTypeId { get; }

    public AccountTypeCreatedEvent(AccountTypeId accounttypeId)
    {
        AccountTypeId = accounttypeId;
    }
}

public sealed class AccountTypeUpdatedEvent : DomainEvent
{
    public AccountTypeId AccountTypeId { get; }

    public AccountTypeUpdatedEvent(AccountTypeId accounttypeId)
    {
        AccountTypeId = accounttypeId;
    }
}

public sealed class AccountTypeDeletedEvent : DomainEvent
{
    public AccountTypeId AccountTypeId { get; }

    public AccountTypeDeletedEvent(AccountTypeId accounttypeId)
    {
        AccountTypeId = accounttypeId;
    }
}
}
