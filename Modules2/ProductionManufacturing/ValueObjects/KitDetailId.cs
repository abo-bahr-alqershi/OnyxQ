using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// KitDetail Identifier Value Object
/// </summary>
public sealed class KitDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the KitDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new KitDetailId instance
    /// </summary>
    public KitDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new KitDetailId with a new GUID
    /// </summary>
    public static KitDetailId CreateUnique()
    {
        return new KitDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(KitDetailId id) => id.Value.ToString();
    public static implicit operator Guid(KitDetailId id) => id.Value;
}
}
