using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BranchWarehouseTransferDetail Identifier Value Object
/// </summary>
public sealed class BranchWarehouseTransferDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchWarehouseTransferDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchWarehouseTransferDetailId instance
    /// </summary>
    public BranchWarehouseTransferDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchWarehouseTransferDetailId with a new GUID
    /// </summary>
    public static BranchWarehouseTransferDetailId CreateUnique()
    {
        return new BranchWarehouseTransferDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchWarehouseTransferDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BranchWarehouseTransferDetailId id) => id.Value;
}
}
