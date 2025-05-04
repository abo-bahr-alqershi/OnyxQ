using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to YearBalanceTemp entity
/// </summary>
public sealed class YearBalanceTempCreatedEvent : DomainEvent
{
    public YearBalanceTempId YearBalanceTempId { get; }

    public YearBalanceTempCreatedEvent(YearBalanceTempId yearbalancetempId)
    {
        YearBalanceTempId = yearbalancetempId;
    }
}

public sealed class YearBalanceTempUpdatedEvent : DomainEvent
{
    public YearBalanceTempId YearBalanceTempId { get; }

    public YearBalanceTempUpdatedEvent(YearBalanceTempId yearbalancetempId)
    {
        YearBalanceTempId = yearbalancetempId;
    }
}

public sealed class YearBalanceTempDeletedEvent : DomainEvent
{
    public YearBalanceTempId YearBalanceTempId { get; }

    public YearBalanceTempDeletedEvent(YearBalanceTempId yearbalancetempId)
    {
        YearBalanceTempId = yearbalancetempId;
    }
}
}
