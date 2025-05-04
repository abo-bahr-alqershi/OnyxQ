using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeStockAdjustmentTypes Identifier Value Object
/// </summary>
public sealed class PrivilegeStockAdjustmentTypesId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeStockAdjustmentTypes
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeStockAdjustmentTypesId instance
    /// </summary>
    public PrivilegeStockAdjustmentTypesId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeStockAdjustmentTypesId with a new GUID
    /// </summary>
    public static PrivilegeStockAdjustmentTypesId CreateUnique()
    {
        return new PrivilegeStockAdjustmentTypesId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeStockAdjustmentTypesId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeStockAdjustmentTypesId id) => id.Value;
}
}
