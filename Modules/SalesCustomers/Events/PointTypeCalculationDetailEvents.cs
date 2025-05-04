using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PointTypeCalculationDetail entity
/// </summary>
public sealed class PointTypeCalculationDetailCreatedEvent : DomainEvent
{
    public PointTypeCalculationDetailId PointTypeCalculationDetailId { get; }

    public PointTypeCalculationDetailCreatedEvent(PointTypeCalculationDetailId pointtypecalculationdetailId)
    {
        PointTypeCalculationDetailId = pointtypecalculationdetailId;
    }
}

public sealed class PointTypeCalculationDetailUpdatedEvent : DomainEvent
{
    public PointTypeCalculationDetailId PointTypeCalculationDetailId { get; }

    public PointTypeCalculationDetailUpdatedEvent(PointTypeCalculationDetailId pointtypecalculationdetailId)
    {
        PointTypeCalculationDetailId = pointtypecalculationdetailId;
    }
}

public sealed class PointTypeCalculationDetailDeletedEvent : DomainEvent
{
    public PointTypeCalculationDetailId PointTypeCalculationDetailId { get; }

    public PointTypeCalculationDetailDeletedEvent(PointTypeCalculationDetailId pointtypecalculationdetailId)
    {
        PointTypeCalculationDetailId = pointtypecalculationdetailId;
    }
}
}
