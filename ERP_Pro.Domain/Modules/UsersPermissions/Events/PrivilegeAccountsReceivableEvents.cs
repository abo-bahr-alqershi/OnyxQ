using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeAccountsReceivable entity
/// </summary>
public sealed class PrivilegeAccountsReceivableCreatedEvent : DomainEvent
{
    public PrivilegeAccountsReceivableId PrivilegeAccountsReceivableId { get; }

    public PrivilegeAccountsReceivableCreatedEvent(PrivilegeAccountsReceivableId privilegeaccountsreceivableId)
    {
        PrivilegeAccountsReceivableId = privilegeaccountsreceivableId;
    }
}

public sealed class PrivilegeAccountsReceivableUpdatedEvent : DomainEvent
{
    public PrivilegeAccountsReceivableId PrivilegeAccountsReceivableId { get; }

    public PrivilegeAccountsReceivableUpdatedEvent(PrivilegeAccountsReceivableId privilegeaccountsreceivableId)
    {
        PrivilegeAccountsReceivableId = privilegeaccountsreceivableId;
    }
}

public sealed class PrivilegeAccountsReceivableDeletedEvent : DomainEvent
{
    public PrivilegeAccountsReceivableId PrivilegeAccountsReceivableId { get; }

    public PrivilegeAccountsReceivableDeletedEvent(PrivilegeAccountsReceivableId privilegeaccountsreceivableId)
    {
        PrivilegeAccountsReceivableId = privilegeaccountsreceivableId;
    }
}
}
