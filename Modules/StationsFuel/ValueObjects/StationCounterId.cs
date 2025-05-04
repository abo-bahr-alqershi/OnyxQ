using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationCounter Identifier Value Object
/// </summary>
public sealed class StationCounterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationCounter
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationCounterId instance
    /// </summary>
    public StationCounterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationCounterId with a new GUID
    /// </summary>
    public static StationCounterId CreateUnique()
    {
        return new StationCounterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationCounterId id) => id.Value.ToString();
    public static implicit operator Guid(StationCounterId id) => id.Value;
}
}
