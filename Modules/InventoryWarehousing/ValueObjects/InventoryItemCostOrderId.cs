using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryItemCostOrder Identifier Value Object
/// </summary>
public sealed class InventoryItemCostOrderId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryItemCostOrder
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryItemCostOrderId instance
    /// </summary>
    public InventoryItemCostOrderId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryItemCostOrderId with a new GUID
    /// </summary>
    public static InventoryItemCostOrderId CreateUnique()
    {
        return new InventoryItemCostOrderId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryItemCostOrderId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryItemCostOrderId id) => id.Value;
}
}
