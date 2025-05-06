using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// KitItemDetail Identifier Value Object
/// </summary>
public sealed class KitItemDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the KitItemDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new KitItemDetailId instance
    /// </summary>
    public KitItemDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new KitItemDetailId with a new GUID
    /// </summary>
    public static KitItemDetailId CreateUnique()
    {
        return new KitItemDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(KitItemDetailId id) => id.Value.ToString();
    public static implicit operator Guid(KitItemDetailId id) => id.Value;
}
}
