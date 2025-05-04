using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemSerialDescription Identifier Value Object
/// </summary>
public sealed class ItemSerialDescriptionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemSerialDescription
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemSerialDescriptionId instance
    /// </summary>
    public ItemSerialDescriptionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemSerialDescriptionId with a new GUID
    /// </summary>
    public static ItemSerialDescriptionId CreateUnique()
    {
        return new ItemSerialDescriptionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemSerialDescriptionId id) => id.Value.ToString();
    public static implicit operator Guid(ItemSerialDescriptionId id) => id.Value;
}
}
