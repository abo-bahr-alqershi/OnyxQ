using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeStockAdjustmentTypes entity
/// </summary>
public sealed class PrivilegeStockAdjustmentTypesCreatedEvent : DomainEvent
{
    public PrivilegeStockAdjustmentTypesId PrivilegeStockAdjustmentTypesId { get; }

    public PrivilegeStockAdjustmentTypesCreatedEvent(PrivilegeStockAdjustmentTypesId privilegestockadjustmenttypesId)
    {
        PrivilegeStockAdjustmentTypesId = privilegestockadjustmenttypesId;
    }
}

public sealed class PrivilegeStockAdjustmentTypesUpdatedEvent : DomainEvent
{
    public PrivilegeStockAdjustmentTypesId PrivilegeStockAdjustmentTypesId { get; }

    public PrivilegeStockAdjustmentTypesUpdatedEvent(PrivilegeStockAdjustmentTypesId privilegestockadjustmenttypesId)
    {
        PrivilegeStockAdjustmentTypesId = privilegestockadjustmenttypesId;
    }
}

public sealed class PrivilegeStockAdjustmentTypesDeletedEvent : DomainEvent
{
    public PrivilegeStockAdjustmentTypesId PrivilegeStockAdjustmentTypesId { get; }

    public PrivilegeStockAdjustmentTypesDeletedEvent(PrivilegeStockAdjustmentTypesId privilegestockadjustmenttypesId)
    {
        PrivilegeStockAdjustmentTypesId = privilegestockadjustmenttypesId;
    }
}
}
