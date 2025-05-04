using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to UserTransactionPrivilege entity
/// </summary>
public sealed class UserTransactionPrivilegeCreatedEvent : DomainEvent
{
    public UserTransactionPrivilegeId UserTransactionPrivilegeId { get; }

    public UserTransactionPrivilegeCreatedEvent(UserTransactionPrivilegeId usertransactionprivilegeId)
    {
        UserTransactionPrivilegeId = usertransactionprivilegeId;
    }
}

public sealed class UserTransactionPrivilegeUpdatedEvent : DomainEvent
{
    public UserTransactionPrivilegeId UserTransactionPrivilegeId { get; }

    public UserTransactionPrivilegeUpdatedEvent(UserTransactionPrivilegeId usertransactionprivilegeId)
    {
        UserTransactionPrivilegeId = usertransactionprivilegeId;
    }
}

public sealed class UserTransactionPrivilegeDeletedEvent : DomainEvent
{
    public UserTransactionPrivilegeId UserTransactionPrivilegeId { get; }

    public UserTransactionPrivilegeDeletedEvent(UserTransactionPrivilegeId usertransactionprivilegeId)
    {
        UserTransactionPrivilegeId = usertransactionprivilegeId;
    }
}
}
