using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableCharge entity
/// </summary>
public sealed class AccountsPayableChargeCreatedEvent : DomainEvent
{
    public AccountsPayableChargeId AccountsPayableChargeId { get; }

    public AccountsPayableChargeCreatedEvent(AccountsPayableChargeId accountspayablechargeId)
    {
        AccountsPayableChargeId = accountspayablechargeId;
    }
}

public sealed class AccountsPayableChargeUpdatedEvent : DomainEvent
{
    public AccountsPayableChargeId AccountsPayableChargeId { get; }

    public AccountsPayableChargeUpdatedEvent(AccountsPayableChargeId accountspayablechargeId)
    {
        AccountsPayableChargeId = accountspayablechargeId;
    }
}

public sealed class AccountsPayableChargeDeletedEvent : DomainEvent
{
    public AccountsPayableChargeId AccountsPayableChargeId { get; }

    public AccountsPayableChargeDeletedEvent(AccountsPayableChargeId accountspayablechargeId)
    {
        AccountsPayableChargeId = accountspayablechargeId;
    }
}
}
