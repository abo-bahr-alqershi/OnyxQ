using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PointTypeMaster entity
/// </summary>
public sealed class PointTypeMasterCreatedEvent : DomainEvent
{
    public PointTypeMasterId PointTypeMasterId { get; }

    public PointTypeMasterCreatedEvent(PointTypeMasterId pointtypemasterId)
    {
        PointTypeMasterId = pointtypemasterId;
    }
}

public sealed class PointTypeMasterUpdatedEvent : DomainEvent
{
    public PointTypeMasterId PointTypeMasterId { get; }

    public PointTypeMasterUpdatedEvent(PointTypeMasterId pointtypemasterId)
    {
        PointTypeMasterId = pointtypemasterId;
    }
}

public sealed class PointTypeMasterDeletedEvent : DomainEvent
{
    public PointTypeMasterId PointTypeMasterId { get; }

    public PointTypeMasterDeletedEvent(PointTypeMasterId pointtypemasterId)
    {
        PointTypeMasterId = pointtypemasterId;
    }
}
}
