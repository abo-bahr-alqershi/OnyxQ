using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemAlternative Identifier Value Object
/// </summary>
public sealed class ItemAlternativeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemAlternative
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemAlternativeId instance
    /// </summary>
    public ItemAlternativeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemAlternativeId with a new GUID
    /// </summary>
    public static ItemAlternativeId CreateUnique()
    {
        return new ItemAlternativeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemAlternativeId id) => id.Value.ToString();
    public static implicit operator Guid(ItemAlternativeId id) => id.Value;
}
}
