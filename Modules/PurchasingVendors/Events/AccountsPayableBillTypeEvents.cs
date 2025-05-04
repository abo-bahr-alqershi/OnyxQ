using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableBillType entity
/// </summary>
public sealed class AccountsPayableBillTypeCreatedEvent : DomainEvent
{
    public AccountsPayableBillTypeId AccountsPayableBillTypeId { get; }

    public AccountsPayableBillTypeCreatedEvent(AccountsPayableBillTypeId accountspayablebilltypeId)
    {
        AccountsPayableBillTypeId = accountspayablebilltypeId;
    }
}

public sealed class AccountsPayableBillTypeUpdatedEvent : DomainEvent
{
    public AccountsPayableBillTypeId AccountsPayableBillTypeId { get; }

    public AccountsPayableBillTypeUpdatedEvent(AccountsPayableBillTypeId accountspayablebilltypeId)
    {
        AccountsPayableBillTypeId = accountspayablebilltypeId;
    }
}

public sealed class AccountsPayableBillTypeDeletedEvent : DomainEvent
{
    public AccountsPayableBillTypeId AccountsPayableBillTypeId { get; }

    public AccountsPayableBillTypeDeletedEvent(AccountsPayableBillTypeId accountspayablebilltypeId)
    {
        AccountsPayableBillTypeId = accountspayablebilltypeId;
    }
}
}
