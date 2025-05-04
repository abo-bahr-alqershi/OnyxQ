using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects
{
/// <summary>
/// DriverIdentification Identifier Value Object
/// </summary>
public sealed class DriverIdentificationId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DriverIdentification
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DriverIdentificationId instance
    /// </summary>
    public DriverIdentificationId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DriverIdentificationId with a new GUID
    /// </summary>
    public static DriverIdentificationId CreateUnique()
    {
        return new DriverIdentificationId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DriverIdentificationId id) => id.Value.ToString();
    public static implicit operator Guid(DriverIdentificationId id) => id.Value;
}
}
