using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ListSelect Identifier Value Object
/// </summary>
public sealed class ListSelectId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ListSelect
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ListSelectId instance
    /// </summary>
    public ListSelectId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ListSelectId with a new GUID
    /// </summary>
    public static ListSelectId CreateUnique()
    {
        return new ListSelectId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ListSelectId id) => id.Value.ToString();
    public static implicit operator Guid(ListSelectId id) => id.Value;
}
}
