using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemMaster Identifier Value Object
/// </summary>
public sealed class ItemMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemMasterId instance
    /// </summary>
    public ItemMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemMasterId with a new GUID
    /// </summary>
    public static ItemMasterId CreateUnique()
    {
        return new ItemMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ItemMasterId id) => id.Value;
}
}
