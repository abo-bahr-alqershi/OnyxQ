using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemLevelMeasure Identifier Value Object
/// </summary>
public sealed class ItemLevelMeasureId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemLevelMeasure
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemLevelMeasureId instance
    /// </summary>
    public ItemLevelMeasureId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemLevelMeasureId with a new GUID
    /// </summary>
    public static ItemLevelMeasureId CreateUnique()
    {
        return new ItemLevelMeasureId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemLevelMeasureId id) => id.Value.ToString();
    public static implicit operator Guid(ItemLevelMeasureId id) => id.Value;
}
}
