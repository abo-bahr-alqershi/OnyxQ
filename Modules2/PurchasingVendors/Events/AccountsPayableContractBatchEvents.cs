using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableContractBatch entity
/// </summary>
public sealed class AccountsPayableContractBatchCreatedEvent : DomainEvent
{
    public AccountsPayableContractBatchId AccountsPayableContractBatchId { get; }

    public AccountsPayableContractBatchCreatedEvent(AccountsPayableContractBatchId accountspayablecontractbatchId)
    {
        AccountsPayableContractBatchId = accountspayablecontractbatchId;
    }
}

public sealed class AccountsPayableContractBatchUpdatedEvent : DomainEvent
{
    public AccountsPayableContractBatchId AccountsPayableContractBatchId { get; }

    public AccountsPayableContractBatchUpdatedEvent(AccountsPayableContractBatchId accountspayablecontractbatchId)
    {
        AccountsPayableContractBatchId = accountspayablecontractbatchId;
    }
}

public sealed class AccountsPayableContractBatchDeletedEvent : DomainEvent
{
    public AccountsPayableContractBatchId AccountsPayableContractBatchId { get; }

    public AccountsPayableContractBatchDeletedEvent(AccountsPayableContractBatchId accountspayablecontractbatchId)
    {
        AccountsPayableContractBatchId = accountspayablecontractbatchId;
    }
}
}
