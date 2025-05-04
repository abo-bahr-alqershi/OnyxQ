using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryRequestAssemblyDetail Identifier Value Object
/// </summary>
public sealed class InventoryRequestAssemblyDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryRequestAssemblyDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryRequestAssemblyDetailId instance
    /// </summary>
    public InventoryRequestAssemblyDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryRequestAssemblyDetailId with a new GUID
    /// </summary>
    public static InventoryRequestAssemblyDetailId CreateUnique()
    {
        return new InventoryRequestAssemblyDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryRequestAssemblyDetailId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryRequestAssemblyDetailId id) => id.Value;
}
}
