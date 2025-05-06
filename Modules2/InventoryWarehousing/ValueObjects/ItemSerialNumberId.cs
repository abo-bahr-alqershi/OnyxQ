using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemSerialNumber Identifier Value Object
/// </summary>
public sealed class ItemSerialNumberId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemSerialNumber
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemSerialNumberId instance
    /// </summary>
    public ItemSerialNumberId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemSerialNumberId with a new GUID
    /// </summary>
    public static ItemSerialNumberId CreateUnique()
    {
        return new ItemSerialNumberId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemSerialNumberId id) => id.Value.ToString();
    public static implicit operator Guid(ItemSerialNumberId id) => id.Value;
}
}
