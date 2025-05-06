using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// MeasureDiscountItemDetail Identifier Value Object
/// </summary>
public sealed class MeasureDiscountItemDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MeasureDiscountItemDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MeasureDiscountItemDetailId instance
    /// </summary>
    public MeasureDiscountItemDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MeasureDiscountItemDetailId with a new GUID
    /// </summary>
    public static MeasureDiscountItemDetailId CreateUnique()
    {
        return new MeasureDiscountItemDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MeasureDiscountItemDetailId id) => id.Value.ToString();
    public static implicit operator Guid(MeasureDiscountItemDetailId id) => id.Value;
}
}
