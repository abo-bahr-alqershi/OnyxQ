using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SaleCost entity
/// </summary>
public sealed class SaleCostCreatedEvent : DomainEvent
{
    public SaleCostId SaleCostId { get; }

    public SaleCostCreatedEvent(SaleCostId salecostId)
    {
        SaleCostId = salecostId;
    }
}

public sealed class SaleCostUpdatedEvent : DomainEvent
{
    public SaleCostId SaleCostId { get; }

    public SaleCostUpdatedEvent(SaleCostId salecostId)
    {
        SaleCostId = salecostId;
    }
}

public sealed class SaleCostDeletedEvent : DomainEvent
{
    public SaleCostId SaleCostId { get; }

    public SaleCostDeletedEvent(SaleCostId salecostId)
    {
        SaleCostId = salecostId;
    }
}
}
