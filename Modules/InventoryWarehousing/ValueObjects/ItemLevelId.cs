using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemLevel Identifier Value Object
/// </summary>
public sealed class ItemLevelId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemLevel
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemLevelId instance
    /// </summary>
    public ItemLevelId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemLevelId with a new GUID
    /// </summary>
    public static ItemLevelId CreateUnique()
    {
        return new ItemLevelId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemLevelId id) => id.Value.ToString();
    public static implicit operator Guid(ItemLevelId id) => id.Value;
}
}
