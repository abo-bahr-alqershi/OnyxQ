using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to AccountsReceivableContractBatch entity
/// </summary>
public sealed class AccountsReceivableContractBatchCreatedEvent : DomainEvent
{
    public AccountsReceivableContractBatchId AccountsReceivableContractBatchId { get; }

    public AccountsReceivableContractBatchCreatedEvent(AccountsReceivableContractBatchId accountsreceivablecontractbatchId)
    {
        AccountsReceivableContractBatchId = accountsreceivablecontractbatchId;
    }
}

public sealed class AccountsReceivableContractBatchUpdatedEvent : DomainEvent
{
    public AccountsReceivableContractBatchId AccountsReceivableContractBatchId { get; }

    public AccountsReceivableContractBatchUpdatedEvent(AccountsReceivableContractBatchId accountsreceivablecontractbatchId)
    {
        AccountsReceivableContractBatchId = accountsreceivablecontractbatchId;
    }
}

public sealed class AccountsReceivableContractBatchDeletedEvent : DomainEvent
{
    public AccountsReceivableContractBatchId AccountsReceivableContractBatchId { get; }

    public AccountsReceivableContractBatchDeletedEvent(AccountsReceivableContractBatchId accountsreceivablecontractbatchId)
    {
        AccountsReceivableContractBatchId = accountsreceivablecontractbatchId;
    }
}
}
