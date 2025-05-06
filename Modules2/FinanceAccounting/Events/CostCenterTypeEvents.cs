using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CostCenterType entity
/// </summary>
public sealed class CostCenterTypeCreatedEvent : DomainEvent
{
    public CostCenterTypeId CostCenterTypeId { get; }

    public CostCenterTypeCreatedEvent(CostCenterTypeId costcentertypeId)
    {
        CostCenterTypeId = costcentertypeId;
    }
}

public sealed class CostCenterTypeUpdatedEvent : DomainEvent
{
    public CostCenterTypeId CostCenterTypeId { get; }

    public CostCenterTypeUpdatedEvent(CostCenterTypeId costcentertypeId)
    {
        CostCenterTypeId = costcentertypeId;
    }
}

public sealed class CostCenterTypeDeletedEvent : DomainEvent
{
    public CostCenterTypeId CostCenterTypeId { get; }

    public CostCenterTypeDeletedEvent(CostCenterTypeId costcentertypeId)
    {
        CostCenterTypeId = costcentertypeId;
    }
}
}
