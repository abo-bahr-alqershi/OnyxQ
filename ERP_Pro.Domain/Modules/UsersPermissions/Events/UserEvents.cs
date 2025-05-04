using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to User entity
/// </summary>
public sealed class UserCreatedEvent : DomainEvent
{
    public UserId UserId { get; }

    public UserCreatedEvent(UserId userId)
    {
        UserId = userId;
    }
}

public sealed class UserUpdatedEvent : DomainEvent
{
    public UserId UserId { get; }

    public UserUpdatedEvent(UserId userId)
    {
        UserId = userId;
    }
}

public sealed class UserDeletedEvent : DomainEvent
{
    public UserId UserId { get; }

    public UserDeletedEvent(UserId userId)
    {
        UserId = userId;
    }
}
}
