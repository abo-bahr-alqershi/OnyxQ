using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ConnectItemMeasurementUnit Identifier Value Object
/// </summary>
public sealed class ConnectItemMeasurementUnitId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ConnectItemMeasurementUnit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ConnectItemMeasurementUnitId instance
    /// </summary>
    public ConnectItemMeasurementUnitId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ConnectItemMeasurementUnitId with a new GUID
    /// </summary>
    public static ConnectItemMeasurementUnitId CreateUnique()
    {
        return new ConnectItemMeasurementUnitId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ConnectItemMeasurementUnitId id) => id.Value.ToString();
    public static implicit operator Guid(ConnectItemMeasurementUnitId id) => id.Value;
}
}
