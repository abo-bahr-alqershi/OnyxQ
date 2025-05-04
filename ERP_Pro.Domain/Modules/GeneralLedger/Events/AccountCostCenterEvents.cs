using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountCostCenter entity
/// </summary>
public sealed class AccountCostCenterCreatedEvent : DomainEvent
{
    public AccountCostCenterId AccountCostCenterId { get; }

    public AccountCostCenterCreatedEvent(AccountCostCenterId accountcostcenterId)
    {
        AccountCostCenterId = accountcostcenterId;
    }
}

public sealed class AccountCostCenterUpdatedEvent : DomainEvent
{
    public AccountCostCenterId AccountCostCenterId { get; }

    public AccountCostCenterUpdatedEvent(AccountCostCenterId accountcostcenterId)
    {
        AccountCostCenterId = accountcostcenterId;
    }
}

public sealed class AccountCostCenterDeletedEvent : DomainEvent
{
    public AccountCostCenterId AccountCostCenterId { get; }

    public AccountCostCenterDeletedEvent(AccountCostCenterId accountcostcenterId)
    {
        AccountCostCenterId = accountcostcenterId;
    }
}
}
