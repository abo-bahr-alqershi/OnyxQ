using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// OnlineConnectWarehouseCode Identifier Value Object
/// </summary>
public sealed class OnlineConnectWarehouseCodeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OnlineConnectWarehouseCode
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OnlineConnectWarehouseCodeId instance
    /// </summary>
    public OnlineConnectWarehouseCodeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OnlineConnectWarehouseCodeId with a new GUID
    /// </summary>
    public static OnlineConnectWarehouseCodeId CreateUnique()
    {
        return new OnlineConnectWarehouseCodeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OnlineConnectWarehouseCodeId id) => id.Value.ToString();
    public static implicit operator Guid(OnlineConnectWarehouseCodeId id) => id.Value;
}
}
