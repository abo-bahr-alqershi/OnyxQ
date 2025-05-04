using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to AccountsReceivableContractRenew entity
/// </summary>
public sealed class AccountsReceivableContractRenewCreatedEvent : DomainEvent
{
    public AccountsReceivableContractRenewId AccountsReceivableContractRenewId { get; }

    public AccountsReceivableContractRenewCreatedEvent(AccountsReceivableContractRenewId accountsreceivablecontractrenewId)
    {
        AccountsReceivableContractRenewId = accountsreceivablecontractrenewId;
    }
}

public sealed class AccountsReceivableContractRenewUpdatedEvent : DomainEvent
{
    public AccountsReceivableContractRenewId AccountsReceivableContractRenewId { get; }

    public AccountsReceivableContractRenewUpdatedEvent(AccountsReceivableContractRenewId accountsreceivablecontractrenewId)
    {
        AccountsReceivableContractRenewId = accountsreceivablecontractrenewId;
    }
}

public sealed class AccountsReceivableContractRenewDeletedEvent : DomainEvent
{
    public AccountsReceivableContractRenewId AccountsReceivableContractRenewId { get; }

    public AccountsReceivableContractRenewDeletedEvent(AccountsReceivableContractRenewId accountsreceivablecontractrenewId)
    {
        AccountsReceivableContractRenewId = accountsreceivablecontractrenewId;
    }
}
}
