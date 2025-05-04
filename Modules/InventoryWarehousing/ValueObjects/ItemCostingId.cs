using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemCosting Identifier Value Object
/// </summary>
public sealed class ItemCostingId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemCosting
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemCostingId instance
    /// </summary>
    public ItemCostingId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemCostingId with a new GUID
    /// </summary>
    public static ItemCostingId CreateUnique()
    {
        return new ItemCostingId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemCostingId id) => id.Value.ToString();
    public static implicit operator Guid(ItemCostingId id) => id.Value;
}
}
