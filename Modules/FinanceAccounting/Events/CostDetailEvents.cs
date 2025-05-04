using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CostDetail entity
/// </summary>
public sealed class CostDetailCreatedEvent : DomainEvent
{
    public CostDetailId CostDetailId { get; }

    public CostDetailCreatedEvent(CostDetailId costdetailId)
    {
        CostDetailId = costdetailId;
    }
}

public sealed class CostDetailUpdatedEvent : DomainEvent
{
    public CostDetailId CostDetailId { get; }

    public CostDetailUpdatedEvent(CostDetailId costdetailId)
    {
        CostDetailId = costdetailId;
    }
}

public sealed class CostDetailDeletedEvent : DomainEvent
{
    public CostDetailId CostDetailId { get; }

    public CostDetailDeletedEvent(CostDetailId costdetailId)
    {
        CostDetailId = costdetailId;
    }
}
}
