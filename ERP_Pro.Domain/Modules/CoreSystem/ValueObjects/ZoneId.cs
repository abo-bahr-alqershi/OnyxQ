using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// Zone Identifier Value Object
/// </summary>
public sealed class ZoneId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Zone
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ZoneId instance
    /// </summary>
    public ZoneId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ZoneId with a new GUID
    /// </summary>
    public static ZoneId CreateUnique()
    {
        return new ZoneId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ZoneId id) => id.Value.ToString();
    public static implicit operator Guid(ZoneId id) => id.Value;
}
}
