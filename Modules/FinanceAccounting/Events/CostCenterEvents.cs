using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CostCenter entity
/// </summary>
public sealed class CostCenterCreatedEvent : DomainEvent
{
    public CostCenterId CostCenterId { get; }

    public CostCenterCreatedEvent(CostCenterId costcenterId)
    {
        CostCenterId = costcenterId;
    }
}

public sealed class CostCenterUpdatedEvent : DomainEvent
{
    public CostCenterId CostCenterId { get; }

    public CostCenterUpdatedEvent(CostCenterId costcenterId)
    {
        CostCenterId = costcenterId;
    }
}

public sealed class CostCenterDeletedEvent : DomainEvent
{
    public CostCenterId CostCenterId { get; }

    public CostCenterDeletedEvent(CostCenterId costcenterId)
    {
        CostCenterId = costcenterId;
    }
}
}
