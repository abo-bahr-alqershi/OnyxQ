using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableOtherChargeItem entity
/// </summary>
public sealed class AccountsPayableOtherChargeItemCreatedEvent : DomainEvent
{
    public AccountsPayableOtherChargeItemId AccountsPayableOtherChargeItemId { get; }

    public AccountsPayableOtherChargeItemCreatedEvent(AccountsPayableOtherChargeItemId accountspayableotherchargeitemId)
    {
        AccountsPayableOtherChargeItemId = accountspayableotherchargeitemId;
    }
}

public sealed class AccountsPayableOtherChargeItemUpdatedEvent : DomainEvent
{
    public AccountsPayableOtherChargeItemId AccountsPayableOtherChargeItemId { get; }

    public AccountsPayableOtherChargeItemUpdatedEvent(AccountsPayableOtherChargeItemId accountspayableotherchargeitemId)
    {
        AccountsPayableOtherChargeItemId = accountspayableotherchargeitemId;
    }
}

public sealed class AccountsPayableOtherChargeItemDeletedEvent : DomainEvent
{
    public AccountsPayableOtherChargeItemId AccountsPayableOtherChargeItemId { get; }

    public AccountsPayableOtherChargeItemDeletedEvent(AccountsPayableOtherChargeItemId accountspayableotherchargeitemId)
    {
        AccountsPayableOtherChargeItemId = accountspayableotherchargeitemId;
    }
}
}
