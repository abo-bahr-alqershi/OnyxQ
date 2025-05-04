using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to YearReMoveDataDetail entity
/// </summary>
public sealed class YearReMoveDataDetailCreatedEvent : DomainEvent
{
    public YearReMoveDataDetailId YearReMoveDataDetailId { get; }

    public YearReMoveDataDetailCreatedEvent(YearReMoveDataDetailId yearremovedatadetailId)
    {
        YearReMoveDataDetailId = yearremovedatadetailId;
    }
}

public sealed class YearReMoveDataDetailUpdatedEvent : DomainEvent
{
    public YearReMoveDataDetailId YearReMoveDataDetailId { get; }

    public YearReMoveDataDetailUpdatedEvent(YearReMoveDataDetailId yearremovedatadetailId)
    {
        YearReMoveDataDetailId = yearremovedatadetailId;
    }
}

public sealed class YearReMoveDataDetailDeletedEvent : DomainEvent
{
    public YearReMoveDataDetailId YearReMoveDataDetailId { get; }

    public YearReMoveDataDetailDeletedEvent(YearReMoveDataDetailId yearremovedatadetailId)
    {
        YearReMoveDataDetailId = yearremovedatadetailId;
    }
}
}
