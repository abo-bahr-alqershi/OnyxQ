using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
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
