using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to Province entity
/// </summary>
public sealed class ProvinceCreatedEvent : DomainEvent
{
    public ProvinceId ProvinceId { get; }

    public ProvinceCreatedEvent(ProvinceId provinceId)
    {
        ProvinceId = provinceId;
    }
}

public sealed class ProvinceUpdatedEvent : DomainEvent
{
    public ProvinceId ProvinceId { get; }

    public ProvinceUpdatedEvent(ProvinceId provinceId)
    {
        ProvinceId = provinceId;
    }
}

public sealed class ProvinceDeletedEvent : DomainEvent
{
    public ProvinceId ProvinceId { get; }

    public ProvinceDeletedEvent(ProvinceId provinceId)
    {
        ProvinceId = provinceId;
    }
}
}
