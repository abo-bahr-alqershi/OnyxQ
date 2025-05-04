using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// AlternativeGroup Identifier Value Object
/// </summary>
public sealed class AlternativeGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AlternativeGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AlternativeGroupId instance
    /// </summary>
    public AlternativeGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AlternativeGroupId with a new GUID
    /// </summary>
    public static AlternativeGroupId CreateUnique()
    {
        return new AlternativeGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AlternativeGroupId id) => id.Value.ToString();
    public static implicit operator Guid(AlternativeGroupId id) => id.Value;
}
}
