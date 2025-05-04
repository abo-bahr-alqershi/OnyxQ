using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// CustomerHandheldDevice Identifier Value Object
/// </summary>
public sealed class CustomerHandheldDeviceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerHandheldDevice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerHandheldDeviceId instance
    /// </summary>
    public CustomerHandheldDeviceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerHandheldDeviceId with a new GUID
    /// </summary>
    public static CustomerHandheldDeviceId CreateUnique()
    {
        return new CustomerHandheldDeviceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerHandheldDeviceId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerHandheldDeviceId id) => id.Value;
}
}
