using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// OnlineConnectWarehouseCodeRegion Identifier Value Object
/// </summary>
public sealed class OnlineConnectWarehouseCodeRegionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OnlineConnectWarehouseCodeRegion
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OnlineConnectWarehouseCodeRegionId instance
    /// </summary>
    public OnlineConnectWarehouseCodeRegionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OnlineConnectWarehouseCodeRegionId with a new GUID
    /// </summary>
    public static OnlineConnectWarehouseCodeRegionId CreateUnique()
    {
        return new OnlineConnectWarehouseCodeRegionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OnlineConnectWarehouseCodeRegionId id) => id.Value.ToString();
    public static implicit operator Guid(OnlineConnectWarehouseCodeRegionId id) => id.Value;
}
}
