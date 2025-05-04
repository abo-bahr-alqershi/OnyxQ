using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryManagementTemp Identifier Value Object
/// </summary>
public sealed class InventoryManagementTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryManagementTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryManagementTempId instance
    /// </summary>
    public InventoryManagementTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryManagementTempId with a new GUID
    /// </summary>
    public static InventoryManagementTempId CreateUnique()
    {
        return new InventoryManagementTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryManagementTempId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryManagementTempId id) => id.Value;
}
}
