using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemStoreTemp Identifier Value Object
/// </summary>
public sealed class ItemStoreTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemStoreTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemStoreTempId instance
    /// </summary>
    public ItemStoreTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemStoreTempId with a new GUID
    /// </summary>
    public static ItemStoreTempId CreateUnique()
    {
        return new ItemStoreTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemStoreTempId id) => id.Value.ToString();
    public static implicit operator Guid(ItemStoreTempId id) => id.Value;
}
}
