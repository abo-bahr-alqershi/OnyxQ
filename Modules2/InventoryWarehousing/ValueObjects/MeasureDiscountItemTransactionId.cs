using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// MeasureDiscountItemTransaction Identifier Value Object
/// </summary>
public sealed class MeasureDiscountItemTransactionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MeasureDiscountItemTransaction
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MeasureDiscountItemTransactionId instance
    /// </summary>
    public MeasureDiscountItemTransactionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MeasureDiscountItemTransactionId with a new GUID
    /// </summary>
    public static MeasureDiscountItemTransactionId CreateUnique()
    {
        return new MeasureDiscountItemTransactionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MeasureDiscountItemTransactionId id) => id.Value.ToString();
    public static implicit operator Guid(MeasureDiscountItemTransactionId id) => id.Value;
}
}
