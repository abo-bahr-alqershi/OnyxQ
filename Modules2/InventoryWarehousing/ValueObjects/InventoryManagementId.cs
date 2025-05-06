using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryManagement Identifier Value Object
/// </summary>
public sealed class InventoryManagementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryManagement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryManagementId instance
    /// </summary>
    public InventoryManagementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryManagementId with a new GUID
    /// </summary>
    public static InventoryManagementId CreateUnique()
    {
        return new InventoryManagementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryManagementId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryManagementId id) => id.Value;
}
}
