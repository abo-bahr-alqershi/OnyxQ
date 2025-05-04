using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemType Identifier Value Object
/// </summary>
public sealed class ItemTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemTypeId instance
    /// </summary>
    public ItemTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemTypeId with a new GUID
    /// </summary>
    public static ItemTypeId CreateUnique()
    {
        return new ItemTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemTypeId id) => id.Value.ToString();
    public static implicit operator Guid(ItemTypeId id) => id.Value;
}
}
