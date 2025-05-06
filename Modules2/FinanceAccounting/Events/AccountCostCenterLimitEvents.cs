using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AccountCostCenterLimit entity
/// </summary>
public sealed class AccountCostCenterLimitCreatedEvent : DomainEvent
{
    public AccountCostCenterLimitId AccountCostCenterLimitId { get; }

    public AccountCostCenterLimitCreatedEvent(AccountCostCenterLimitId accountcostcenterlimitId)
    {
        AccountCostCenterLimitId = accountcostcenterlimitId;
    }
}

public sealed class AccountCostCenterLimitUpdatedEvent : DomainEvent
{
    public AccountCostCenterLimitId AccountCostCenterLimitId { get; }

    public AccountCostCenterLimitUpdatedEvent(AccountCostCenterLimitId accountcostcenterlimitId)
    {
        AccountCostCenterLimitId = accountcostcenterlimitId;
    }
}

public sealed class AccountCostCenterLimitDeletedEvent : DomainEvent
{
    public AccountCostCenterLimitId AccountCostCenterLimitId { get; }

    public AccountCostCenterLimitDeletedEvent(AccountCostCenterLimitId accountcostcenterlimitId)
    {
        AccountCostCenterLimitId = accountcostcenterlimitId;
    }
}
}
