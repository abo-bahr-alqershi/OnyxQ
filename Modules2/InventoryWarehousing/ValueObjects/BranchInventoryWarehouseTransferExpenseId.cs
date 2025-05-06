using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BranchInventoryWarehouseTransferExpense Identifier Value Object
/// </summary>
public sealed class BranchInventoryWarehouseTransferExpenseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchInventoryWarehouseTransferExpense
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchInventoryWarehouseTransferExpenseId instance
    /// </summary>
    public BranchInventoryWarehouseTransferExpenseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchInventoryWarehouseTransferExpenseId with a new GUID
    /// </summary>
    public static BranchInventoryWarehouseTransferExpenseId CreateUnique()
    {
        return new BranchInventoryWarehouseTransferExpenseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchInventoryWarehouseTransferExpenseId id) => id.Value.ToString();
    public static implicit operator Guid(BranchInventoryWarehouseTransferExpenseId id) => id.Value;
}
}
