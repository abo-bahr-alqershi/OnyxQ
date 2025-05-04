using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemNotStoreTemp Identifier Value Object
/// </summary>
public sealed class ItemNotStoreTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemNotStoreTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemNotStoreTempId instance
    /// </summary>
    public ItemNotStoreTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemNotStoreTempId with a new GUID
    /// </summary>
    public static ItemNotStoreTempId CreateUnique()
    {
        return new ItemNotStoreTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemNotStoreTempId id) => id.Value.ToString();
    public static implicit operator Guid(ItemNotStoreTempId id) => id.Value;
}
}
