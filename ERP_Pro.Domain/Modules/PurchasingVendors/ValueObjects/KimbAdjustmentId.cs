using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// KimbAdjustment Identifier Value Object
/// </summary>
public sealed class KimbAdjustmentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the KimbAdjustment
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new KimbAdjustmentId instance
    /// </summary>
    public KimbAdjustmentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new KimbAdjustmentId with a new GUID
    /// </summary>
    public static KimbAdjustmentId CreateUnique()
    {
        return new KimbAdjustmentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(KimbAdjustmentId id) => id.Value.ToString();
    public static implicit operator Guid(KimbAdjustmentId id) => id.Value;
}
}
