using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemPeriodicCost Identifier Value Object
/// </summary>
public sealed class ItemPeriodicCostId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemPeriodicCost
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemPeriodicCostId instance
    /// </summary>
    public ItemPeriodicCostId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemPeriodicCostId with a new GUID
    /// </summary>
    public static ItemPeriodicCostId CreateUnique()
    {
        return new ItemPeriodicCostId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemPeriodicCostId id) => id.Value.ToString();
    public static implicit operator Guid(ItemPeriodicCostId id) => id.Value;
}
}
