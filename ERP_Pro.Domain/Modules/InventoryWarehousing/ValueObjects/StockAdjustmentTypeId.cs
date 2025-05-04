using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// StockAdjustmentType Identifier Value Object
/// </summary>
public sealed class StockAdjustmentTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StockAdjustmentType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StockAdjustmentTypeId instance
    /// </summary>
    public StockAdjustmentTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StockAdjustmentTypeId with a new GUID
    /// </summary>
    public static StockAdjustmentTypeId CreateUnique()
    {
        return new StockAdjustmentTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StockAdjustmentTypeId id) => id.Value.ToString();
    public static implicit operator Guid(StockAdjustmentTypeId id) => id.Value;
}
}
