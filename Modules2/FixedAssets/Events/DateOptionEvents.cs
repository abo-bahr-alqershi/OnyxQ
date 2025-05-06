using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FixedAssets.ValueObjects;

namespace ERP_Pro.Domain.ERP.FixedAssets.Events
{
/// <summary>
/// Events related to DateOption entity
/// </summary>
public sealed class DateOptionCreatedEvent : DomainEvent
{
    public DateOptionId DateOptionId { get; }

    public DateOptionCreatedEvent(DateOptionId dateoptionId)
    {
        DateOptionId = dateoptionId;
    }
}

public sealed class DateOptionUpdatedEvent : DomainEvent
{
    public DateOptionId DateOptionId { get; }

    public DateOptionUpdatedEvent(DateOptionId dateoptionId)
    {
        DateOptionId = dateoptionId;
    }
}

public sealed class DateOptionDeletedEvent : DomainEvent
{
    public DateOptionId DateOptionId { get; }

    public DateOptionDeletedEvent(DateOptionId dateoptionId)
    {
        DateOptionId = dateoptionId;
    }
}
}
