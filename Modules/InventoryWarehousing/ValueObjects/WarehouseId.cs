using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// Warehouse Identifier Value Object
/// </summary>
public sealed class WarehouseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Warehouse
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehouseId instance
    /// </summary>
    public WarehouseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehouseId with a new GUID
    /// </summary>
    public static WarehouseId CreateUnique()
    {
        return new WarehouseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehouseId id) => id.Value.ToString();
    public static implicit operator Guid(WarehouseId id) => id.Value;
}
}
