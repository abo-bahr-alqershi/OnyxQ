using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to City entity
/// </summary>
public sealed class CityCreatedEvent : DomainEvent
{
    public CityId CityId { get; }

    public CityCreatedEvent(CityId cityId)
    {
        CityId = cityId;
    }
}

public sealed class CityUpdatedEvent : DomainEvent
{
    public CityId CityId { get; }

    public CityUpdatedEvent(CityId cityId)
    {
        CityId = cityId;
    }
}

public sealed class CityDeletedEvent : DomainEvent
{
    public CityId CityId { get; }

    public CityDeletedEvent(CityId cityId)
    {
        CityId = cityId;
    }
}
}
