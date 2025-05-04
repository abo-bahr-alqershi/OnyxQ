using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemPrice Identifier Value Object
/// </summary>
public sealed class ItemPriceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemPrice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemPriceId instance
    /// </summary>
    public ItemPriceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemPriceId with a new GUID
    /// </summary>
    public static ItemPriceId CreateUnique()
    {
        return new ItemPriceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemPriceId id) => id.Value.ToString();
    public static implicit operator Guid(ItemPriceId id) => id.Value;
}
}
