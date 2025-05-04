using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableType entity
/// </summary>
public sealed class AccountsPayableTypeCreatedEvent : DomainEvent
{
    public AccountsPayableTypeId AccountsPayableTypeId { get; }

    public AccountsPayableTypeCreatedEvent(AccountsPayableTypeId accountspayabletypeId)
    {
        AccountsPayableTypeId = accountspayabletypeId;
    }
}

public sealed class AccountsPayableTypeUpdatedEvent : DomainEvent
{
    public AccountsPayableTypeId AccountsPayableTypeId { get; }

    public AccountsPayableTypeUpdatedEvent(AccountsPayableTypeId accountspayabletypeId)
    {
        AccountsPayableTypeId = accountspayabletypeId;
    }
}

public sealed class AccountsPayableTypeDeletedEvent : DomainEvent
{
    public AccountsPayableTypeId AccountsPayableTypeId { get; }

    public AccountsPayableTypeDeletedEvent(AccountsPayableTypeId accountspayabletypeId)
    {
        AccountsPayableTypeId = accountspayabletypeId;
    }
}
}
