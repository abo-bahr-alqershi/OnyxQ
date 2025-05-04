using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CostCenterProject entity
/// </summary>
public sealed class CostCenterProjectCreatedEvent : DomainEvent
{
    public CostCenterProjectId CostCenterProjectId { get; }

    public CostCenterProjectCreatedEvent(CostCenterProjectId costcenterprojectId)
    {
        CostCenterProjectId = costcenterprojectId;
    }
}

public sealed class CostCenterProjectUpdatedEvent : DomainEvent
{
    public CostCenterProjectId CostCenterProjectId { get; }

    public CostCenterProjectUpdatedEvent(CostCenterProjectId costcenterprojectId)
    {
        CostCenterProjectId = costcenterprojectId;
    }
}

public sealed class CostCenterProjectDeletedEvent : DomainEvent
{
    public CostCenterProjectId CostCenterProjectId { get; }

    public CostCenterProjectDeletedEvent(CostCenterProjectId costcenterprojectId)
    {
        CostCenterProjectId = costcenterprojectId;
    }
}
}
