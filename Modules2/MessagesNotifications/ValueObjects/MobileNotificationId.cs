using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// MobileNotification Identifier Value Object
/// </summary>
public sealed class MobileNotificationId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MobileNotification
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MobileNotificationId instance
    /// </summary>
    public MobileNotificationId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MobileNotificationId with a new GUID
    /// </summary>
    public static MobileNotificationId CreateUnique()
    {
        return new MobileNotificationId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MobileNotificationId id) => id.Value.ToString();
    public static implicit operator Guid(MobileNotificationId id) => id.Value;
}
}
