using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerDevices Identifier Value Object
/// </summary>
public sealed class CustomerDevicesId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerDevices
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerDevicesId instance
    /// </summary>
    public CustomerDevicesId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerDevicesId with a new GUID
    /// </summary>
    public static CustomerDevicesId CreateUnique()
    {
        return new CustomerDevicesId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerDevicesId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerDevicesId id) => id.Value;
}
}
