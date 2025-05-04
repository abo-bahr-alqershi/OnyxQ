using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CostCenterTree entity
/// </summary>
public sealed class CostCenterTreeCreatedEvent : DomainEvent
{
    public CostCenterTreeId CostCenterTreeId { get; }

    public CostCenterTreeCreatedEvent(CostCenterTreeId costcentertreeId)
    {
        CostCenterTreeId = costcentertreeId;
    }
}

public sealed class CostCenterTreeUpdatedEvent : DomainEvent
{
    public CostCenterTreeId CostCenterTreeId { get; }

    public CostCenterTreeUpdatedEvent(CostCenterTreeId costcentertreeId)
    {
        CostCenterTreeId = costcentertreeId;
    }
}

public sealed class CostCenterTreeDeletedEvent : DomainEvent
{
    public CostCenterTreeId CostCenterTreeId { get; }

    public CostCenterTreeDeletedEvent(CostCenterTreeId costcentertreeId)
    {
        CostCenterTreeId = costcentertreeId;
    }
}
}
