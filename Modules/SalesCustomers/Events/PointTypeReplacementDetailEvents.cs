using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PointTypeReplacementDetail entity
/// </summary>
public sealed class PointTypeReplacementDetailCreatedEvent : DomainEvent
{
    public PointTypeReplacementDetailId PointTypeReplacementDetailId { get; }

    public PointTypeReplacementDetailCreatedEvent(PointTypeReplacementDetailId pointtypereplacementdetailId)
    {
        PointTypeReplacementDetailId = pointtypereplacementdetailId;
    }
}

public sealed class PointTypeReplacementDetailUpdatedEvent : DomainEvent
{
    public PointTypeReplacementDetailId PointTypeReplacementDetailId { get; }

    public PointTypeReplacementDetailUpdatedEvent(PointTypeReplacementDetailId pointtypereplacementdetailId)
    {
        PointTypeReplacementDetailId = pointtypereplacementdetailId;
    }
}

public sealed class PointTypeReplacementDetailDeletedEvent : DomainEvent
{
    public PointTypeReplacementDetailId PointTypeReplacementDetailId { get; }

    public PointTypeReplacementDetailDeletedEvent(PointTypeReplacementDetailId pointtypereplacementdetailId)
    {
        PointTypeReplacementDetailId = pointtypereplacementdetailId;
    }
}
}
