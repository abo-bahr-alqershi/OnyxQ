using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to AccountsReceivableContractMaster entity
/// </summary>
public sealed class AccountsReceivableContractMasterCreatedEvent : DomainEvent
{
    public AccountsReceivableContractMasterId AccountsReceivableContractMasterId { get; }

    public AccountsReceivableContractMasterCreatedEvent(AccountsReceivableContractMasterId accountsreceivablecontractmasterId)
    {
        AccountsReceivableContractMasterId = accountsreceivablecontractmasterId;
    }
}

public sealed class AccountsReceivableContractMasterUpdatedEvent : DomainEvent
{
    public AccountsReceivableContractMasterId AccountsReceivableContractMasterId { get; }

    public AccountsReceivableContractMasterUpdatedEvent(AccountsReceivableContractMasterId accountsreceivablecontractmasterId)
    {
        AccountsReceivableContractMasterId = accountsreceivablecontractmasterId;
    }
}

public sealed class AccountsReceivableContractMasterDeletedEvent : DomainEvent
{
    public AccountsReceivableContractMasterId AccountsReceivableContractMasterId { get; }

    public AccountsReceivableContractMasterDeletedEvent(AccountsReceivableContractMasterId accountsreceivablecontractmasterId)
    {
        AccountsReceivableContractMasterId = accountsreceivablecontractmasterId;
    }
}
}
