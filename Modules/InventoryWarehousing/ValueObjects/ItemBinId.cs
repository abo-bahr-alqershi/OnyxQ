using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemBin Identifier Value Object
/// </summary>
public sealed class ItemBinId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemBin
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemBinId instance
    /// </summary>
    public ItemBinId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemBinId with a new GUID
    /// </summary>
    public static ItemBinId CreateUnique()
    {
        return new ItemBinId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemBinId id) => id.Value.ToString();
    public static implicit operator Guid(ItemBinId id) => id.Value;
}
}
