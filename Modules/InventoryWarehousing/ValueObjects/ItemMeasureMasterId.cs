using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemMeasureMaster Identifier Value Object
/// </summary>
public sealed class ItemMeasureMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemMeasureMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemMeasureMasterId instance
    /// </summary>
    public ItemMeasureMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemMeasureMasterId with a new GUID
    /// </summary>
    public static ItemMeasureMasterId CreateUnique()
    {
        return new ItemMeasureMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemMeasureMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ItemMeasureMasterId id) => id.Value;
}
}
