using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to CostingType entity
/// </summary>
public sealed class CostingTypeCreatedEvent : DomainEvent
{
    public CostingTypeId CostingTypeId { get; }

    public CostingTypeCreatedEvent(CostingTypeId costingtypeId)
    {
        CostingTypeId = costingtypeId;
    }
}

public sealed class CostingTypeUpdatedEvent : DomainEvent
{
    public CostingTypeId CostingTypeId { get; }

    public CostingTypeUpdatedEvent(CostingTypeId costingtypeId)
    {
        CostingTypeId = costingtypeId;
    }
}

public sealed class CostingTypeDeletedEvent : DomainEvent
{
    public CostingTypeId CostingTypeId { get; }

    public CostingTypeDeletedEvent(CostingTypeId costingtypeId)
    {
        CostingTypeId = costingtypeId;
    }
}
}
