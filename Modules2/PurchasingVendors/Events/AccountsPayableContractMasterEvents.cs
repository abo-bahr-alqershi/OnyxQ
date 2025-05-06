using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableContractMaster entity
/// </summary>
public sealed class AccountsPayableContractMasterCreatedEvent : DomainEvent
{
    public AccountsPayableContractMasterId AccountsPayableContractMasterId { get; }

    public AccountsPayableContractMasterCreatedEvent(AccountsPayableContractMasterId accountspayablecontractmasterId)
    {
        AccountsPayableContractMasterId = accountspayablecontractmasterId;
    }
}

public sealed class AccountsPayableContractMasterUpdatedEvent : DomainEvent
{
    public AccountsPayableContractMasterId AccountsPayableContractMasterId { get; }

    public AccountsPayableContractMasterUpdatedEvent(AccountsPayableContractMasterId accountspayablecontractmasterId)
    {
        AccountsPayableContractMasterId = accountspayablecontractmasterId;
    }
}

public sealed class AccountsPayableContractMasterDeletedEvent : DomainEvent
{
    public AccountsPayableContractMasterId AccountsPayableContractMasterId { get; }

    public AccountsPayableContractMasterDeletedEvent(AccountsPayableContractMasterId accountspayablecontractmasterId)
    {
        AccountsPayableContractMasterId = accountspayablecontractmasterId;
    }
}
}
