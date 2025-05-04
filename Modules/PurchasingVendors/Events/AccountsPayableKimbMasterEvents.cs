using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableKimbMaster entity
/// </summary>
public sealed class AccountsPayableKimbMasterCreatedEvent : DomainEvent
{
    public AccountsPayableKimbMasterId AccountsPayableKimbMasterId { get; }

    public AccountsPayableKimbMasterCreatedEvent(AccountsPayableKimbMasterId accountspayablekimbmasterId)
    {
        AccountsPayableKimbMasterId = accountspayablekimbmasterId;
    }
}

public sealed class AccountsPayableKimbMasterUpdatedEvent : DomainEvent
{
    public AccountsPayableKimbMasterId AccountsPayableKimbMasterId { get; }

    public AccountsPayableKimbMasterUpdatedEvent(AccountsPayableKimbMasterId accountspayablekimbmasterId)
    {
        AccountsPayableKimbMasterId = accountspayablekimbmasterId;
    }
}

public sealed class AccountsPayableKimbMasterDeletedEvent : DomainEvent
{
    public AccountsPayableKimbMasterId AccountsPayableKimbMasterId { get; }

    public AccountsPayableKimbMasterDeletedEvent(AccountsPayableKimbMasterId accountspayablekimbmasterId)
    {
        AccountsPayableKimbMasterId = accountspayablekimbmasterId;
    }
}
}
