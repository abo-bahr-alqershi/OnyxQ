using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeCollectors entity
/// </summary>
public sealed class PrivilegeCollectorsCreatedEvent : DomainEvent
{
    public PrivilegeCollectorsId PrivilegeCollectorsId { get; }

    public PrivilegeCollectorsCreatedEvent(PrivilegeCollectorsId privilegecollectorsId)
    {
        PrivilegeCollectorsId = privilegecollectorsId;
    }
}

public sealed class PrivilegeCollectorsUpdatedEvent : DomainEvent
{
    public PrivilegeCollectorsId PrivilegeCollectorsId { get; }

    public PrivilegeCollectorsUpdatedEvent(PrivilegeCollectorsId privilegecollectorsId)
    {
        PrivilegeCollectorsId = privilegecollectorsId;
    }
}

public sealed class PrivilegeCollectorsDeletedEvent : DomainEvent
{
    public PrivilegeCollectorsId PrivilegeCollectorsId { get; }

    public PrivilegeCollectorsDeletedEvent(PrivilegeCollectorsId privilegecollectorsId)
    {
        PrivilegeCollectorsId = privilegecollectorsId;
    }
}
}
