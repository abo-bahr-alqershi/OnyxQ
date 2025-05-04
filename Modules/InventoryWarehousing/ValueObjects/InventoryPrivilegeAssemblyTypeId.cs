using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryPrivilegeAssemblyType Identifier Value Object
/// </summary>
public sealed class InventoryPrivilegeAssemblyTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryPrivilegeAssemblyType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryPrivilegeAssemblyTypeId instance
    /// </summary>
    public InventoryPrivilegeAssemblyTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryPrivilegeAssemblyTypeId with a new GUID
    /// </summary>
    public static InventoryPrivilegeAssemblyTypeId CreateUnique()
    {
        return new InventoryPrivilegeAssemblyTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryPrivilegeAssemblyTypeId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryPrivilegeAssemblyTypeId id) => id.Value;
}
}
