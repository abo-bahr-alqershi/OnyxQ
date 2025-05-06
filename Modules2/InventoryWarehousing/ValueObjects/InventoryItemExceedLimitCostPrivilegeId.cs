using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryItemExceedLimitCostPrivilege Identifier Value Object
/// </summary>
public sealed class InventoryItemExceedLimitCostPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryItemExceedLimitCostPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryItemExceedLimitCostPrivilegeId instance
    /// </summary>
    public InventoryItemExceedLimitCostPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryItemExceedLimitCostPrivilegeId with a new GUID
    /// </summary>
    public static InventoryItemExceedLimitCostPrivilegeId CreateUnique()
    {
        return new InventoryItemExceedLimitCostPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryItemExceedLimitCostPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryItemExceedLimitCostPrivilegeId id) => id.Value;
}
}
