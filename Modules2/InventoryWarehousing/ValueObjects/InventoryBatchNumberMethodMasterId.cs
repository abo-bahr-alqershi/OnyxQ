using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryBatchNumberMethodMaster Identifier Value Object
/// </summary>
public sealed class InventoryBatchNumberMethodMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryBatchNumberMethodMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryBatchNumberMethodMasterId instance
    /// </summary>
    public InventoryBatchNumberMethodMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryBatchNumberMethodMasterId with a new GUID
    /// </summary>
    public static InventoryBatchNumberMethodMasterId CreateUnique()
    {
        return new InventoryBatchNumberMethodMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryBatchNumberMethodMasterId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryBatchNumberMethodMasterId id) => id.Value;
}
}
