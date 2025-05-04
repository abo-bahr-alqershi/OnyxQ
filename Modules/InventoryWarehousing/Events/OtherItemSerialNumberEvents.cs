using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to OtherItemSerialNumber entity
/// </summary>
public sealed class OtherItemSerialNumberCreatedEvent : DomainEvent
{
    public OtherItemSerialNumberId OtherItemSerialNumberId { get; }

    public OtherItemSerialNumberCreatedEvent(OtherItemSerialNumberId otheritemserialnumberId)
    {
        OtherItemSerialNumberId = otheritemserialnumberId;
    }
}

public sealed class OtherItemSerialNumberUpdatedEvent : DomainEvent
{
    public OtherItemSerialNumberId OtherItemSerialNumberId { get; }

    public OtherItemSerialNumberUpdatedEvent(OtherItemSerialNumberId otheritemserialnumberId)
    {
        OtherItemSerialNumberId = otheritemserialnumberId;
    }
}

public sealed class OtherItemSerialNumberDeletedEvent : DomainEvent
{
    public OtherItemSerialNumberId OtherItemSerialNumberId { get; }

    public OtherItemSerialNumberDeletedEvent(OtherItemSerialNumberId otheritemserialnumberId)
    {
        OtherItemSerialNumberId = otheritemserialnumberId;
    }
}
}
