using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// LowLimitPeriodStock Identifier Value Object
/// </summary>
public sealed class LowLimitPeriodStockId : ValueObject
{
    /// <summary>
    /// The unique identifier for the LowLimitPeriodStock
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new LowLimitPeriodStockId instance
    /// </summary>
    public LowLimitPeriodStockId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new LowLimitPeriodStockId with a new GUID
    /// </summary>
    public static LowLimitPeriodStockId CreateUnique()
    {
        return new LowLimitPeriodStockId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(LowLimitPeriodStockId id) => id.Value.ToString();
    public static implicit operator Guid(LowLimitPeriodStockId id) => id.Value;
}
}
