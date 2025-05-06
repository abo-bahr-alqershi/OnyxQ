using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BranchWarehouseTransferMaster Identifier Value Object
/// </summary>
public sealed class BranchWarehouseTransferMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchWarehouseTransferMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchWarehouseTransferMasterId instance
    /// </summary>
    public BranchWarehouseTransferMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchWarehouseTransferMasterId with a new GUID
    /// </summary>
    public static BranchWarehouseTransferMasterId CreateUnique()
    {
        return new BranchWarehouseTransferMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchWarehouseTransferMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BranchWarehouseTransferMasterId id) => id.Value;
}
}
