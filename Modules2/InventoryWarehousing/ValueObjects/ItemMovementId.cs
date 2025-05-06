using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemMovement Identifier Value Object
/// </summary>
public sealed class ItemMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemMovementId instance
    /// </summary>
    public ItemMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemMovementId with a new GUID
    /// </summary>
    public static ItemMovementId CreateUnique()
    {
        return new ItemMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemMovementId id) => id.Value.ToString();
    public static implicit operator Guid(ItemMovementId id) => id.Value;
}
}
