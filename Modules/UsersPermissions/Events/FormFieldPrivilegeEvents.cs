using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to FormFieldPrivilege entity
/// </summary>
public sealed class FormFieldPrivilegeCreatedEvent : DomainEvent
{
    public FormFieldPrivilegeId FormFieldPrivilegeId { get; }

    public FormFieldPrivilegeCreatedEvent(FormFieldPrivilegeId formfieldprivilegeId)
    {
        FormFieldPrivilegeId = formfieldprivilegeId;
    }
}

public sealed class FormFieldPrivilegeUpdatedEvent : DomainEvent
{
    public FormFieldPrivilegeId FormFieldPrivilegeId { get; }

    public FormFieldPrivilegeUpdatedEvent(FormFieldPrivilegeId formfieldprivilegeId)
    {
        FormFieldPrivilegeId = formfieldprivilegeId;
    }
}

public sealed class FormFieldPrivilegeDeletedEvent : DomainEvent
{
    public FormFieldPrivilegeId FormFieldPrivilegeId { get; }

    public FormFieldPrivilegeDeletedEvent(FormFieldPrivilegeId formfieldprivilegeId)
    {
        FormFieldPrivilegeId = formfieldprivilegeId;
    }
}
}
