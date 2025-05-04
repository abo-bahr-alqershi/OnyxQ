using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PricingLevel Identifier Value Object
/// </summary>
public sealed class PricingLevelId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PricingLevel
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PricingLevelId instance
    /// </summary>
    public PricingLevelId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PricingLevelId with a new GUID
    /// </summary>
    public static PricingLevelId CreateUnique()
    {
        return new PricingLevelId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PricingLevelId id) => id.Value.ToString();
    public static implicit operator Guid(PricingLevelId id) => id.Value;
}
}
