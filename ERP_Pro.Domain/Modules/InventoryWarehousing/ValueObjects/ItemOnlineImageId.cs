using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemOnlineImage Identifier Value Object
/// </summary>
public sealed class ItemOnlineImageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemOnlineImage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemOnlineImageId instance
    /// </summary>
    public ItemOnlineImageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemOnlineImageId with a new GUID
    /// </summary>
    public static ItemOnlineImageId CreateUnique()
    {
        return new ItemOnlineImageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemOnlineImageId id) => id.Value.ToString();
    public static implicit operator Guid(ItemOnlineImageId id) => id.Value;
}
}
