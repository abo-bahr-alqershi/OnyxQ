using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableKimbDetail entity
/// </summary>
public sealed class AccountsPayableKimbDetailCreatedEvent : DomainEvent
{
    public AccountsPayableKimbDetailId AccountsPayableKimbDetailId { get; }

    public AccountsPayableKimbDetailCreatedEvent(AccountsPayableKimbDetailId accountspayablekimbdetailId)
    {
        AccountsPayableKimbDetailId = accountspayablekimbdetailId;
    }
}

public sealed class AccountsPayableKimbDetailUpdatedEvent : DomainEvent
{
    public AccountsPayableKimbDetailId AccountsPayableKimbDetailId { get; }

    public AccountsPayableKimbDetailUpdatedEvent(AccountsPayableKimbDetailId accountspayablekimbdetailId)
    {
        AccountsPayableKimbDetailId = accountspayablekimbdetailId;
    }
}

public sealed class AccountsPayableKimbDetailDeletedEvent : DomainEvent
{
    public AccountsPayableKimbDetailId AccountsPayableKimbDetailId { get; }

    public AccountsPayableKimbDetailDeletedEvent(AccountsPayableKimbDetailId accountspayablekimbdetailId)
    {
        AccountsPayableKimbDetailId = accountspayablekimbdetailId;
    }
}
}
