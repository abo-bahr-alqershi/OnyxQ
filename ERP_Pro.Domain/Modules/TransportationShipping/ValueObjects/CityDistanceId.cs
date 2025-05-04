using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects
{
/// <summary>
/// CityDistance Identifier Value Object
/// </summary>
public sealed class CityDistanceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CityDistance
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CityDistanceId instance
    /// </summary>
    public CityDistanceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CityDistanceId with a new GUID
    /// </summary>
    public static CityDistanceId CreateUnique()
    {
        return new CityDistanceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CityDistanceId id) => id.Value.ToString();
    public static implicit operator Guid(CityDistanceId id) => id.Value;
}
}
