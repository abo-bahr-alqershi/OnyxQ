using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// DefaultPriceLevel Identifier Value Object
/// </summary>
public sealed class DefaultPriceLevelId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DefaultPriceLevel
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DefaultPriceLevelId instance
    /// </summary>
    public DefaultPriceLevelId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DefaultPriceLevelId with a new GUID
    /// </summary>
    public static DefaultPriceLevelId CreateUnique()
    {
        return new DefaultPriceLevelId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DefaultPriceLevelId id) => id.Value.ToString();
    public static implicit operator Guid(DefaultPriceLevelId id) => id.Value;
}
}
