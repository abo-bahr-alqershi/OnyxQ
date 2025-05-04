using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeAccountsPayable entity
/// </summary>
public sealed class PrivilegeAccountsPayableCreatedEvent : DomainEvent
{
    public PrivilegeAccountsPayableId PrivilegeAccountsPayableId { get; }

    public PrivilegeAccountsPayableCreatedEvent(PrivilegeAccountsPayableId privilegeaccountspayableId)
    {
        PrivilegeAccountsPayableId = privilegeaccountspayableId;
    }
}

public sealed class PrivilegeAccountsPayableUpdatedEvent : DomainEvent
{
    public PrivilegeAccountsPayableId PrivilegeAccountsPayableId { get; }

    public PrivilegeAccountsPayableUpdatedEvent(PrivilegeAccountsPayableId privilegeaccountspayableId)
    {
        PrivilegeAccountsPayableId = privilegeaccountspayableId;
    }
}

public sealed class PrivilegeAccountsPayableDeletedEvent : DomainEvent
{
    public PrivilegeAccountsPayableId PrivilegeAccountsPayableId { get; }

    public PrivilegeAccountsPayableDeletedEvent(PrivilegeAccountsPayableId privilegeaccountspayableId)
    {
        PrivilegeAccountsPayableId = privilegeaccountspayableId;
    }
}
}
