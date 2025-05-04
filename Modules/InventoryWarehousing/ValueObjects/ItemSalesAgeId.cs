using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemSalesAge Identifier Value Object
/// </summary>
public sealed class ItemSalesAgeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemSalesAge
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemSalesAgeId instance
    /// </summary>
    public ItemSalesAgeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemSalesAgeId with a new GUID
    /// </summary>
    public static ItemSalesAgeId CreateUnique()
    {
        return new ItemSalesAgeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemSalesAgeId id) => id.Value.ToString();
    public static implicit operator Guid(ItemSalesAgeId id) => id.Value;
}
}
