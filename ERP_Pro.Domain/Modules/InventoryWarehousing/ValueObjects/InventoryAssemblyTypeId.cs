using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryAssemblyType Identifier Value Object
/// </summary>
public sealed class InventoryAssemblyTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryAssemblyType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryAssemblyTypeId instance
    /// </summary>
    public InventoryAssemblyTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryAssemblyTypeId with a new GUID
    /// </summary>
    public static InventoryAssemblyTypeId CreateUnique()
    {
        return new InventoryAssemblyTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryAssemblyTypeId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryAssemblyTypeId id) => id.Value;
}
}
