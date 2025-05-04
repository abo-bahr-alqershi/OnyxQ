using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableOtherCharge entity
/// </summary>
public sealed class AccountsPayableOtherChargeCreatedEvent : DomainEvent
{
    public AccountsPayableOtherChargeId AccountsPayableOtherChargeId { get; }

    public AccountsPayableOtherChargeCreatedEvent(AccountsPayableOtherChargeId accountspayableotherchargeId)
    {
        AccountsPayableOtherChargeId = accountspayableotherchargeId;
    }
}

public sealed class AccountsPayableOtherChargeUpdatedEvent : DomainEvent
{
    public AccountsPayableOtherChargeId AccountsPayableOtherChargeId { get; }

    public AccountsPayableOtherChargeUpdatedEvent(AccountsPayableOtherChargeId accountspayableotherchargeId)
    {
        AccountsPayableOtherChargeId = accountspayableotherchargeId;
    }
}

public sealed class AccountsPayableOtherChargeDeletedEvent : DomainEvent
{
    public AccountsPayableOtherChargeId AccountsPayableOtherChargeId { get; }

    public AccountsPayableOtherChargeDeletedEvent(AccountsPayableOtherChargeId accountspayableotherchargeId)
    {
        AccountsPayableOtherChargeId = accountspayableotherchargeId;
    }
}
}
