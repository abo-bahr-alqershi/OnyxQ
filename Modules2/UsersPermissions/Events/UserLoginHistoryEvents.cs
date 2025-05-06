using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to UserLoginHistory entity
/// </summary>
public sealed class UserLoginHistoryCreatedEvent : DomainEvent
{
    public UserLoginHistoryId UserLoginHistoryId { get; }

    public UserLoginHistoryCreatedEvent(UserLoginHistoryId userloginhistoryId)
    {
        UserLoginHistoryId = userloginhistoryId;
    }
}

public sealed class UserLoginHistoryUpdatedEvent : DomainEvent
{
    public UserLoginHistoryId UserLoginHistoryId { get; }

    public UserLoginHistoryUpdatedEvent(UserLoginHistoryId userloginhistoryId)
    {
        UserLoginHistoryId = userloginhistoryId;
    }
}

public sealed class UserLoginHistoryDeletedEvent : DomainEvent
{
    public UserLoginHistoryId UserLoginHistoryId { get; }

    public UserLoginHistoryDeletedEvent(UserLoginHistoryId userloginhistoryId)
    {
        UserLoginHistoryId = userloginhistoryId;
    }
}
}
