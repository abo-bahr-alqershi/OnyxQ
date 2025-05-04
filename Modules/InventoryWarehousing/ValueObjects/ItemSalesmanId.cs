using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemSalesman Identifier Value Object
/// </summary>
public sealed class ItemSalesmanId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemSalesman
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemSalesmanId instance
    /// </summary>
    public ItemSalesmanId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemSalesmanId with a new GUID
    /// </summary>
    public static ItemSalesmanId CreateUnique()
    {
        return new ItemSalesmanId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemSalesmanId id) => id.Value.ToString();
    public static implicit operator Guid(ItemSalesmanId id) => id.Value;
}
}
