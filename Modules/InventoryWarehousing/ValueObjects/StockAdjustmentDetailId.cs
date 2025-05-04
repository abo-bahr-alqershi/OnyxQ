using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// StockAdjustmentDetail Identifier Value Object
/// </summary>
public sealed class StockAdjustmentDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StockAdjustmentDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StockAdjustmentDetailId instance
    /// </summary>
    public StockAdjustmentDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StockAdjustmentDetailId with a new GUID
    /// </summary>
    public static StockAdjustmentDetailId CreateUnique()
    {
        return new StockAdjustmentDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StockAdjustmentDetailId id) => id.Value.ToString();
    public static implicit operator Guid(StockAdjustmentDetailId id) => id.Value;
}
}
