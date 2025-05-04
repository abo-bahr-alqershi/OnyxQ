using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// KitItem Identifier Value Object
/// </summary>
public sealed class KitItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the KitItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new KitItemId instance
    /// </summary>
    public KitItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new KitItemId with a new GUID
    /// </summary>
    public static KitItemId CreateUnique()
    {
        return new KitItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(KitItemId id) => id.Value.ToString();
    public static implicit operator Guid(KitItemId id) => id.Value;
}
}
