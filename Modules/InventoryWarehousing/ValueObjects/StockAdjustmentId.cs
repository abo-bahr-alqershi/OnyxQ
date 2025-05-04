using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// StockAdjustment Identifier Value Object
/// </summary>
public sealed class StockAdjustmentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StockAdjustment
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StockAdjustmentId instance
    /// </summary>
    public StockAdjustmentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StockAdjustmentId with a new GUID
    /// </summary>
    public static StockAdjustmentId CreateUnique()
    {
        return new StockAdjustmentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StockAdjustmentId id) => id.Value.ToString();
    public static implicit operator Guid(StockAdjustmentId id) => id.Value;
}
}
