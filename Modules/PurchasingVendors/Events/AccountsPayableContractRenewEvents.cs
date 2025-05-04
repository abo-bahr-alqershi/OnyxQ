using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableContractRenew entity
/// </summary>
public sealed class AccountsPayableContractRenewCreatedEvent : DomainEvent
{
    public AccountsPayableContractRenewId AccountsPayableContractRenewId { get; }

    public AccountsPayableContractRenewCreatedEvent(AccountsPayableContractRenewId accountspayablecontractrenewId)
    {
        AccountsPayableContractRenewId = accountspayablecontractrenewId;
    }
}

public sealed class AccountsPayableContractRenewUpdatedEvent : DomainEvent
{
    public AccountsPayableContractRenewId AccountsPayableContractRenewId { get; }

    public AccountsPayableContractRenewUpdatedEvent(AccountsPayableContractRenewId accountspayablecontractrenewId)
    {
        AccountsPayableContractRenewId = accountspayablecontractrenewId;
    }
}

public sealed class AccountsPayableContractRenewDeletedEvent : DomainEvent
{
    public AccountsPayableContractRenewId AccountsPayableContractRenewId { get; }

    public AccountsPayableContractRenewDeletedEvent(AccountsPayableContractRenewId accountspayablecontractrenewId)
    {
        AccountsPayableContractRenewId = accountspayablecontractrenewId;
    }
}
}
