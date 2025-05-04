using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationFuelType Identifier Value Object
/// </summary>
public sealed class StationFuelTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationFuelType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationFuelTypeId instance
    /// </summary>
    public StationFuelTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationFuelTypeId with a new GUID
    /// </summary>
    public static StationFuelTypeId CreateUnique()
    {
        return new StationFuelTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationFuelTypeId id) => id.Value.ToString();
    public static implicit operator Guid(StationFuelTypeId id) => id.Value;
}
}
