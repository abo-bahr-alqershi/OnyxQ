using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemGrantCard Identifier Value Object
/// </summary>
public sealed class ItemGrantCardId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemGrantCard
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemGrantCardId instance
    /// </summary>
    public ItemGrantCardId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemGrantCardId with a new GUID
    /// </summary>
    public static ItemGrantCardId CreateUnique()
    {
        return new ItemGrantCardId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemGrantCardId id) => id.Value.ToString();
    public static implicit operator Guid(ItemGrantCardId id) => id.Value;
}
}
