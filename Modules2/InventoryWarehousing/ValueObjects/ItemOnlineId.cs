using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemOnline Identifier Value Object
/// </summary>
public sealed class ItemOnlineId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemOnline
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemOnlineId instance
    /// </summary>
    public ItemOnlineId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemOnlineId with a new GUID
    /// </summary>
    public static ItemOnlineId CreateUnique()
    {
        return new ItemOnlineId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemOnlineId id) => id.Value.ToString();
    public static implicit operator Guid(ItemOnlineId id) => id.Value;
}
}
