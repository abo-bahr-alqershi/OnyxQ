using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PromotionRegion Identifier Value Object
/// </summary>
public sealed class PromotionRegionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PromotionRegion
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PromotionRegionId instance
    /// </summary>
    public PromotionRegionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PromotionRegionId with a new GUID
    /// </summary>
    public static PromotionRegionId CreateUnique()
    {
        return new PromotionRegionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PromotionRegionId id) => id.Value.ToString();
    public static implicit operator Guid(PromotionRegionId id) => id.Value;
}
}
