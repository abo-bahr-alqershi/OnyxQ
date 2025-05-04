using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to UserHead entity
/// </summary>
public sealed class UserHeadCreatedEvent : DomainEvent
{
    public UserHeadId UserHeadId { get; }

    public UserHeadCreatedEvent(UserHeadId userheadId)
    {
        UserHeadId = userheadId;
    }
}

public sealed class UserHeadUpdatedEvent : DomainEvent
{
    public UserHeadId UserHeadId { get; }

    public UserHeadUpdatedEvent(UserHeadId userheadId)
    {
        UserHeadId = userheadId;
    }
}

public sealed class UserHeadDeletedEvent : DomainEvent
{
    public UserHeadId UserHeadId { get; }

    public UserHeadDeletedEvent(UserHeadId userheadId)
    {
        UserHeadId = userheadId;
    }
}
}
