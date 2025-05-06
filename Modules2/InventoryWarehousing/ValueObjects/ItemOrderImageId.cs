using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemOrderImage Identifier Value Object
/// </summary>
public sealed class ItemOrderImageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemOrderImage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemOrderImageId instance
    /// </summary>
    public ItemOrderImageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemOrderImageId with a new GUID
    /// </summary>
    public static ItemOrderImageId CreateUnique()
    {
        return new ItemOrderImageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemOrderImageId id) => id.Value.ToString();
    public static implicit operator Guid(ItemOrderImageId id) => id.Value;
}
}
