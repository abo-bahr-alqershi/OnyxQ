using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemCollectionTemp Identifier Value Object
/// </summary>
public sealed class ItemCollectionTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemCollectionTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemCollectionTempId instance
    /// </summary>
    public ItemCollectionTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemCollectionTempId with a new GUID
    /// </summary>
    public static ItemCollectionTempId CreateUnique()
    {
        return new ItemCollectionTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemCollectionTempId id) => id.Value.ToString();
    public static implicit operator Guid(ItemCollectionTempId id) => id.Value;
}
}
