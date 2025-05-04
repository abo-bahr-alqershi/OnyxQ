using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationCounterEmployee Identifier Value Object
/// </summary>
public sealed class StationCounterEmployeeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationCounterEmployee
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationCounterEmployeeId instance
    /// </summary>
    public StationCounterEmployeeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationCounterEmployeeId with a new GUID
    /// </summary>
    public static StationCounterEmployeeId CreateUnique()
    {
        return new StationCounterEmployeeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationCounterEmployeeId id) => id.Value.ToString();
    public static implicit operator Guid(StationCounterEmployeeId id) => id.Value;
}
}
