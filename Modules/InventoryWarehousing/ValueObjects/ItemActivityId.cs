using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemActivity Identifier Value Object
/// </summary>
public sealed class ItemActivityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemActivity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemActivityId instance
    /// </summary>
    public ItemActivityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemActivityId with a new GUID
    /// </summary>
    public static ItemActivityId CreateUnique()
    {
        return new ItemActivityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemActivityId id) => id.Value.ToString();
    public static implicit operator Guid(ItemActivityId id) => id.Value;
}
}
