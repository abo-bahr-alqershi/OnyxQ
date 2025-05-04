using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryType Identifier Value Object
/// </summary>
public sealed class InventoryTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryTypeId instance
    /// </summary>
    public InventoryTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryTypeId with a new GUID
    /// </summary>
    public static InventoryTypeId CreateUnique()
    {
        return new InventoryTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryTypeId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryTypeId id) => id.Value;
}
}
