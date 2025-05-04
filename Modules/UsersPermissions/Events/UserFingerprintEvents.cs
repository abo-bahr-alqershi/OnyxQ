using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to UserFingerprint entity
/// </summary>
public sealed class UserFingerprintCreatedEvent : DomainEvent
{
    public UserFingerprintId UserFingerprintId { get; }

    public UserFingerprintCreatedEvent(UserFingerprintId userfingerprintId)
    {
        UserFingerprintId = userfingerprintId;
    }
}

public sealed class UserFingerprintUpdatedEvent : DomainEvent
{
    public UserFingerprintId UserFingerprintId { get; }

    public UserFingerprintUpdatedEvent(UserFingerprintId userfingerprintId)
    {
        UserFingerprintId = userfingerprintId;
    }
}

public sealed class UserFingerprintDeletedEvent : DomainEvent
{
    public UserFingerprintId UserFingerprintId { get; }

    public UserFingerprintDeletedEvent(UserFingerprintId userfingerprintId)
    {
        UserFingerprintId = userfingerprintId;
    }
}
}
