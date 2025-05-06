using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// DeviceTypes Identifier Value Object
/// </summary>
public sealed class DeviceTypesId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DeviceTypes
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DeviceTypesId instance
    /// </summary>
    public DeviceTypesId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DeviceTypesId with a new GUID
    /// </summary>
    public static DeviceTypesId CreateUnique()
    {
        return new DeviceTypesId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DeviceTypesId id) => id.Value.ToString();
    public static implicit operator Guid(DeviceTypesId id) => id.Value;
}
}
