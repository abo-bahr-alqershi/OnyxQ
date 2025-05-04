using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemPriceHistory Identifier Value Object
/// </summary>
public sealed class ItemPriceHistoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemPriceHistory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemPriceHistoryId instance
    /// </summary>
    public ItemPriceHistoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemPriceHistoryId with a new GUID
    /// </summary>
    public static ItemPriceHistoryId CreateUnique()
    {
        return new ItemPriceHistoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemPriceHistoryId id) => id.Value.ToString();
    public static implicit operator Guid(ItemPriceHistoryId id) => id.Value;
}
}
