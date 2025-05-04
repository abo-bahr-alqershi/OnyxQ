using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableChargeItem entity
/// </summary>
public sealed class AccountsPayableChargeItemCreatedEvent : DomainEvent
{
    public AccountsPayableChargeItemId AccountsPayableChargeItemId { get; }

    public AccountsPayableChargeItemCreatedEvent(AccountsPayableChargeItemId accountspayablechargeitemId)
    {
        AccountsPayableChargeItemId = accountspayablechargeitemId;
    }
}

public sealed class AccountsPayableChargeItemUpdatedEvent : DomainEvent
{
    public AccountsPayableChargeItemId AccountsPayableChargeItemId { get; }

    public AccountsPayableChargeItemUpdatedEvent(AccountsPayableChargeItemId accountspayablechargeitemId)
    {
        AccountsPayableChargeItemId = accountspayablechargeitemId;
    }
}

public sealed class AccountsPayableChargeItemDeletedEvent : DomainEvent
{
    public AccountsPayableChargeItemId AccountsPayableChargeItemId { get; }

    public AccountsPayableChargeItemDeletedEvent(AccountsPayableChargeItemId accountspayablechargeitemId)
    {
        AccountsPayableChargeItemId = accountspayablechargeitemId;
    }
}
}
