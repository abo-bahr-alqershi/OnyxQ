using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// LovSelect Identifier Value Object
/// </summary>
public sealed class LovSelectId : ValueObject
{
    /// <summary>
    /// The unique identifier for the LovSelect
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new LovSelectId instance
    /// </summary>
    public LovSelectId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new LovSelectId with a new GUID
    /// </summary>
    public static LovSelectId CreateUnique()
    {
        return new LovSelectId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(LovSelectId id) => id.Value.ToString();
    public static implicit operator Guid(LovSelectId id) => id.Value;
}
}
