using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// CompoundItem Identifier Value Object
/// </summary>
public sealed class CompoundItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CompoundItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CompoundItemId instance
    /// </summary>
    public CompoundItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CompoundItemId with a new GUID
    /// </summary>
    public static CompoundItemId CreateUnique()
    {
        return new CompoundItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CompoundItemId id) => id.Value.ToString();
    public static implicit operator Guid(CompoundItemId id) => id.Value;
}
}
