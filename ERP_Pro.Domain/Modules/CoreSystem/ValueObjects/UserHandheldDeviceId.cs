using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// UserHandheldDevice Identifier Value Object
/// </summary>
public sealed class UserHandheldDeviceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserHandheldDevice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserHandheldDeviceId instance
    /// </summary>
    public UserHandheldDeviceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserHandheldDeviceId with a new GUID
    /// </summary>
    public static UserHandheldDeviceId CreateUnique()
    {
        return new UserHandheldDeviceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserHandheldDeviceId id) => id.Value.ToString();
    public static implicit operator Guid(UserHandheldDeviceId id) => id.Value;
}
}
