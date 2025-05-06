using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to UserNote entity
/// </summary>
public sealed class UserNoteCreatedEvent : DomainEvent
{
    public UserNoteId UserNoteId { get; }

    public UserNoteCreatedEvent(UserNoteId usernoteId)
    {
        UserNoteId = usernoteId;
    }
}

public sealed class UserNoteUpdatedEvent : DomainEvent
{
    public UserNoteId UserNoteId { get; }

    public UserNoteUpdatedEvent(UserNoteId usernoteId)
    {
        UserNoteId = usernoteId;
    }
}

public sealed class UserNoteDeletedEvent : DomainEvent
{
    public UserNoteId UserNoteId { get; }

    public UserNoteDeletedEvent(UserNoteId usernoteId)
    {
        UserNoteId = usernoteId;
    }
}
}
