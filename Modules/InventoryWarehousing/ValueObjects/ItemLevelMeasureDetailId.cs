using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemLevelMeasureDetail Identifier Value Object
/// </summary>
public sealed class ItemLevelMeasureDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemLevelMeasureDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemLevelMeasureDetailId instance
    /// </summary>
    public ItemLevelMeasureDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemLevelMeasureDetailId with a new GUID
    /// </summary>
    public static ItemLevelMeasureDetailId CreateUnique()
    {
        return new ItemLevelMeasureDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemLevelMeasureDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ItemLevelMeasureDetailId id) => id.Value;
}
}
