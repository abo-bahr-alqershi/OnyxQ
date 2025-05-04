using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AccountExpenseDistribution entity
/// </summary>
public sealed class AccountExpenseDistributionCreatedEvent : DomainEvent
{
    public AccountExpenseDistributionId AccountExpenseDistributionId { get; }

    public AccountExpenseDistributionCreatedEvent(AccountExpenseDistributionId accountexpensedistributionId)
    {
        AccountExpenseDistributionId = accountexpensedistributionId;
    }
}

public sealed class AccountExpenseDistributionUpdatedEvent : DomainEvent
{
    public AccountExpenseDistributionId AccountExpenseDistributionId { get; }

    public AccountExpenseDistributionUpdatedEvent(AccountExpenseDistributionId accountexpensedistributionId)
    {
        AccountExpenseDistributionId = accountexpensedistributionId;
    }
}

public sealed class AccountExpenseDistributionDeletedEvent : DomainEvent
{
    public AccountExpenseDistributionId AccountExpenseDistributionId { get; }

    public AccountExpenseDistributionDeletedEvent(AccountExpenseDistributionId accountexpensedistributionId)
    {
        AccountExpenseDistributionId = accountexpensedistributionId;
    }
}
}
