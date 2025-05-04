using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemDetail Identifier Value Object
/// </summary>
public sealed class ItemDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemDetailId instance
    /// </summary>
    public ItemDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemDetailId with a new GUID
    /// </summary>
    public static ItemDetailId CreateUnique()
    {
        return new ItemDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ItemDetailId id) => id.Value;
}
}
