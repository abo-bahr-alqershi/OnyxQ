using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to Region entity
/// </summary>
public sealed class RegionCreatedEvent : DomainEvent
{
    public RegionId RegionId { get; }

    public RegionCreatedEvent(RegionId regionId)
    {
        RegionId = regionId;
    }
}

public sealed class RegionUpdatedEvent : DomainEvent
{
    public RegionId RegionId { get; }

    public RegionUpdatedEvent(RegionId regionId)
    {
        RegionId = regionId;
    }
}

public sealed class RegionDeletedEvent : DomainEvent
{
    public RegionId RegionId { get; }

    public RegionDeletedEvent(RegionId regionId)
    {
        RegionId = regionId;
    }
}
}
