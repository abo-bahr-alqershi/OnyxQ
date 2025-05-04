using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// WarehouseTransferMultiDetail Identifier Value Object
/// </summary>
public sealed class WarehouseTransferMultiDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WarehouseTransferMultiDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehouseTransferMultiDetailId instance
    /// </summary>
    public WarehouseTransferMultiDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehouseTransferMultiDetailId with a new GUID
    /// </summary>
    public static WarehouseTransferMultiDetailId CreateUnique()
    {
        return new WarehouseTransferMultiDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehouseTransferMultiDetailId id) => id.Value.ToString();
    public static implicit operator Guid(WarehouseTransferMultiDetailId id) => id.Value;
}
}
