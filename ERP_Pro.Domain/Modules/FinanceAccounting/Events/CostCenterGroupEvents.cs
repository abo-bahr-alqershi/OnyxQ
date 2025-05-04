using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CostCenterGroup entity
/// </summary>
public sealed class CostCenterGroupCreatedEvent : DomainEvent
{
    public CostCenterGroupId CostCenterGroupId { get; }

    public CostCenterGroupCreatedEvent(CostCenterGroupId costcentergroupId)
    {
        CostCenterGroupId = costcentergroupId;
    }
}

public sealed class CostCenterGroupUpdatedEvent : DomainEvent
{
    public CostCenterGroupId CostCenterGroupId { get; }

    public CostCenterGroupUpdatedEvent(CostCenterGroupId costcentergroupId)
    {
        CostCenterGroupId = costcentergroupId;
    }
}

public sealed class CostCenterGroupDeletedEvent : DomainEvent
{
    public CostCenterGroupId CostCenterGroupId { get; }

    public CostCenterGroupDeletedEvent(CostCenterGroupId costcentergroupId)
    {
        CostCenterGroupId = costcentergroupId;
    }
}
}
