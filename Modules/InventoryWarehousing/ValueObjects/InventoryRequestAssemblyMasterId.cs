using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryRequestAssemblyMaster Identifier Value Object
/// </summary>
public sealed class InventoryRequestAssemblyMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryRequestAssemblyMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryRequestAssemblyMasterId instance
    /// </summary>
    public InventoryRequestAssemblyMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryRequestAssemblyMasterId with a new GUID
    /// </summary>
    public static InventoryRequestAssemblyMasterId CreateUnique()
    {
        return new InventoryRequestAssemblyMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryRequestAssemblyMasterId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryRequestAssemblyMasterId id) => id.Value;
}
}
