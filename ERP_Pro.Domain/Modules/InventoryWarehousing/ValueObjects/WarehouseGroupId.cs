using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// WarehouseGroup Identifier Value Object
/// </summary>
public sealed class WarehouseGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WarehouseGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehouseGroupId instance
    /// </summary>
    public WarehouseGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehouseGroupId with a new GUID
    /// </summary>
    public static WarehouseGroupId CreateUnique()
    {
        return new WarehouseGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehouseGroupId id) => id.Value.ToString();
    public static implicit operator Guid(WarehouseGroupId id) => id.Value;
}
}
