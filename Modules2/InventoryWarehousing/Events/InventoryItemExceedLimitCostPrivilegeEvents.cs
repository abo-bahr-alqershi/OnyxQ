using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryItemExceedLimitCostPrivilege entity
/// </summary>
public sealed class InventoryItemExceedLimitCostPrivilegeCreatedEvent : DomainEvent
{
    public InventoryItemExceedLimitCostPrivilegeId InventoryItemExceedLimitCostPrivilegeId { get; }

    public InventoryItemExceedLimitCostPrivilegeCreatedEvent(InventoryItemExceedLimitCostPrivilegeId inventoryitemexceedlimitcostprivilegeId)
    {
        InventoryItemExceedLimitCostPrivilegeId = inventoryitemexceedlimitcostprivilegeId;
    }
}

public sealed class InventoryItemExceedLimitCostPrivilegeUpdatedEvent : DomainEvent
{
    public InventoryItemExceedLimitCostPrivilegeId InventoryItemExceedLimitCostPrivilegeId { get; }

    public InventoryItemExceedLimitCostPrivilegeUpdatedEvent(InventoryItemExceedLimitCostPrivilegeId inventoryitemexceedlimitcostprivilegeId)
    {
        InventoryItemExceedLimitCostPrivilegeId = inventoryitemexceedlimitcostprivilegeId;
    }
}

public sealed class InventoryItemExceedLimitCostPrivilegeDeletedEvent : DomainEvent
{
    public InventoryItemExceedLimitCostPrivilegeId InventoryItemExceedLimitCostPrivilegeId { get; }

    public InventoryItemExceedLimitCostPrivilegeDeletedEvent(InventoryItemExceedLimitCostPrivilegeId inventoryitemexceedlimitcostprivilegeId)
    {
        InventoryItemExceedLimitCostPrivilegeId = inventoryitemexceedlimitcostprivilegeId;
    }
}
}
