using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemMeasureDetail Identifier Value Object
/// </summary>
public sealed class ItemMeasureDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemMeasureDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemMeasureDetailId instance
    /// </summary>
    public ItemMeasureDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemMeasureDetailId with a new GUID
    /// </summary>
    public static ItemMeasureDetailId CreateUnique()
    {
        return new ItemMeasureDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemMeasureDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ItemMeasureDetailId id) => id.Value;
}
}
