using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeNoteTypes entity
/// </summary>
public sealed class PrivilegeNoteTypesCreatedEvent : DomainEvent
{
    public PrivilegeNoteTypesId PrivilegeNoteTypesId { get; }

    public PrivilegeNoteTypesCreatedEvent(PrivilegeNoteTypesId privilegenotetypesId)
    {
        PrivilegeNoteTypesId = privilegenotetypesId;
    }
}

public sealed class PrivilegeNoteTypesUpdatedEvent : DomainEvent
{
    public PrivilegeNoteTypesId PrivilegeNoteTypesId { get; }

    public PrivilegeNoteTypesUpdatedEvent(PrivilegeNoteTypesId privilegenotetypesId)
    {
        PrivilegeNoteTypesId = privilegenotetypesId;
    }
}

public sealed class PrivilegeNoteTypesDeletedEvent : DomainEvent
{
    public PrivilegeNoteTypesId PrivilegeNoteTypesId { get; }

    public PrivilegeNoteTypesDeletedEvent(PrivilegeNoteTypesId privilegenotetypesId)
    {
        PrivilegeNoteTypesId = privilegenotetypesId;
    }
}
}
