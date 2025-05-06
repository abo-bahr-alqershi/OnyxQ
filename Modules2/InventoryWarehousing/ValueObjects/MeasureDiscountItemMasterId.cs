using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// MeasureDiscountItemMaster Identifier Value Object
/// </summary>
public sealed class MeasureDiscountItemMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MeasureDiscountItemMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MeasureDiscountItemMasterId instance
    /// </summary>
    public MeasureDiscountItemMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MeasureDiscountItemMasterId with a new GUID
    /// </summary>
    public static MeasureDiscountItemMasterId CreateUnique()
    {
        return new MeasureDiscountItemMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MeasureDiscountItemMasterId id) => id.Value.ToString();
    public static implicit operator Guid(MeasureDiscountItemMasterId id) => id.Value;
}
}
