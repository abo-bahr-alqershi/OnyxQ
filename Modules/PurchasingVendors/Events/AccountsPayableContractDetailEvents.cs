using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableContractDetail entity
/// </summary>
public sealed class AccountsPayableContractDetailCreatedEvent : DomainEvent
{
    public AccountsPayableContractDetailId AccountsPayableContractDetailId { get; }

    public AccountsPayableContractDetailCreatedEvent(AccountsPayableContractDetailId accountspayablecontractdetailId)
    {
        AccountsPayableContractDetailId = accountspayablecontractdetailId;
    }
}

public sealed class AccountsPayableContractDetailUpdatedEvent : DomainEvent
{
    public AccountsPayableContractDetailId AccountsPayableContractDetailId { get; }

    public AccountsPayableContractDetailUpdatedEvent(AccountsPayableContractDetailId accountspayablecontractdetailId)
    {
        AccountsPayableContractDetailId = accountspayablecontractdetailId;
    }
}

public sealed class AccountsPayableContractDetailDeletedEvent : DomainEvent
{
    public AccountsPayableContractDetailId AccountsPayableContractDetailId { get; }

    public AccountsPayableContractDetailDeletedEvent(AccountsPayableContractDetailId accountspayablecontractdetailId)
    {
        AccountsPayableContractDetailId = accountspayablecontractdetailId;
    }
}
}
