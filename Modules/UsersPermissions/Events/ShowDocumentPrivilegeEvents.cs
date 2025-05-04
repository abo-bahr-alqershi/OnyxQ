using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to ShowDocumentPrivilege entity
/// </summary>
public sealed class ShowDocumentPrivilegeCreatedEvent : DomainEvent
{
    public ShowDocumentPrivilegeId ShowDocumentPrivilegeId { get; }

    public ShowDocumentPrivilegeCreatedEvent(ShowDocumentPrivilegeId showdocumentprivilegeId)
    {
        ShowDocumentPrivilegeId = showdocumentprivilegeId;
    }
}

public sealed class ShowDocumentPrivilegeUpdatedEvent : DomainEvent
{
    public ShowDocumentPrivilegeId ShowDocumentPrivilegeId { get; }

    public ShowDocumentPrivilegeUpdatedEvent(ShowDocumentPrivilegeId showdocumentprivilegeId)
    {
        ShowDocumentPrivilegeId = showdocumentprivilegeId;
    }
}

public sealed class ShowDocumentPrivilegeDeletedEvent : DomainEvent
{
    public ShowDocumentPrivilegeId ShowDocumentPrivilegeId { get; }

    public ShowDocumentPrivilegeDeletedEvent(ShowDocumentPrivilegeId showdocumentprivilegeId)
    {
        ShowDocumentPrivilegeId = showdocumentprivilegeId;
    }
}
}
