using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// WarehouseTransferMultiMaster Identifier Value Object
/// </summary>
public sealed class WarehouseTransferMultiMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WarehouseTransferMultiMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehouseTransferMultiMasterId instance
    /// </summary>
    public WarehouseTransferMultiMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehouseTransferMultiMasterId with a new GUID
    /// </summary>
    public static WarehouseTransferMultiMasterId CreateUnique()
    {
        return new WarehouseTransferMultiMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehouseTransferMultiMasterId id) => id.Value.ToString();
    public static implicit operator Guid(WarehouseTransferMultiMasterId id) => id.Value;
}
}
