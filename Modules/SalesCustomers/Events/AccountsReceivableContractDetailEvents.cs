using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to AccountsReceivableContractDetail entity
/// </summary>
public sealed class AccountsReceivableContractDetailCreatedEvent : DomainEvent
{
    public AccountsReceivableContractDetailId AccountsReceivableContractDetailId { get; }

    public AccountsReceivableContractDetailCreatedEvent(AccountsReceivableContractDetailId accountsreceivablecontractdetailId)
    {
        AccountsReceivableContractDetailId = accountsreceivablecontractdetailId;
    }
}

public sealed class AccountsReceivableContractDetailUpdatedEvent : DomainEvent
{
    public AccountsReceivableContractDetailId AccountsReceivableContractDetailId { get; }

    public AccountsReceivableContractDetailUpdatedEvent(AccountsReceivableContractDetailId accountsreceivablecontractdetailId)
    {
        AccountsReceivableContractDetailId = accountsreceivablecontractdetailId;
    }
}

public sealed class AccountsReceivableContractDetailDeletedEvent : DomainEvent
{
    public AccountsReceivableContractDetailId AccountsReceivableContractDetailId { get; }

    public AccountsReceivableContractDetailDeletedEvent(AccountsReceivableContractDetailId accountsreceivablecontractdetailId)
    {
        AccountsReceivableContractDetailId = accountsreceivablecontractdetailId;
    }
}
}
