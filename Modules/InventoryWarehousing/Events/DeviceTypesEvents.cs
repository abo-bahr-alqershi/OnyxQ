using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to DeviceTypes entity
/// </summary>
public sealed class DeviceTypesCreatedEvent : DomainEvent
{
    public DeviceTypesId DeviceTypesId { get; }

    public DeviceTypesCreatedEvent(DeviceTypesId devicetypesId)
    {
        DeviceTypesId = devicetypesId;
    }
}

public sealed class DeviceTypesUpdatedEvent : DomainEvent
{
    public DeviceTypesId DeviceTypesId { get; }

    public DeviceTypesUpdatedEvent(DeviceTypesId devicetypesId)
    {
        DeviceTypesId = devicetypesId;
    }
}

public sealed class DeviceTypesDeletedEvent : DomainEvent
{
    public DeviceTypesId DeviceTypesId { get; }

    public DeviceTypesDeletedEvent(DeviceTypesId devicetypesId)
    {
        DeviceTypesId = devicetypesId;
    }
}
}
