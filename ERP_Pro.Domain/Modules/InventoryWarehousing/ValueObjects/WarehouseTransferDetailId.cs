using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// WarehouseTransferDetail Identifier Value Object
/// </summary>
public sealed class WarehouseTransferDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WarehouseTransferDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehouseTransferDetailId instance
    /// </summary>
    public WarehouseTransferDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehouseTransferDetailId with a new GUID
    /// </summary>
    public static WarehouseTransferDetailId CreateUnique()
    {
        return new WarehouseTransferDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehouseTransferDetailId id) => id.Value.ToString();
    public static implicit operator Guid(WarehouseTransferDetailId id) => id.Value;
}
}
