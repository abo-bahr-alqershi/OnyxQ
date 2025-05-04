using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemOrder Identifier Value Object
/// </summary>
public sealed class ItemOrderId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemOrder
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemOrderId instance
    /// </summary>
    public ItemOrderId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemOrderId with a new GUID
    /// </summary>
    public static ItemOrderId CreateUnique()
    {
        return new ItemOrderId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemOrderId id) => id.Value.ToString();
    public static implicit operator Guid(ItemOrderId id) => id.Value;
}
}
