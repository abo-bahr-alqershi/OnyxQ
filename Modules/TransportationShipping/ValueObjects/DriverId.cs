using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects
{
/// <summary>
/// Driver Identifier Value Object
/// </summary>
public sealed class DriverId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Driver
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DriverId instance
    /// </summary>
    public DriverId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DriverId with a new GUID
    /// </summary>
    public static DriverId CreateUnique()
    {
        return new DriverId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DriverId id) => id.Value.ToString();
    public static implicit operator Guid(DriverId id) => id.Value;
}
}
