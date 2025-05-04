using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ConnectWarehouseCodeByActivity Identifier Value Object
/// </summary>
public sealed class ConnectWarehouseCodeByActivityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ConnectWarehouseCodeByActivity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ConnectWarehouseCodeByActivityId instance
    /// </summary>
    public ConnectWarehouseCodeByActivityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ConnectWarehouseCodeByActivityId with a new GUID
    /// </summary>
    public static ConnectWarehouseCodeByActivityId CreateUnique()
    {
        return new ConnectWarehouseCodeByActivityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ConnectWarehouseCodeByActivityId id) => id.Value.ToString();
    public static implicit operator Guid(ConnectWarehouseCodeByActivityId id) => id.Value;
}
}
