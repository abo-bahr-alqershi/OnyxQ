using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to StorageWithChildTemp entity
/// </summary>
public sealed class StorageWithChildTempCreatedEvent : DomainEvent
{
    public StorageWithChildTempId StorageWithChildTempId { get; }

    public StorageWithChildTempCreatedEvent(StorageWithChildTempId storagewithchildtempId)
    {
        StorageWithChildTempId = storagewithchildtempId;
    }
}

public sealed class StorageWithChildTempUpdatedEvent : DomainEvent
{
    public StorageWithChildTempId StorageWithChildTempId { get; }

    public StorageWithChildTempUpdatedEvent(StorageWithChildTempId storagewithchildtempId)
    {
        StorageWithChildTempId = storagewithchildtempId;
    }
}

public sealed class StorageWithChildTempDeletedEvent : DomainEvent
{
    public StorageWithChildTempId StorageWithChildTempId { get; }

    public StorageWithChildTempDeletedEvent(StorageWithChildTempId storagewithchildtempId)
    {
        StorageWithChildTempId = storagewithchildtempId;
    }
}
}
