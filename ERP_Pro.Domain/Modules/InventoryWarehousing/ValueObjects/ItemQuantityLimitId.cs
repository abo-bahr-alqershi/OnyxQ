using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemQuantityLimit Identifier Value Object
/// </summary>
public sealed class ItemQuantityLimitId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemQuantityLimit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemQuantityLimitId instance
    /// </summary>
    public ItemQuantityLimitId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemQuantityLimitId with a new GUID
    /// </summary>
    public static ItemQuantityLimitId CreateUnique()
    {
        return new ItemQuantityLimitId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemQuantityLimitId id) => id.Value.ToString();
    public static implicit operator Guid(ItemQuantityLimitId id) => id.Value;
}
}
