using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryWarehouseTransferExpense Identifier Value Object
/// </summary>
public sealed class InventoryWarehouseTransferExpenseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryWarehouseTransferExpense
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryWarehouseTransferExpenseId instance
    /// </summary>
    public InventoryWarehouseTransferExpenseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryWarehouseTransferExpenseId with a new GUID
    /// </summary>
    public static InventoryWarehouseTransferExpenseId CreateUnique()
    {
        return new InventoryWarehouseTransferExpenseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryWarehouseTransferExpenseId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryWarehouseTransferExpenseId id) => id.Value;
}
}
