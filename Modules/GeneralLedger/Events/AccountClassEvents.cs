using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountClass entity
/// </summary>
public sealed class AccountClassCreatedEvent : DomainEvent
{
    public AccountClassId AccountClassId { get; }

    public AccountClassCreatedEvent(AccountClassId accountclassId)
    {
        AccountClassId = accountclassId;
    }
}

public sealed class AccountClassUpdatedEvent : DomainEvent
{
    public AccountClassId AccountClassId { get; }

    public AccountClassUpdatedEvent(AccountClassId accountclassId)
    {
        AccountClassId = accountclassId;
    }
}

public sealed class AccountClassDeletedEvent : DomainEvent
{
    public AccountClassId AccountClassId { get; }

    public AccountClassDeletedEvent(AccountClassId accountclassId)
    {
        AccountClassId = accountclassId;
    }
}
}
