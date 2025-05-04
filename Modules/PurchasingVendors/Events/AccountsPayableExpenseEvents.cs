using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableExpense entity
/// </summary>
public sealed class AccountsPayableExpenseCreatedEvent : DomainEvent
{
    public AccountsPayableExpenseId AccountsPayableExpenseId { get; }

    public AccountsPayableExpenseCreatedEvent(AccountsPayableExpenseId accountspayableexpenseId)
    {
        AccountsPayableExpenseId = accountspayableexpenseId;
    }
}

public sealed class AccountsPayableExpenseUpdatedEvent : DomainEvent
{
    public AccountsPayableExpenseId AccountsPayableExpenseId { get; }

    public AccountsPayableExpenseUpdatedEvent(AccountsPayableExpenseId accountspayableexpenseId)
    {
        AccountsPayableExpenseId = accountspayableexpenseId;
    }
}

public sealed class AccountsPayableExpenseDeletedEvent : DomainEvent
{
    public AccountsPayableExpenseId AccountsPayableExpenseId { get; }

    public AccountsPayableExpenseDeletedEvent(AccountsPayableExpenseId accountspayableexpenseId)
    {
        AccountsPayableExpenseId = accountspayableexpenseId;
    }
}
}
