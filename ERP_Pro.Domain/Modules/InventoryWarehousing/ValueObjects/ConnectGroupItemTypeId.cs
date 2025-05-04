using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ConnectGroupItemType Identifier Value Object
/// </summary>
public sealed class ConnectGroupItemTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ConnectGroupItemType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ConnectGroupItemTypeId instance
    /// </summary>
    public ConnectGroupItemTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ConnectGroupItemTypeId with a new GUID
    /// </summary>
    public static ConnectGroupItemTypeId CreateUnique()
    {
        return new ConnectGroupItemTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ConnectGroupItemTypeId id) => id.Value.ToString();
    public static implicit operator Guid(ConnectGroupItemTypeId id) => id.Value;
}
}
