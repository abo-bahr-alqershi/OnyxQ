using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to AccountsReceivableGetDiscountTemp entity
/// </summary>
public sealed class AccountsReceivableGetDiscountTempCreatedEvent : DomainEvent
{
    public AccountsReceivableGetDiscountTempId AccountsReceivableGetDiscountTempId { get; }

    public AccountsReceivableGetDiscountTempCreatedEvent(AccountsReceivableGetDiscountTempId accountsreceivablegetdiscounttempId)
    {
        AccountsReceivableGetDiscountTempId = accountsreceivablegetdiscounttempId;
    }
}

public sealed class AccountsReceivableGetDiscountTempUpdatedEvent : DomainEvent
{
    public AccountsReceivableGetDiscountTempId AccountsReceivableGetDiscountTempId { get; }

    public AccountsReceivableGetDiscountTempUpdatedEvent(AccountsReceivableGetDiscountTempId accountsreceivablegetdiscounttempId)
    {
        AccountsReceivableGetDiscountTempId = accountsreceivablegetdiscounttempId;
    }
}

public sealed class AccountsReceivableGetDiscountTempDeletedEvent : DomainEvent
{
    public AccountsReceivableGetDiscountTempId AccountsReceivableGetDiscountTempId { get; }

    public AccountsReceivableGetDiscountTempDeletedEvent(AccountsReceivableGetDiscountTempId accountsreceivablegetdiscounttempId)
    {
        AccountsReceivableGetDiscountTempId = accountsreceivablegetdiscounttempId;
    }
}
}
