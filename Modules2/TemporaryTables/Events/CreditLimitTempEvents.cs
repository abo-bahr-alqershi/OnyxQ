using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to CreditLimitTemp entity
/// </summary>
public sealed class CreditLimitTempCreatedEvent : DomainEvent
{
    public CreditLimitTempId CreditLimitTempId { get; }

    public CreditLimitTempCreatedEvent(CreditLimitTempId creditlimittempId)
    {
        CreditLimitTempId = creditlimittempId;
    }
}

public sealed class CreditLimitTempUpdatedEvent : DomainEvent
{
    public CreditLimitTempId CreditLimitTempId { get; }

    public CreditLimitTempUpdatedEvent(CreditLimitTempId creditlimittempId)
    {
        CreditLimitTempId = creditlimittempId;
    }
}

public sealed class CreditLimitTempDeletedEvent : DomainEvent
{
    public CreditLimitTempId CreditLimitTempId { get; }

    public CreditLimitTempDeletedEvent(CreditLimitTempId creditlimittempId)
    {
        CreditLimitTempId = creditlimittempId;
    }
}
}
