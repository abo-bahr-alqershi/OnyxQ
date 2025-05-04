using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CalculateCommissionDetail entity
/// </summary>
public sealed class CalculateCommissionDetailCreatedEvent : DomainEvent
{
    public CalculateCommissionDetailId CalculateCommissionDetailId { get; }

    public CalculateCommissionDetailCreatedEvent(CalculateCommissionDetailId calculatecommissiondetailId)
    {
        CalculateCommissionDetailId = calculatecommissiondetailId;
    }
}

public sealed class CalculateCommissionDetailUpdatedEvent : DomainEvent
{
    public CalculateCommissionDetailId CalculateCommissionDetailId { get; }

    public CalculateCommissionDetailUpdatedEvent(CalculateCommissionDetailId calculatecommissiondetailId)
    {
        CalculateCommissionDetailId = calculatecommissiondetailId;
    }
}

public sealed class CalculateCommissionDetailDeletedEvent : DomainEvent
{
    public CalculateCommissionDetailId CalculateCommissionDetailId { get; }

    public CalculateCommissionDetailDeletedEvent(CalculateCommissionDetailId calculatecommissiondetailId)
    {
        CalculateCommissionDetailId = calculatecommissiondetailId;
    }
}
}
