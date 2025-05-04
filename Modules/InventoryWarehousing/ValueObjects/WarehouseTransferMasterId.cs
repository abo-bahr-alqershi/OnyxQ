using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// WarehouseTransferMaster Identifier Value Object
/// </summary>
public sealed class WarehouseTransferMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WarehouseTransferMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehouseTransferMasterId instance
    /// </summary>
    public WarehouseTransferMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehouseTransferMasterId with a new GUID
    /// </summary>
    public static WarehouseTransferMasterId CreateUnique()
    {
        return new WarehouseTransferMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehouseTransferMasterId id) => id.Value.ToString();
    public static implicit operator Guid(WarehouseTransferMasterId id) => id.Value;
}
}
